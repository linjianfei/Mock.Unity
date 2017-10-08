namespace UnityEngine
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using UnityEngine.Internal;

    public sealed class Debug
    {
        [Conditional("UNITY_ASSERTIONS")]
        public static void Assert(bool condition)
        {
            if (!condition)
            {
                LogAssertion(null);
            }
        }

        [Conditional("UNITY_ASSERTIONS")]
        public static void Assert(bool condition, string message)
        {
            if (!condition)
            {
                LogAssertion(message);
            }
        }

        [Conditional("UNITY_ASSERTIONS")]
        public static void Assert(bool condition, string format, params object[] args)
        {
            if (!condition)
            {
                LogAssertion(string.Format(format, args));
            }
        }


        private static  void Internal_Log(int level, string msg, [Writable] Object obj)
        {
            Console.WriteLine(msg);
        }

        private static void Internal_LogException(Exception exception, [Writable] Object obj)
        {
            Console.WriteLine(exception);
        }

        public static void Log(object message)
        {
            Internal_Log(0, (message == null) ? "Null" : message.ToString(), null);
        }

        public static void Log(object message, Object context)
        {
            Internal_Log(0, (message == null) ? "Null" : message.ToString(), context);
        }

        internal static void LogAssertion(string message)
        {
            Internal_Log(3, message, null);
        }

        public static void LogError(object message)
        {
            Internal_Log(2, (message == null) ? "Null" : message.ToString(), null);
        }

        public static void LogError(object message, Object context)
        {
            Internal_Log(2, message.ToString(), context);
        }

        public static void LogErrorFormat(string format, params object[] args)
        {
            LogError(string.Format(format, args));
        }

        public static void LogErrorFormat(Object context, string format, params object[] args)
        {
            LogError(string.Format(format, args), context);
        }

        public static void LogException(Exception exception)
        {
            Internal_LogException(exception, null);
        }

        public static void LogException(Exception exception, Object context)
        {
            Internal_LogException(exception, context);
        }

        public static void LogFormat(string format, params object[] args)
        {
            Log(string.Format(format, args));
        }

        public static void LogFormat(Object context, string format, params object[] args)
        {
            Log(string.Format(format, args), context);
        }

        
        public static void LogWarning(object message)
        {
            Internal_Log(1, message.ToString(), null);
        }

        public static void LogWarning(object message, Object context)
        {
            Internal_Log(1, message.ToString(), context);
        }

        public static void LogWarningFormat(string format, params object[] args)
        {
            LogWarning(string.Format(format, args));
        }

        public static void LogWarningFormat(Object context, string format, params object[] args)
        {
            LogWarning(string.Format(format, args), context);
        }

        
    }
}

