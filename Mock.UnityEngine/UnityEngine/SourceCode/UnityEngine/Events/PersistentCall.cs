﻿namespace UnityEngine.Events
{
    using System;
    using System.Reflection;
    using UnityEngine;
    using UnityEngine.Serialization;

    [Serializable]
    internal class PersistentCall
    {
        [SerializeField, FormerlySerializedAs("arguments")]
        private ArgumentCache m_Arguments = new ArgumentCache();
        [SerializeField, FormerlySerializedAs("m_Enabled"), FormerlySerializedAs("enabled")]
        private UnityEventCallState m_CallState = UnityEventCallState.RuntimeOnly;
        [SerializeField, FormerlySerializedAs("methodName")]
        private string m_MethodName;
        [FormerlySerializedAs("mode"), SerializeField]
        private PersistentListenerMode m_Mode;
        [FormerlySerializedAs("instance"), SerializeField]
        private object m_Target;

        private static BaseInvokableCall GetObjectCall(object target, MethodInfo method, ArgumentCache arguments)
        {
            Type type = typeof(object);
            if (!string.IsNullOrEmpty(arguments.unityObjectArgumentAssemblyTypeName))
            {
                Type type1 = Type.GetType(arguments.unityObjectArgumentAssemblyTypeName, false);
                if (type1 != null)
                {
                    type = type1;
                }
                else
                {
                    type = typeof(object);
                }
            }
            Type type2 = typeof(CachedInvokableCall<>);
            Type[] typeArguments = new Type[] { type };
            Type[] types = new Type[] { typeof(object), typeof(MethodInfo), type };
            ConstructorInfo constructor = type2.MakeGenericType(typeArguments).GetConstructor(types);
            object unityObjectArgument = arguments.unityObjectArgument;
            if ((unityObjectArgument != null) && !type.IsAssignableFrom(unityObjectArgument.GetType()))
            {
                unityObjectArgument = null;
            }
            object[] parameters = new object[] { target, method, unityObjectArgument };
            return (constructor.Invoke(parameters) as BaseInvokableCall);
        }

        public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent)
        {
            if ((this.m_CallState != UnityEventCallState.RuntimeOnly) || Application.isPlaying)
            {
                if ((this.m_CallState == UnityEventCallState.Off) || (theEvent == null))
                {
                    return null;
                }
                MethodInfo theFunction = theEvent.FindMethod(this);
                if (theFunction != null)
                {
                    switch (this.m_Mode)
                    {
                        case PersistentListenerMode.EventDefined:
                            return theEvent.GetDelegate(this.target, theFunction);

                        case PersistentListenerMode.Void:
                            return new InvokableCall(this.target, theFunction);

                        case PersistentListenerMode.Object:
                            return GetObjectCall(this.target, theFunction, this.m_Arguments);

                        case PersistentListenerMode.Int:
                            return new CachedInvokableCall<int>(this.target, theFunction, this.m_Arguments.intArgument);

                        case PersistentListenerMode.Float:
                            return new CachedInvokableCall<float>(this.target, theFunction, this.m_Arguments.floatArgument);

                        case PersistentListenerMode.String:
                            return new CachedInvokableCall<string>(this.target, theFunction, this.m_Arguments.stringArgument);

                        case PersistentListenerMode.Bool:
                            return new CachedInvokableCall<bool>(this.target, theFunction, this.m_Arguments.boolArgument);
                    }
                }
            }
            return null;
        }

        public bool IsValid()
        {
            return ((this.target != null) && !string.IsNullOrEmpty(this.methodName));
        }

        public void RegisterPersistentListener(object ttarget, string mmethodName)
        {
            this.m_Target = ttarget;
            this.m_MethodName = mmethodName;
        }

        public void UnregisterPersistentListener()
        {
            this.m_MethodName = string.Empty;
            this.m_Target = null;
        }

        public ArgumentCache arguments
        {
            get
            {
                return this.m_Arguments;
            }
        }

        public UnityEventCallState callState
        {
            get
            {
                return this.m_CallState;
            }
            set
            {
                this.m_CallState = value;
            }
        }

        public string methodName
        {
            get
            {
                return this.m_MethodName;
            }
        }

        public PersistentListenerMode mode
        {
            get
            {
                return this.m_Mode;
            }
            set
            {
                this.m_Mode = value;
            }
        }

        public object target
        {
            get
            {
                return this.m_Target;
            }
        }
    }
}

