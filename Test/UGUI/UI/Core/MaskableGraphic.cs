using System;
using UnityEngine.Events;
using UnityEngine.Rendering;

namespace UnityEngine.UI
{
    public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
    {
        [NonSerialized]
        protected bool m_ShouldRecalculateStencil ;

        [NonSerialized]
        protected Material m_MaskMaterial;

        [NonSerialized]
        private RectMask2D m_ParentMask;

        public bool maskable { get; set; }


        [NonSerialized]
        protected int m_StencilValue;

        public virtual Material GetModifiedMaterial(Material baseMaterial)
        {
            var toUse = baseMaterial;

            if (m_ShouldRecalculateStencil)
            {
                var rootCanvas = MaskUtilities.FindRootSortOverrideCanvas(transform);
                m_StencilValue = maskable ? MaskUtilities.GetStencilDepth(transform, rootCanvas) : 0;
                m_ShouldRecalculateStencil = false;
            }

            // if we have a Mask component then it will
            // generate the mask material. This is an optimisation
            // it adds some coupling between components though :(
            if (m_StencilValue > 0 && GetComponent<Mask>() == null)
            {
                var maskMat = StencilMaterial.Add(toUse, (1 << m_StencilValue) - 1, StencilOp.Keep, CompareFunction.Equal, ColorWriteMask.All, (1 << m_StencilValue) - 1, 0);
                StencilMaterial.Remove(m_MaskMaterial);
                m_MaskMaterial = maskMat;
                toUse = m_MaskMaterial;
            }
            return toUse;
        }

        public virtual void Cull(Rect clipRect, bool validRect)
        {
            if (!canvasRenderer.hasMoved)
                return;

            var cull = !validRect || !clipRect.Overlaps(canvasRect);
            var cullingChanged = canvasRenderer.cull != cull;
            canvasRenderer.cull = cull;

            if (cullingChanged)
            {
                SetVerticesDirty();
            }
        }

        public virtual void SetClipRect(Rect clipRect, bool validRect)
        {
            if (validRect)
                canvasRenderer.EnableRectClipping(clipRect);
            else
                canvasRenderer.DisableRectClipping();
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            m_ShouldRecalculateStencil = true;
            UpdateClipParent();
            SetMaterialDirty();
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            m_ShouldRecalculateStencil = true;
            SetMaterialDirty();
            UpdateClipParent();
            StencilMaterial.Remove(m_MaskMaterial);
            m_MaskMaterial = null;
        }

#if UNITY_EDITOR
        protected override void OnValidate()
        {
            base.OnValidate();
            m_ShouldRecalculateStencil = true;
            UpdateClipParent();
            SetMaterialDirty();
        }

#endif

        protected override void OnTransformParentChanged()
        {
            base.OnTransformParentChanged();
            m_ShouldRecalculateStencil = true;
            UpdateClipParent();
            SetMaterialDirty();
        }

        [Obsolete("Not used anymore.", true)]
        public virtual void ParentMaskStateChanged() {}

        protected override void OnCanvasHierarchyChanged()
        {
            base.OnCanvasHierarchyChanged();
            m_ShouldRecalculateStencil = true;
            UpdateClipParent();
            SetMaterialDirty();
        }

        private Rect canvasRect
        {
            get
            {
               return new Rect(0,0,0,0);
            }
        }

        private void UpdateClipParent()
        {
            var newParent = (maskable && IsActive()) ? MaskUtilities.GetRectMaskForClippable(this) : null;

            if (newParent != m_ParentMask && m_ParentMask != null)
                m_ParentMask.RemoveClippable(this);

            if (newParent != null)
                newParent.AddClippable(this);

            m_ParentMask = newParent;
        }

        public virtual void RecalculateClipping()
        {
            UpdateClipParent();
        }

        public virtual void RecalculateMasking()
        {
            m_ShouldRecalculateStencil = true;
            SetMaterialDirty();
        }
    }
}
