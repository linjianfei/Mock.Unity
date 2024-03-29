﻿//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//    using System.Runtime.InteropServices;
//
//    [Serializable, StructLayout(LayoutKind.Sequential)]
//    public sealed class GUIStyle
//    {
//        [NonSerialized]
//        internal IntPtr m_Ptr;
//        [NonSerialized]
//        private GUIStyleState m_Normal;
//        [NonSerialized]
//        private GUIStyleState m_Hover;
//        [NonSerialized]
//        private GUIStyleState m_Active;
//        [NonSerialized]
//        private GUIStyleState m_Focused;
//        [NonSerialized]
//        private GUIStyleState m_OnNormal;
//        [NonSerialized]
//        private GUIStyleState m_OnHover;
//        [NonSerialized]
//        private GUIStyleState m_OnActive;
//        [NonSerialized]
//        private GUIStyleState m_OnFocused;
//        [NonSerialized]
//        private RectOffset m_Border;
//        [NonSerialized]
//        private RectOffset m_Padding;
//        [NonSerialized]
//        private RectOffset m_Margin;
//        [NonSerialized]
//        private RectOffset m_Overflow;
//        [NonSerialized]
//        private Font m_FontInternal;
//        internal static bool showKeyboardFocus = true;
//        private static GUIStyle s_None;
//        public GUIStyle()
//        {
//            this.Init();
//        }
//
//        public GUIStyle(GUIStyle other)
//        {
//            this.InitCopy(other);
//        }
//
//        ~GUIStyle()
//        {
//            this.Cleanup();
//        }
//
//        internal void InternalOnAfterDeserialize()
//        {
//            this.m_FontInternal = this.GetFontInternal();
//            this.m_Normal = new GUIStyleState(this, this.GetStyleStatePtr(0));
//            this.m_Hover = new GUIStyleState(this, this.GetStyleStatePtr(1));
//            this.m_Active = new GUIStyleState(this, this.GetStyleStatePtr(2));
//            this.m_Focused = new GUIStyleState(this, this.GetStyleStatePtr(3));
//            this.m_OnNormal = new GUIStyleState(this, this.GetStyleStatePtr(4));
//            this.m_OnHover = new GUIStyleState(this, this.GetStyleStatePtr(5));
//            this.m_OnActive = new GUIStyleState(this, this.GetStyleStatePtr(6));
//            this.m_OnFocused = new GUIStyleState(this, this.GetStyleStatePtr(7));
//        }
//
//        public GUIStyleState normal
//        {
//            get
//            {
//                if (this.m_Normal == null)
//                {
//                    this.m_Normal = new GUIStyleState(this, this.GetStyleStatePtr(0));
//                }
//                return this.m_Normal;
//            }
//            set
//            {
//                this.AssignStyleState(0, value.m_Ptr);
//            }
//        }
//        public GUIStyleState hover
//        {
//            get
//            {
//                if (this.m_Hover == null)
//                {
//                    this.m_Hover = new GUIStyleState(this, this.GetStyleStatePtr(1));
//                }
//                return this.m_Hover;
//            }
//            set
//            {
//                this.AssignStyleState(1, value.m_Ptr);
//            }
//        }
//        public GUIStyleState active
//        {
//            get
//            {
//                if (this.m_Active == null)
//                {
//                    this.m_Active = new GUIStyleState(this, this.GetStyleStatePtr(2));
//                }
//                return this.m_Active;
//            }
//            set
//            {
//                this.AssignStyleState(2, value.m_Ptr);
//            }
//        }
//        public GUIStyleState onNormal
//        {
//            get
//            {
//                if (this.m_OnNormal == null)
//                {
//                    this.m_OnNormal = new GUIStyleState(this, this.GetStyleStatePtr(4));
//                }
//                return this.m_OnNormal;
//            }
//            set
//            {
//                this.AssignStyleState(4, value.m_Ptr);
//            }
//        }
//        public GUIStyleState onHover
//        {
//            get
//            {
//                if (this.m_OnHover == null)
//                {
//                    this.m_OnHover = new GUIStyleState(this, this.GetStyleStatePtr(5));
//                }
//                return this.m_OnHover;
//            }
//            set
//            {
//                this.AssignStyleState(5, value.m_Ptr);
//            }
//        }
//        public GUIStyleState onActive
//        {
//            get
//            {
//                if (this.m_OnActive == null)
//                {
//                    this.m_OnActive = new GUIStyleState(this, this.GetStyleStatePtr(6));
//                }
//                return this.m_OnActive;
//            }
//            set
//            {
//                this.AssignStyleState(6, value.m_Ptr);
//            }
//        }
//        public GUIStyleState focused
//        {
//            get
//            {
//                if (this.m_Focused == null)
//                {
//                    this.m_Focused = new GUIStyleState(this, this.GetStyleStatePtr(3));
//                }
//                return this.m_Focused;
//            }
//            set
//            {
//                this.AssignStyleState(3, value.m_Ptr);
//            }
//        }
//        public GUIStyleState onFocused
//        {
//            get
//            {
//                if (this.m_OnFocused == null)
//                {
//                    this.m_OnFocused = new GUIStyleState(this, this.GetStyleStatePtr(7));
//                }
//                return this.m_OnFocused;
//            }
//            set
//            {
//                this.AssignStyleState(7, value.m_Ptr);
//            }
//        }
//        public RectOffset border
//        {
//            get
//            {
//                if (this.m_Border == null)
//                {
//                    this.m_Border = new RectOffset(this, this.GetRectOffsetPtr(0));
//                }
//                return this.m_Border;
//            }
//            set
//            {
//                this.AssignRectOffset(0, value.m_Ptr);
//            }
//        }
//        public RectOffset margin
//        {
//            get
//            {
//                if (this.m_Margin == null)
//                {
//                    this.m_Margin = new RectOffset(this, this.GetRectOffsetPtr(1));
//                }
//                return this.m_Margin;
//            }
//            set
//            {
//                this.AssignRectOffset(1, value.m_Ptr);
//            }
//        }
//        public RectOffset padding
//        {
//            get
//            {
//                if (this.m_Padding == null)
//                {
//                    this.m_Padding = new RectOffset(this, this.GetRectOffsetPtr(2));
//                }
//                return this.m_Padding;
//            }
//            set
//            {
//                this.AssignRectOffset(2, value.m_Ptr);
//            }
//        }
//        public RectOffset overflow
//        {
//            get
//            {
//                if (this.m_Overflow == null)
//                {
//                    this.m_Overflow = new RectOffset(this, this.GetRectOffsetPtr(3));
//                }
//                return this.m_Overflow;
//            }
//            set
//            {
//                this.AssignRectOffset(3, value.m_Ptr);
//            }
//        }
//        [Obsolete("warning Don't use clipOffset - put things inside BeginGroup instead. This functionality will be removed in a later version.")]
//        public Vector2 clipOffset
//        {
//            get
//            {
//                return this.Internal_clipOffset;
//            }
//            set
//            {
//                this.Internal_clipOffset = value;
//            }
//        }
//        public Font font
//        {
//            get
//            {
//                return this.GetFontInternal();
//            }
//            set
//            {
//                this.SetFontInternal(value);
//                this.m_FontInternal = value;
//            }
//        }
//        public float lineHeight
//        {
//            get
//            {
//                return Mathf.Round(Internal_GetLineHeight(this.m_Ptr));
//            }
//        }
//        private static void Internal_Draw(IntPtr target, Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
//        {
//            Internal_DrawArguments arguments = new Internal_DrawArguments {
//                target = target,
//                position = position,
//                isHover = !isHover ? 0 : 1,
//                isActive = !isActive ? 0 : 1,
//                on = !on ? 0 : 1,
//                hasKeyboardFocus = !hasKeyboardFocus ? 0 : 1
//            };
//            Internal_Draw(content, ref arguments);
//        }
//
//        public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
//        {
//            if (Event.current.type != EventType.Repaint)
//            {
//                Debug.LogError("Style.Draw may not be called if it is not a repaint event");
//            }
//            else
//            {
//                Internal_Draw(this.m_Ptr, position, GUIContent.none, isHover, isActive, on, hasKeyboardFocus);
//            }
//        }
//
//        public void Draw(Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
//        {
//            if (Event.current.type != EventType.Repaint)
//            {
//                Debug.LogError("Style.Draw may not be called if it is not a repaint event");
//            }
//            else
//            {
//                Internal_Draw(this.m_Ptr, position, GUIContent.Temp(text), isHover, isActive, on, hasKeyboardFocus);
//            }
//        }
//
//        public void Draw(Rect position, Texture image, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
//        {
//            if (Event.current.type != EventType.Repaint)
//            {
//                Debug.LogError("Style.Draw may not be called if it is not a repaint event");
//            }
//            else
//            {
//                Internal_Draw(this.m_Ptr, position, GUIContent.Temp(image), isHover, isActive, on, hasKeyboardFocus);
//            }
//        }
//
//        public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
//        {
//            if (Event.current.type != EventType.Repaint)
//            {
//                Debug.LogError("Style.Draw may not be called if it is not a repaint event");
//            }
//            else
//            {
//                Internal_Draw(this.m_Ptr, position, content, isHover, isActive, on, hasKeyboardFocus);
//            }
//        }
//
//        public void Draw(Rect position, GUIContent content, int controlID)
//        {
//            this.Draw(position, content, controlID, false);
//        }
//
//        public void Draw(Rect position, GUIContent content, int controlID, bool on)
//        {
//            if (Event.current.type != EventType.Repaint)
//            {
//                Debug.LogError("Style.Draw may not be called if it is not a repaint event.");
//            }
//            else if (content != null)
//            {
//                Internal_Draw2(this.m_Ptr, position, content, controlID, on);
//            }
//            else
//            {
//                Debug.LogError("Style.Draw may not be called with GUIContent that is null.");
//            }
//        }
//
//        internal void DrawPrefixLabel(Rect position, GUIContent content, int controlID)
//        {
//            if (content != null)
//            {
//                Internal_DrawPrefixLabel(this.m_Ptr, position, content, controlID, false);
//            }
//            else
//            {
//                Debug.LogError("Style.DrawPrefixLabel may not be called with GUIContent that is null.");
//            }
//        }
//
//        public void DrawCursor(Rect position, GUIContent content, int controlID, int Character)
//        {
//            if (Event.current.type == EventType.Repaint)
//            {
//                Color cursorColor = new Color(0f, 0f, 0f, 0f);
//                float cursorFlashSpeed = GUI.skin.settings.cursorFlashSpeed;
//                float num2 = ((Time.realtimeSinceStartup - Internal_GetCursorFlashOffset()) % cursorFlashSpeed) / cursorFlashSpeed;
//                if ((cursorFlashSpeed == 0f) || (num2 < 0.5f))
//                {
//                    cursorColor = GUI.skin.settings.cursorColor;
//                }
//                Internal_DrawCursor(this.m_Ptr, position, content, Character, cursorColor);
//            }
//        }
//
//        internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition)
//        {
//            if (Event.current.type != EventType.Repaint)
//            {
//                Debug.LogError("Style.Draw may not be called if it is not a repaint event");
//            }
//            else
//            {
//                Event current = Event.current;
//                Color cursorColor = new Color(0f, 0f, 0f, 0f);
//                float cursorFlashSpeed = GUI.skin.settings.cursorFlashSpeed;
//                float num2 = ((Time.realtimeSinceStartup - Internal_GetCursorFlashOffset()) % cursorFlashSpeed) / cursorFlashSpeed;
//                if ((cursorFlashSpeed == 0f) || (num2 < 0.5f))
//                {
//                    cursorColor = GUI.skin.settings.cursorColor;
//                }
//                Internal_DrawWithTextSelectionArguments arguments = new Internal_DrawWithTextSelectionArguments {
//                    target = this.m_Ptr,
//                    position = position,
//                    firstPos = firstSelectedCharacter,
//                    lastPos = lastSelectedCharacter,
//                    cursorColor = cursorColor,
//                    selectionColor = GUI.skin.settings.selectionColor,
//                    isHover = !position.Contains(current.mousePosition) ? 0 : 1,
//                    isActive = (controlID != GUIUtility.hotControl) ? 0 : 1,
//                    on = 0,
//                    hasKeyboardFocus = ((controlID != GUIUtility.keyboardControl) || !showKeyboardFocus) ? 0 : 1,
//                    drawSelectionAsComposition = !drawSelectionAsComposition ? 0 : 1
//                };
//                Internal_DrawWithTextSelection(content, ref arguments);
//            }
//        }
//
//        public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter)
//        {
//            this.DrawWithTextSelection(position, content, controlID, firstSelectedCharacter, lastSelectedCharacter, false);
//        }
//
//        public static GUIStyle none
//        {
//            get
//            {
//                if (s_None == null)
//                {
//                    s_None = new GUIStyle();
//                }
//                return s_None;
//            }
//        }
//        public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
//        {
//            Vector2 vector;
//            Internal_GetCursorPixelPosition(this.m_Ptr, position, content, cursorStringIndex, out vector);
//            return vector;
//        }
//
//        public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
//        {
//            return Internal_GetCursorStringIndex(this.m_Ptr, position, content, cursorPixelPosition);
//        }
//
//        internal int GetNumCharactersThatFitWithinWidth(string text, float width)
//        {
//            return Internal_GetNumCharactersThatFitWithinWidth(this.m_Ptr, text, width);
//        }
//
//        public Vector2 CalcSize(GUIContent content)
//        {
//            Vector2 vector;
//            Internal_CalcSize(this.m_Ptr, content, out vector);
//            return vector;
//        }
//
//        public Vector2 CalcScreenSize(Vector2 contentSize)
//        {
//            return new Vector2((this.fixedWidth == 0f) ? Mathf.Ceil((contentSize.x + this.padding.left) + this.padding.right) : this.fixedWidth, (this.fixedHeight == 0f) ? Mathf.Ceil((contentSize.y + this.padding.top) + this.padding.bottom) : this.fixedHeight);
//        }
//
//        public float CalcHeight(GUIContent content, float width)
//        {
//            return Internal_CalcHeight(this.m_Ptr, content, width);
//        }
//
//        public bool isHeightDependantOnWidth
//        {
//            get
//            {
//                return ((this.fixedHeight == 0f) && (this.wordWrap && (this.imagePosition != ImagePosition.ImageOnly)));
//            }
//        }
//        public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
//        {
//            Internal_CalcMinMaxWidth(this.m_Ptr, content, out minWidth, out maxWidth);
//        }
//
//        public override string ToString()
//        {
//            object[] args = new object[] { this.name };
//            return UnityString.Format("GUIStyle '{0}'", args);
//        }
//
//        
//        private extern void Init();
//        
//        private extern void InitCopy(GUIStyle other);
//        
//        private extern void Cleanup();
//        public string name {  get;  set; }
//        
//        private extern IntPtr GetStyleStatePtr(int idx);
//        
//        private extern void AssignStyleState(int idx, IntPtr srcStyleState);
//        
//        private extern IntPtr GetRectOffsetPtr(int idx);
//        
//        private extern void AssignRectOffset(int idx, IntPtr srcRectOffset);
//        public ImagePosition imagePosition {  get;  set; }
//        public TextAnchor alignment {  get;  set; }
//        public bool wordWrap {  get;  set; }
//        public TextClipping clipping {  get;  set; }
//        public Vector2 contentOffset
//        {
//            get
//            {
//                Vector2 vector;
//                this.INTERNAL_get_contentOffset(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_contentOffset(ref value);
//            }
//        }
//        
//        private extern void INTERNAL_get_contentOffset(out Vector2 value);
//        
//        private extern void INTERNAL_set_contentOffset(ref Vector2 value);
//        internal Vector2 Internal_clipOffset
//        {
//            get
//            {
//                Vector2 vector;
//                this.INTERNAL_get_Internal_clipOffset(out vector);
//                return vector;
//            }
//            set
//            {
//                this.INTERNAL_set_Internal_clipOffset(ref value);
//            }
//        }
//        
//        private extern void INTERNAL_get_Internal_clipOffset(out Vector2 value);
//        
//        private extern void INTERNAL_set_Internal_clipOffset(ref Vector2 value);
//        public float fixedWidth {  get;  set; }
//        public float fixedHeight {  get;  set; }
//        public bool stretchWidth {  get;  set; }
//        public bool stretchHeight {  get;  set; }
//        
//        private static extern float Internal_GetLineHeight(IntPtr target);
//        
//        private extern void SetFontInternal(Font value);
//        
//        private extern Font GetFontInternal();
//        public int fontSize {  get;  set; }
//        public FontStyle fontStyle {  get;  set; }
//        public bool richText {  get;  set; }
//        
//        private static extern void Internal_Draw(GUIContent content, ref Internal_DrawArguments arguments);
//        private static void Internal_Draw2(IntPtr style, Rect position, GUIContent content, int controlID, bool on)
//        {
//            INTERNAL_CALL_Internal_Draw2(style, ref position, content, controlID, on);
//        }
//
//        
//        private static extern void INTERNAL_CALL_Internal_Draw2(IntPtr style, ref Rect position, GUIContent content, int controlID, bool on);
//        private static void Internal_DrawPrefixLabel(IntPtr style, Rect position, GUIContent content, int controlID, bool on)
//        {
//            INTERNAL_CALL_Internal_DrawPrefixLabel(style, ref position, content, controlID, on);
//        }
//
//        
//        private static extern void INTERNAL_CALL_Internal_DrawPrefixLabel(IntPtr style, ref Rect position, GUIContent content, int controlID, bool on);
//        
//        private static extern float Internal_GetCursorFlashOffset();
//        private static void Internal_DrawCursor(IntPtr target, Rect position, GUIContent content, int pos, Color cursorColor)
//        {
//            INTERNAL_CALL_Internal_DrawCursor(target, ref position, content, pos, ref cursorColor);
//        }
//
//        
//        private static extern void INTERNAL_CALL_Internal_DrawCursor(IntPtr target, ref Rect position, GUIContent content, int pos, ref Color cursorColor);
//        
//        private static extern void Internal_DrawWithTextSelection(GUIContent content, ref Internal_DrawWithTextSelectionArguments arguments);
//        
//        internal static extern void SetDefaultFont(Font font);
//        internal static void Internal_GetCursorPixelPosition(IntPtr target, Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret)
//        {
//            INTERNAL_CALL_Internal_GetCursorPixelPosition(target, ref position, content, cursorStringIndex, out ret);
//        }
//
//        
//        private static extern void INTERNAL_CALL_Internal_GetCursorPixelPosition(IntPtr target, ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret);
//        internal static int Internal_GetCursorStringIndex(IntPtr target, Rect position, GUIContent content, Vector2 cursorPixelPosition)
//        {
//            return INTERNAL_CALL_Internal_GetCursorStringIndex(target, ref position, content, ref cursorPixelPosition);
//        }
//
//        
//        private static extern int INTERNAL_CALL_Internal_GetCursorStringIndex(IntPtr target, ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition);
//        
//        internal static extern int Internal_GetNumCharactersThatFitWithinWidth(IntPtr target, string text, float width);
//        
//        internal static extern void Internal_CalcSize(IntPtr target, GUIContent content, out Vector2 ret);
//        
//        private static extern float Internal_CalcHeight(IntPtr target, GUIContent content, float width);
//        
//        private static extern void Internal_CalcMinMaxWidth(IntPtr target, GUIContent content, out float minWidth, out float maxWidth);
//        public static implicit operator GUIStyle(string str)
//        {
//            if (GUISkin.current == null)
//            {
//                Debug.LogError("Unable to use a named GUIStyle without a current skin. Most likely you need to move your GUIStyle initialization code to OnGUI");
//                return GUISkin.error;
//            }
//            return GUISkin.current.GetStyle(str);
//        }
//    }
//}
//
