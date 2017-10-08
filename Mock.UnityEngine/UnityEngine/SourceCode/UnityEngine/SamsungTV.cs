namespace UnityEngine
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed class SamsungTV
    {
        
        public static extern void SetSystemLanguage(SystemLanguage language);

        public static bool airMouseConnected {  get; }

        public static GamePadMode gamePadMode {  get;  set; }

        public static GestureMode gestureMode {  get;  set; }

        public static bool gestureWorking {  get; }

        public static TouchPadMode touchPadMode {  get;  set; }

        public enum GamePadMode
        {
            Default,
            Mouse
        }

        public enum GestureMode
        {
            Off,
            Mouse,
            Joystick
        }

        public sealed class OpenAPI
        {
            public static string dUid {  get; }

            public static OpenAPIServerType serverType {  get; }

            public static string timeOnTV {  get; }

            public static string uid {  get; }

            public enum OpenAPIServerType
            {
                Operating,
                Development,
                Developing,
                Invalid
            }
        }

        public enum TouchPadMode
        {
            Dpad,
            Joystick,
            Mouse
        }
    }
}

