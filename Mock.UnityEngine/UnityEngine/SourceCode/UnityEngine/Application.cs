namespace UnityEngine
{
    using System;
    using System.Collections;
    using System.Globalization;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Text;
    using UnityEngine.Internal;

    public sealed class Application
    {
        internal static AdvertisingIdentifierCallback OnAdvertisingIdentifierCallback;
        private static LogCallback s_LogCallbackHandler;
        private static LogCallback s_LogCallbackHandlerThreaded;
        private static volatile LogCallback s_RegisterLogCallbackDeprecated;

        public static  event LogCallback logMessageReceived
        {
            add
            {
                s_LogCallbackHandler = (LogCallback) Delegate.Combine(s_LogCallbackHandler, value);
                SetLogCallbackDefined(true, s_LogCallbackHandlerThreaded != null);
            }
            remove
            {
                s_LogCallbackHandler = (LogCallback) Delegate.Remove(s_LogCallbackHandler, value);
            }
        }

        public static  event LogCallback logMessageReceivedThreaded
        {
            add
            {
                s_LogCallbackHandlerThreaded = (LogCallback) Delegate.Combine(s_LogCallbackHandlerThreaded, value);
                SetLogCallbackDefined(true, true);
            }
            remove
            {
                s_LogCallbackHandlerThreaded = (LogCallback) Delegate.Remove(s_LogCallbackHandlerThreaded, value);
            }
        }

        private static string BuildInvocationForArguments(string functionName, params object[] args)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(functionName);
            builder.Append('(');
            int length = args.Length;
            for (int i = 0; i < length; i++)
            {
                if (i != 0)
                {
                    builder.Append(", ");
                }
                builder.Append(ObjectToJSString(args[i]));
            }
            builder.Append(')');
            builder.Append(';');
            return builder.ToString();
        }

        private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
        {
            if (invokedOnMainThread)
            {
                LogCallback callback = s_LogCallbackHandler;
                if (callback != null)
                {
                    callback(logString, stackTrace, type);
                }
            }
            LogCallback callback2 = s_LogCallbackHandlerThreaded;
            if (callback2 != null)
            {
                callback2(logString, stackTrace, type);
            }
        }

        
        public static extern void CancelQuit();
        
        public static extern bool CanStreamedLevelBeLoaded(int levelIndex);
        public static bool CanStreamedLevelBeLoaded(string levelName)
        {
            return CanStreamedLevelBeLoadedByName(levelName);
        }

        
        private static extern bool CanStreamedLevelBeLoadedByName(string levelName);
        [ExcludeFromDocs]
        public static void CaptureScreenshot(string filename)
        {
            int superSize = 0;
            CaptureScreenshot(filename, superSize);
        }

        
        public static extern void CaptureScreenshot(string filename, [DefaultValue("0")] int superSize);
        
        public static extern void CommitSuicide(int mode);
        
        public static extern void DontDestroyOnLoad(Object mono);
        public static void ExternalCall(string functionName, params object[] args)
        {
            Internal_ExternalCall(BuildInvocationForArguments(functionName, args));
        }

        public static void ExternalEval(string script)
        {
            if ((script.Length > 0) && (script[script.Length - 1] != ';'))
            {
                script = script + ';';
            }
            Internal_ExternalCall(script);
        }

        
        internal static extern int GetBuildUnityVersion();
        
        internal static extern int GetNumericUnityVersion(string version);
        
        public static extern float GetStreamProgressForLevel(int levelIndex);
        public static float GetStreamProgressForLevel(string levelName)
        {
            return GetStreamProgressForLevelByName(levelName);
        }

        
        private static extern float GetStreamProgressForLevelByName(string levelName);
        internal static UserAuthorization GetUserAuthorizationRequestMode()
        {
            return (UserAuthorization) GetUserAuthorizationRequestMode_Internal();
        }

        
        private static extern int GetUserAuthorizationRequestMode_Internal();
        
        internal static extern string GetValueForARGV(string name);
        
        internal static extern bool HasAdvancedLicense();
        
        internal static extern bool HasARGV(string name);
        
        public static extern bool HasProLicense();
        
        public static extern bool HasUserAuthorization(UserAuthorization mode);
        
        private static extern void Internal_ExternalCall(string script);
        internal static void InvokeOnAdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled)
        {
            if (OnAdvertisingIdentifierCallback != null)
            {
                OnAdvertisingIdentifierCallback(advertisingId, trackingEnabled);
            }
        }

        public static void LoadLevel(int index)
        {
            LoadLevelAsync(null, index, false, true);
        }

        public static void LoadLevel(string name)
        {
            LoadLevelAsync(name, -1, false, true);
        }

        public static void LoadLevelAdditive(int index)
        {
            LoadLevelAsync(null, index, true, true);
        }

        public static void LoadLevelAdditive(string name)
        {
            LoadLevelAsync(name, -1, true, true);
        }

        public static AsyncOperation LoadLevelAdditiveAsync(int index)
        {
            return LoadLevelAsync(null, index, true, false);
        }

        public static AsyncOperation LoadLevelAdditiveAsync(string levelName)
        {
            return LoadLevelAsync(levelName, -1, true, false);
        }

        public static AsyncOperation LoadLevelAsync(int index)
        {
            return LoadLevelAsync(null, index, false, false);
        }

        public static AsyncOperation LoadLevelAsync(string levelName)
        {
            return LoadLevelAsync(levelName, -1, false, false);
        }

        
        private static extern AsyncOperation LoadLevelAsync(string monoLevelName, int index, bool additive, bool mustCompleteNextFrame);
        private static string ObjectToJSString(object o)
        {
            if (o == null)
            {
                return "null";
            }
            if (o is string)
            {
                string str = o.ToString().Replace(@"\", @"\\").Replace("\"", "\\\"").Replace("\n", @"\n").Replace("\r", @"\r").Replace("\0", string.Empty).Replace("\u2028", string.Empty).Replace("\u2029", string.Empty);
                return ('"' + str + '"');
            }
            if (((o is int) || (o is short)) || (((o is uint) || (o is ushort)) || (o is byte)))
            {
                return o.ToString();
            }
            if (o is float)
            {
                NumberFormatInfo numberFormat = CultureInfo.InvariantCulture.NumberFormat;
                float num3 = (float) o;
                return num3.ToString(numberFormat);
            }
            if (o is double)
            {
                NumberFormatInfo provider = CultureInfo.InvariantCulture.NumberFormat;
                double num4 = (double) o;
                return num4.ToString(provider);
            }
            if (o is char)
            {
                if (((char) o) == '"')
                {
                    return "\"\\\"\"";
                }
                return ('"' + o.ToString() + '"');
            }
            if (!(o is IList))
            {
                return ObjectToJSString(o.ToString());
            }
            IList list = (IList) o;
            StringBuilder builder = new StringBuilder();
            builder.Append("new Array(");
            int count = list.Count;
            for (int i = 0; i < count; i++)
            {
                if (i != 0)
                {
                    builder.Append(", ");
                }
                builder.Append(ObjectToJSString(list[i]));
            }
            builder.Append(")");
            return builder.ToString();
        }

        
        public static extern void OpenURL(string url);
        
        public static extern void Quit();
        [Obsolete("Application.RegisterLogCallback is deprecated. Use Application.logMessageReceived instead.")]
        public static void RegisterLogCallback(LogCallback handler)
        {
            RegisterLogCallback(handler, false);
        }

        private static void RegisterLogCallback(LogCallback handler, bool threaded)
        {
            if (s_RegisterLogCallbackDeprecated != null)
            {
                logMessageReceived -= s_RegisterLogCallbackDeprecated;
                logMessageReceivedThreaded -= s_RegisterLogCallbackDeprecated;
            }
            s_RegisterLogCallbackDeprecated = handler;
            if (handler != null)
            {
                if (threaded)
                {
                    logMessageReceivedThreaded += handler;
                }
                else
                {
                    logMessageReceived += handler;
                }
            }
        }

        [Obsolete("Application.RegisterLogCallbackThreaded is deprecated. Use Application.logMessageReceivedThreaded instead.")]
        public static void RegisterLogCallbackThreaded(LogCallback handler)
        {
            RegisterLogCallback(handler, true);
        }

        [ExcludeFromDocs]
        internal static void ReplyToUserAuthorizationRequest(bool reply)
        {
            bool remember = false;
            ReplyToUserAuthorizationRequest(reply, remember);
        }

        
        internal static extern void ReplyToUserAuthorizationRequest(bool reply, [DefaultValue("false")] bool remember);
        
        public static extern AsyncOperation RequestUserAuthorization(UserAuthorization mode);
        
        private static extern void SetLogCallbackDefined(bool defined, bool threaded);
        public static bool UnloadLevel(int index)
        {
            return UnloadLevel(string.Empty, index);
        }

        public static bool UnloadLevel(string scenePath)
        {
            return UnloadLevel(scenePath, -1);
        }

        
        private static extern bool UnloadLevel(string monoScenePath, int index);

        [Obsolete("absoluteUrl is deprecated. Please use absoluteURL instead (UnityUpgradable) -> absoluteURL", true)]
        public static string absoluteUrl
        {
            get
            {
                return absoluteURL;
            }
        }

        public static string absoluteURL {  get; }

        public static ThreadPriority backgroundLoadingPriority {  get;  set; }

        public static string bundleIdentifier {  get; }

        public static string cloudProjectId {  get; }

        public static string companyName {  get; }

        public static string dataPath {  get; }

        public static bool genuine {  get; }

        public static bool genuineCheckAvailable {  get; }

        public static ApplicationInstallMode installMode {  get; }

        public static NetworkReachability internetReachability {  get; }

        internal static bool isBatchmode {  get; }

        public static bool isConsolePlatform
        {
            get
            {
                RuntimePlatform platform = Application.platform;
                return ((((platform == RuntimePlatform.PS3) || (platform == RuntimePlatform.PS4)) || (platform == RuntimePlatform.XBOX360)) || (platform == RuntimePlatform.XboxOne));
            }
        }

        public static bool isEditor {  get; }

        internal static bool isHumanControllingUs {  get; }

        [Obsolete("This property is deprecated, please use LoadLevelAsync to detect if a specific scene is currently loading.")]
        public static bool isLoadingLevel {  get; }

        public static bool isMobilePlatform
        {
            get
            {
                switch (platform)
                {
                    case RuntimePlatform.IPhonePlayer:
                    case RuntimePlatform.Android:
                    case RuntimePlatform.MetroPlayerX86:
                    case RuntimePlatform.MetroPlayerX64:
                    case RuntimePlatform.MetroPlayerARM:
                    case RuntimePlatform.WP8Player:
                    case RuntimePlatform.BB10Player:
                    case RuntimePlatform.TizenPlayer:
                        return true;
                }
                return false;
            }
        }

        [Obsolete("use Application.isEditor instead")]
        public static bool isPlayer
        {
            get
            {
                return !isEditor;
            }
        }

        public static bool isPlaying {  get; }

        internal static bool isRunningUnitTests {  get; }

        public static bool isShowingSplashScreen {  get; }

        public static bool isWebPlayer {  get; }

        public static int levelCount {  get; }

        public static int loadedLevel {  get; }

        public static string loadedLevelName {  get; }

        [SecurityCritical]
        public static string persistentDataPath {  get; }

        public static RuntimePlatform platform {  get; }

        public static string productName {  get; }

        public static bool runInBackground {  get;  set; }

        public static ApplicationSandboxType sandboxType {  get; }

        public static string srcValue {  get; }

        public static StackTraceLogType stackTraceLogType {  get;  set; }

        public static int streamedBytes {  get; }

        public static string streamingAssetsPath {  get; }

        internal static bool submitAnalytics {  get; }

        public static SystemLanguage systemLanguage {  get; }

        public static int targetFrameRate {  get;  set; }

        public static string temporaryCachePath {  get; }

        public static string unityVersion {  get; }

        public static string version {  get; }

        public static bool webSecurityEnabled {  get; }

        public static string webSecurityHostUrl {  get; }

        public delegate void LogCallback(string condition, string stackTrace, LogType type);
    }
}

