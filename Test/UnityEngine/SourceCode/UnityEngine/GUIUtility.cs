﻿//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//
//    public class GUIUtility
//    {
//        internal static Vector2 s_EditorScreenPointOffset = Vector2.zero;
//        internal static bool s_HasKeyboardFocus = false;
//        internal static int s_OriginalID;
//        internal static int s_SkinMode;
//
//        internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout)
//        {
//            s_SkinMode = skinMode;
//            s_OriginalID = instanceID;
//            GUI.skin = null;
//            if (useGUILayout != 0)
//            {
//                GUILayoutUtility.SelectIDList(instanceID, false);
//                GUILayoutUtility.Begin(instanceID);
//            }
//            GUI.changed = false;
//        }
//
//        internal static void CheckOnGUI()
//        {
//            if (Internal_GetGUIDepth() <= 0)
//            {
//                throw new ArgumentException("You can only call GUI functions from inside OnGUI.");
//            }
//        }
//
//        internal static void EndGUI(int layoutType)
//        {
//            try
//            {
//                if (Event.current.type == EventType.Layout)
//                {
//                    switch (layoutType)
//                    {
//                        case 1:
//                            goto Label_002E;
//
//                        case 2:
//                            goto Label_0038;
//                    }
//                }
//                goto Label_0042;
//            Label_002E:
//                GUILayoutUtility.Layout();
//                goto Label_0042;
//            Label_0038:
//                GUILayoutUtility.LayoutFromEditorWindow();
//            Label_0042:
//                GUILayoutUtility.SelectIDList(s_OriginalID, false);
//                GUIContent.ClearStaticCache();
//            }
//            finally
//            {
//                Internal_ExitGUI();
//            }
//        }
//
//        internal static bool EndGUIFromException(Exception exception)
//        {
//            if (exception == null)
//            {
//                return false;
//            }
//            if (!(exception is ExitGUIException) && !(exception.InnerException is ExitGUIException))
//            {
//                return false;
//            }
//            Internal_ExitGUI();
//            return true;
//        }
//
//        public static void ExitGUI()
//        {
//            throw new ExitGUIException();
//        }
//
//        internal static GUISkin GetBuiltinSkin(int skin)
//        {
//            return (Internal_GetBuiltinSkin(skin) as GUISkin);
//        }
//
//        public static int GetControlID(FocusType focus)
//        {
//            return GetControlID(0, focus);
//        }
//
//        
//        public static extern int GetControlID(int hint, FocusType focus);
//        public static int GetControlID(FocusType focus, Rect position)
//        {
//            return Internal_GetNextControlID2(0, focus, position);
//        }
//
//        public static int GetControlID(GUIContent contents, FocusType focus)
//        {
//            return GetControlID(contents.hash, focus);
//        }
//
//        public static int GetControlID(int hint, FocusType focus, Rect position)
//        {
//            return Internal_GetNextControlID2(hint, focus, position);
//        }
//
//        public static int GetControlID(GUIContent contents, FocusType focus, Rect position)
//        {
//            return Internal_GetNextControlID2(contents.hash, focus, position);
//        }
//
//        internal static GUISkin GetDefaultSkin()
//        {
//            return Internal_GetDefaultSkin(s_SkinMode);
//        }
//
//        
//        internal static extern int GetPermanentControlID();
//        public static object GetStateObject(Type t, int controlID)
//        {
//            return GUIStateObjects.GetStateObject(t, controlID);
//        }
//
//        public static Vector2 GUIToScreenPoint(Vector2 guiPoint)
//        {
//            return (GUIClip.Unclip(guiPoint) + s_EditorScreenPointOffset);
//        }
//
//        internal static Rect GUIToScreenRect(Rect guiRect)
//        {
//            Vector2 vector = GUIToScreenPoint(new Vector2(guiRect.x, guiRect.y));
//            guiRect.x = vector.x;
//            guiRect.y = vector.y;
//            return guiRect;
//        }
//
//        
//        private static extern int INTERNAL_CALL_Internal_GetNextControlID2(int hint, FocusType focusType, ref Rect rect);
//        
//        private static extern void Internal_ExitGUI();
//        
//        private static extern Object Internal_GetBuiltinSkin(int skin);
//        
//        private static extern GUISkin Internal_GetDefaultSkin(int skinMode);
//        
//        internal static extern int Internal_GetGUIDepth();
//        
//        private static extern int Internal_GetHotControl();
//        private static int Internal_GetNextControlID2(int hint, FocusType focusType, Rect rect)
//        {
//            return INTERNAL_CALL_Internal_GetNextControlID2(hint, focusType, ref rect);
//        }
//
//        
//        private static extern float Internal_GetPixelsPerPoint();
//        
//        private static extern void Internal_SetHotControl(int value);
//        public static object QueryStateObject(Type t, int controlID)
//        {
//            return GUIStateObjects.QueryStateObject(t, controlID);
//        }
//
//        public static void RotateAroundPivot(float angle, Vector2 pivotPoint)
//        {
//     
//        }
//
//        public static void ScaleAroundPivot(Vector2 scale, Vector2 pivotPoint)
//        {
//
//        }
//
//        public static Vector2 ScreenToGUIPoint(Vector2 screenPoint)
//        {
//            return (GUIClip.Clip(screenPoint) - s_EditorScreenPointOffset);
//        }
//
//        public static Rect ScreenToGUIRect(Rect screenRect)
//        {
//            Vector2 vector = ScreenToGUIPoint(new Vector2(screenRect.x, screenRect.y));
//            screenRect.x = vector.x;
//            screenRect.y = vector.y;
//            return screenRect;
//        }
//
//        
//        internal static extern void SetDidGUIWindowsEatLastEvent(bool value);
//        internal static void SetSkin(int skinMode)
//        {
//            s_SkinMode = skinMode;
//            GUI.DoSetSkin(null);
//        }
//
//        
//        internal static extern void UpdateUndoName();
//
//        public static bool hasModalWindow {  get; }
//
//        public static int hotControl
//        {
//            get
//            {
//                return Internal_GetHotControl();
//            }
//            set
//            {
//                Internal_SetHotControl(value);
//            }
//        }
//
//        public static int keyboardControl {  get;  set; }
//
//        internal static bool mouseUsed {  get;  set; }
//
//        internal static float pixelsPerPoint
//        {
//            get
//            {
//                return Internal_GetPixelsPerPoint();
//            }
//        }
//
//        public static string systemCopyBuffer {  get;  set; }
//
//        internal static bool textFieldInput {  get;  set; }
//    }
//}
//
