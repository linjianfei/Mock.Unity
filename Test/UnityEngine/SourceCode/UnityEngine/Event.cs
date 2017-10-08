namespace UnityEngine
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public sealed class Event
    {
        [NonSerialized]
        internal IntPtr m_Ptr;
        private static Event s_Current;
        private static Event s_MasterEvent;
        public Event()
        {
            this.Init();
        }

        public Event(Event other)
        {
            if (other == null)
            {
                throw new ArgumentException("Event to copy from is null.");
            }
            this.InitCopy(other);
        }

        private Event(IntPtr ptr)
        {
            this.InitPtr(ptr);
        }

        ~Event()
        {
            this.Cleanup();
        }

        public Vector2 mousePosition
        {
            get
            {
                Vector2 vector;
                this.Internal_GetMousePosition(out vector);
                return vector;
            }
            set
            {
                this.Internal_SetMousePosition(value);
            }
        }
        public Vector2 delta
        {
            get
            {
                Vector2 vector;
                this.Internal_GetMouseDelta(out vector);
                return vector;
            }
            set
            {
                this.Internal_SetMouseDelta(value);
            }
        }
        [Obsolete("Use HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);", true)]
        public Ray mouseRay
        {
            get
            {
                return new Ray(Vector3.up, Vector3.up);
            }
            set
            {
            }
        }
        public bool shift
        {
            get
            {
                return ((this.modifiers & EventModifiers.Shift) != EventModifiers.None);
            }
            set
            {
                if (!value)
                {
                    this.modifiers &= ~EventModifiers.Shift;
                }
                else
                {
                    this.modifiers |= EventModifiers.Shift;
                }
            }
        }
        public bool control
        {
            get
            {
                return ((this.modifiers & EventModifiers.Control) != EventModifiers.None);
            }
            set
            {
                if (!value)
                {
                    this.modifiers &= ~EventModifiers.Control;
                }
                else
                {
                    this.modifiers |= EventModifiers.Control;
                }
            }
        }
        public bool alt
        {
            get
            {
                return ((this.modifiers & EventModifiers.Alt) != EventModifiers.None);
            }
            set
            {
                if (!value)
                {
                    this.modifiers &= ~EventModifiers.Alt;
                }
                else
                {
                    this.modifiers |= EventModifiers.Alt;
                }
            }
        }
        public bool command
        {
            get
            {
                return ((this.modifiers & EventModifiers.Command) != EventModifiers.None);
            }
            set
            {
                if (!value)
                {
                    this.modifiers &= ~EventModifiers.Command;
                }
                else
                {
                    this.modifiers |= EventModifiers.Command;
                }
            }
        }
        public bool capsLock
        {
            get
            {
                return ((this.modifiers & EventModifiers.CapsLock) != EventModifiers.None);
            }
            set
            {
                if (!value)
                {
                    this.modifiers &= ~EventModifiers.CapsLock;
                }
                else
                {
                    this.modifiers |= EventModifiers.CapsLock;
                }
            }
        }
        public bool numeric
        {
            get
            {
                return ((this.modifiers & EventModifiers.Numeric) != EventModifiers.None);
            }
            set
            {
                if (!value)
                {
                    this.modifiers &= ~EventModifiers.Shift;
                }
                else
                {
                    this.modifiers |= EventModifiers.Shift;
                }
            }
        }
        public bool functionKey
        {
            get
            {
                return ((this.modifiers & EventModifiers.FunctionKey) != EventModifiers.None);
            }
        }
        public static Event current { get; set; }
        private static void Internal_MakeMasterEventCurrent()
        {
            if (s_MasterEvent == null)
            {
                s_MasterEvent = new Event();
            }
            s_Current = s_MasterEvent;
            Internal_SetNativeEvent(s_MasterEvent.m_Ptr);
        }

        public bool isKey
        {
            get
            {
                EventType type = this.type;
                return ((type == EventType.KeyDown) || (type == EventType.KeyUp));
            }
        }
        public bool isMouse
        {
            get
            {
                EventType type = this.type;
                return ((((type == EventType.MouseMove) || (type == EventType.MouseDown)) || (type == EventType.MouseUp)) || (type == EventType.MouseDrag));
            }
        }
        public static Event KeyboardEvent(string key)
        {
            return null;
        }



        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (object.ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != base.GetType())
            {
                return false;
            }
            Event event2 = (Event) obj;
            if ((this.type != event2.type) || ((this.modifiers & ~EventModifiers.CapsLock) != (event2.modifiers & ~EventModifiers.CapsLock)))
            {
                return false;
            }
            if (this.isKey)
            {
                return (this.keyCode == event2.keyCode);
            }
            return (this.isMouse && (this.mousePosition == event2.mousePosition));
        }

        public override string ToString()
        {
            if (this.isKey)
            {
                if (this.character == '\0')
                {
                    object[] objArray1 = new object[] { this.type, this.modifiers, this.keyCode };
                    return UnityString.Format(@"Event:{0}   Character:\0   Modifiers:{1}   KeyCode:{2}", objArray1);
                }
                object[] objArray2 = new object[] { "Event:", this.type, "   Character:", (int) this.character, "   Modifiers:", this.modifiers, "   KeyCode:", this.keyCode };
                return string.Concat(objArray2);
            }
            if (this.isMouse)
            {
                object[] objArray3 = new object[] { this.type, this.mousePosition, this.modifiers };
                return UnityString.Format("Event: {0}   Position: {1} Modifiers: {2}", objArray3);
            }
            if ((this.type != EventType.ExecuteCommand) && (this.type != EventType.ValidateCommand))
            {
                return (string.Empty + this.type);
            }
            object[] args = new object[] { this.type, this.commandName };
            return UnityString.Format("Event: {0}  \"{1}\"", args);
        }

        
        private extern void Init();
        
        private extern void Cleanup();
        
        private extern void InitCopy(Event other);
        
        private extern void InitPtr(IntPtr ptr);
        public EventType rawType {  get; }
        public EventType type {  get;  set; }
        
        public extern EventType GetTypeForControl(int controlID);
        private void Internal_SetMousePosition(Vector2 value)
        {
            INTERNAL_CALL_Internal_SetMousePosition(this, ref value);
        }

        
        private static extern void INTERNAL_CALL_Internal_SetMousePosition(Event self, ref Vector2 value);
        
        private extern void Internal_GetMousePosition(out Vector2 value);
        private void Internal_SetMouseDelta(Vector2 value)
        {
            INTERNAL_CALL_Internal_SetMouseDelta(this, ref value);
        }

        
        private static extern void INTERNAL_CALL_Internal_SetMouseDelta(Event self, ref Vector2 value);
        
        private extern void Internal_GetMouseDelta(out Vector2 value);
        public int button {  get;  set; }
        public EventModifiers modifiers {  get;  set; }
        public float pressure {  get;  set; }
        public int clickCount {  get;  set; }
        public char character {  get;  set; }
        public string commandName {  get;  set; }
        public KeyCode keyCode {  get;  set; }
        
        private static extern void Internal_SetNativeEvent(IntPtr ptr);
        
        public extern void Use();
        
        public static extern bool PopEvent(Event outEvent);
        
        public static extern int GetEventCount();
    }
}

