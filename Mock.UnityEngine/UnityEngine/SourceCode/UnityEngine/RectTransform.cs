namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public sealed class RectTransform : Transform
    {
        public static  event ReapplyDrivenProperties reapplyDrivenProperties;


        public void GetLocalCorners(Vector3[] fourCornersArray)
        {
            if ((fourCornersArray == null) || (fourCornersArray.Length < 4))
            {
                Debug.LogError("Calling GetLocalCorners with an array that is null or has less than 4 elements.");
            }
            else
            {
                Rect rect = this.rect;
                float x = rect.x;
                float y = rect.y;
                float xMax = rect.xMax;
                float yMax = rect.yMax;
                fourCornersArray[0] = new Vector3(x, y, 0f);
                fourCornersArray[1] = new Vector3(x, yMax, 0f);
                fourCornersArray[2] = new Vector3(xMax, yMax, 0f);
                fourCornersArray[3] = new Vector3(xMax, y, 0f);
            }
        }

        private Vector2 GetParentSize()
        {
            RectTransform parent = base.parent as RectTransform;
            if (parent == null)
            {
                return Vector2.zero;
            }
            return parent.rect.size;
        }

        internal Rect GetRectInParentSpace()
        {
            Rect rect = this.rect;
            Vector2 vector = this.offsetMin + Vector2.Scale(this.pivot, rect.size);
            Transform parent = base.transform.parent;
            if (parent != null)
            {
                RectTransform component = parent.GetComponent<RectTransform>();
                if (component != null)
                {
                    vector += Vector2.Scale(this.anchorMin, component.rect.size);
                }
            }
            rect.x += vector.x;
            rect.y += vector.y;
            return rect;
        }

        public void GetWorldCorners(Vector3[] fourCornersArray)
        {
            if ((fourCornersArray == null) || (fourCornersArray.Length < 4))
            {
                Debug.LogError("Calling GetWorldCorners with an array that is null or has less than 4 elements.");
            }
            else
            {
                this.GetLocalCorners(fourCornersArray);
                Transform transform = base.transform;
                for (int i = 0; i < 4; i++)
                {
                    fourCornersArray[i] = transform.TransformPoint(fourCornersArray[i]);
                }
            }
        }

     
        internal static void SendReapplyDrivenProperties(RectTransform driven)
        {
            if (reapplyDrivenProperties != null)
            {
                reapplyDrivenProperties(driven);
            }
        }

        public void SetInsetAndSizeFromParentEdge(Edge edge, float inset, float size)
        {
            int num = ((edge != Edge.Top) && (edge != Edge.Bottom)) ? 0 : 1;
            bool flag = (edge == Edge.Top) || (edge == Edge.Right);
            float num2 = !flag ? ((float) 0) : ((float) 1);
            Vector2 anchorMin = this.anchorMin;
            anchorMin[num] = num2;
            this.anchorMin = anchorMin;
            anchorMin = this.anchorMax;
            anchorMin[num] = num2;
            this.anchorMax = anchorMin;
            Vector2 sizeDelta = this.sizeDelta;
            sizeDelta[num] = size;
            this.sizeDelta = sizeDelta;
            Vector2 anchoredPosition = this.anchoredPosition;
            anchoredPosition[num] = !flag ? (inset + (size * this.pivot[num])) : (-inset - (size * (1f - this.pivot[num])));
            this.anchoredPosition = anchoredPosition;
        }

        public void SetSizeWithCurrentAnchors(Axis axis, float size)
        {
            int num = (int) axis;
            Vector2 sizeDelta = this.sizeDelta;
            sizeDelta[num] = size - (this.GetParentSize()[num] * (this.anchorMax[num] - this.anchorMin[num]));
            this.sizeDelta = sizeDelta;
        }

        public Vector2 anchoredPosition { get; set; }

        public Vector3 anchoredPosition3D
        {
            get
            {
                Vector2 anchoredPosition = this.anchoredPosition;
                return new Vector3(anchoredPosition.x, anchoredPosition.y, base.localPosition.z);
            }
            set
            {
                this.anchoredPosition = new Vector2(value.x, value.y);
                Vector3 localPosition = base.localPosition;
                localPosition.z = value.z;
                base.localPosition = localPosition;
            }
        }

        public Vector2 anchorMax { get; set; }

        public Vector2 anchorMin { get; set; }

        internal Object drivenByObject {  get;  set; }

        internal DrivenTransformProperties drivenProperties {  get;  set; }

        public Vector2 offsetMax
        {
            get
            {
                return (this.anchoredPosition + Vector2.Scale(this.sizeDelta, Vector2.one - this.pivot));
            }
            set
            {
                Vector2 a = value - (this.anchoredPosition + Vector2.Scale(this.sizeDelta, Vector2.one - this.pivot));
                this.sizeDelta += a;
                this.anchoredPosition += Vector2.Scale(a, this.pivot);
            }
        }

        public Vector2 offsetMin
        {
            get
            {
                return (this.anchoredPosition - Vector2.Scale(this.sizeDelta, this.pivot));
            }
            set
            {
                Vector2 a = value - (this.anchoredPosition - Vector2.Scale(this.sizeDelta, this.pivot));
                this.sizeDelta -= a;
                this.anchoredPosition += Vector2.Scale(a, Vector2.one - this.pivot);
            }
        }

        public Vector2 pivot { get; set; }

        public Rect rect
        {
            get
            {
                Rect rect;
                return new Rect(0,0,0,0);
            }
        }

        public Vector2 sizeDelta
        {
            get; set; }

        public enum Axis
        {
            Horizontal,
            Vertical
        }

        public enum Edge
        {
            Left,
            Right,
            Top,
            Bottom
        }

        public delegate void ReapplyDrivenProperties(RectTransform driven);
    }
}

