namespace UnityEngine.Experimental.Director
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using UnityEngine;

    public class Playable : IDisposable
    {
        internal IntPtr m_Ptr;
        internal int m_UniqueId;

        public Playable()
        {
            this.m_Ptr = IntPtr.Zero;
            this.m_UniqueId = this.GenerateUniqueId();
            this.InstantiateEnginePlayable();
        }

        internal Playable(bool callCPPConstructor)
        {
            this.m_Ptr = IntPtr.Zero;
            this.m_UniqueId = this.GenerateUniqueId();
            if (callCPPConstructor)
            {
                this.InstantiateEnginePlayable();
            }
        }

        internal bool CheckInputBounds(int inputIndex)
        {
            return this.CheckInputBounds(inputIndex, false);
        }

        internal bool CheckInputBounds(int inputIndex, bool acceptAny)
        {
            if ((inputIndex != -1) || !acceptAny)
            {
                if (inputIndex < 0)
                {
                    throw new IndexOutOfRangeException("Index must be greater than 0");
                }
                Playable[] inputs = this.GetInputs();
                if (inputs.Length <= inputIndex)
                {
                    object[] objArray1 = new object[] { "inputIndex ", inputIndex, " is greater than the number of available inputs (", inputs.Length, ")." };
                    throw new IndexOutOfRangeException(string.Concat(objArray1));
                }
            }
            return true;
        }

        internal static bool CheckPlayableValidity(Playable playable, string name)
        {
            if (playable == null)
            {
                throw new NullReferenceException("Playable " + name + "is null");
            }
            return true;
        }

        
        public extern void ClearInputs();
        internal static bool CompareIntPtr(Playable lhs, Playable rhs)
        {
            bool flag = (lhs == null) || !IsNativePlayableAlive(lhs);
            bool flag2 = (rhs == null) || !IsNativePlayableAlive(rhs);
            if (flag2 && flag)
            {
                return true;
            }
            if (flag2)
            {
                return !IsNativePlayableAlive(lhs);
            }
            if (flag)
            {
                return !IsNativePlayableAlive(rhs);
            }
            return (lhs.GetUniqueIDInternal() == rhs.GetUniqueIDInternal());
        }

        public static bool Connect(Playable source, Playable target)
        {
            return Connect(source, target, -1, -1);
        }

        public static bool Connect(Playable source, Playable target, int sourceOutputPort, int targetInputPort)
        {
            if (!CheckPlayableValidity(source, "source") && !CheckPlayableValidity(target, "target"))
            {
                return false;
            }
            if ((source != null) && !source.CheckInputBounds(sourceOutputPort, true))
            {
                return false;
            }
            if (!target.CheckInputBounds(targetInputPort, true))
            {
                return false;
            }
            return ConnectInternal(source, target, sourceOutputPort, targetInputPort);
        }

        
        internal static extern bool ConnectInternal(Playable source, Playable target, int sourceOutputPort, int targetInputPort);
        public static void Disconnect(Playable target, int inputPort)
        {
            if (CheckPlayableValidity(target, "target") && target.CheckInputBounds(inputPort))
            {
                DisconnectInternal(target, inputPort);
            }
        }

        
        internal static extern void DisconnectInternal(Playable target, int inputPort);
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            this.ReleaseEnginePlayable();
            this.m_Ptr = IntPtr.Zero;
        }

        public override bool Equals(object p)
        {
            return CompareIntPtr(this, p as Playable);
        }

        ~Playable()
        {
            this.Dispose(false);
        }

        
        private extern int GenerateUniqueId();
        public override int GetHashCode()
        {
            return this.m_UniqueId;
        }

        
        public extern Playable GetInput(int inputPort);
        
        public extern Playable[] GetInputs();
        public void GetInputs(List<Playable> inputList)
        {
            inputList.Clear();
            this.GetInputsInternal(inputList);
        }

        
        private extern void GetInputsInternal(object list);
        public float GetInputWeight(int inputIndex)
        {
            if (this.CheckInputBounds(inputIndex))
            {
                return this.GetInputWeightInternal(inputIndex);
            }
            return -1f;
        }

        
        private extern float GetInputWeightInternal(int inputIndex);
        
        public extern Playable GetOutput(int outputPort);
        
        public extern Playable[] GetOutputs();
        public void GetOutputs(List<Playable> outputList)
        {
            outputList.Clear();
            this.GetOutputsInternal(outputList);
        }

        
        private extern void GetOutputsInternal(object list);
        
        internal extern int GetUniqueIDInternal();
        
        private extern void InstantiateEnginePlayable();
        internal static bool IsNativePlayableAlive(Playable p)
        {
            return (p.m_Ptr != IntPtr.Zero);
        }

        public virtual void OnSetPlayState(PlayState newState)
        {
        }

        public virtual void OnSetTime(float localTime)
        {
        }

        public static bool operator ==(Playable x, Playable y)
        {
            return CompareIntPtr(x, y);
        }

        public static implicit operator bool(Playable exists)
        {
            return !CompareIntPtr(exists, null);
        }

        public static bool operator !=(Playable x, Playable y)
        {
            return !CompareIntPtr(x, y);
        }

        public virtual void PrepareFrame(FrameData info)
        {
        }

        public virtual void ProcessFrame(FrameData info, object playerData)
        {
        }

        
        private extern void ReleaseEnginePlayable();
        public bool SetInputWeight(int inputIndex, float weight)
        {
            return (this.CheckInputBounds(inputIndex) && this.SetInputWeightInternal(inputIndex, weight));
        }

        
        private extern bool SetInputWeightInternal(int inputIndex, float weight);

        public int inputCount {  get; }

        public int outputCount {  get; }

        public PlayState state {  get;  set; }

        public double time {  get;  set; }
    }
}

