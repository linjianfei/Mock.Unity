//namespace UnityEngine
//{
//    using System;
//    using System.Runtime.CompilerServices;
//
//    public sealed class AndroidJNI
//    {
//        private AndroidJNI()
//        {
//        }
//
//        
//        public static extern IntPtr AllocObject(IntPtr clazz);
//        
//        public static extern int AttachCurrentThread();
//        
//        public static extern bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args);
//        
//        public static extern byte CallByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args);
//        
//        public static extern char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args);
//        
//        public static extern double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args);
//        
//        public static extern float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args);
//        
//        public static extern int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args);
//        
//        public static extern long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args);
//        
//        public static extern IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args);
//        
//        public static extern short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args);
//        
//        public static extern bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);
//        
//        public static extern byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);
//        
//        public static extern char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);
//        
//        public static extern double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);
//        
//        public static extern float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);
//        
//        public static extern int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);
//        
//        public static extern long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);
//        
//        public static extern IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);
//        
//        public static extern short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);
//        
//        public static extern string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);
//        
//        public static extern void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);
//        
//        public static extern string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args);
//        
//        public static extern void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args);
//        
//        public static extern void DeleteGlobalRef(IntPtr obj);
//        
//        public static extern void DeleteLocalRef(IntPtr obj);
//        
//        public static extern int DetachCurrentThread();
//        
//        public static extern int EnsureLocalCapacity(int capacity);
//        
//        public static extern void ExceptionClear();
//        
//        public static extern void ExceptionDescribe();
//        
//        public static extern IntPtr ExceptionOccurred();
//        
//        public static extern void FatalError(string message);
//        
//        public static extern IntPtr FindClass(string name);
//        
//        public static extern bool[] FromBooleanArray(IntPtr array);
//        
//        public static extern byte[] FromByteArray(IntPtr array);
//        
//        public static extern char[] FromCharArray(IntPtr array);
//        
//        public static extern double[] FromDoubleArray(IntPtr array);
//        
//        public static extern float[] FromFloatArray(IntPtr array);
//        
//        public static extern int[] FromIntArray(IntPtr array);
//        
//        public static extern long[] FromLongArray(IntPtr array);
//        
//        public static extern IntPtr[] FromObjectArray(IntPtr array);
//        
//        public static extern IntPtr FromReflectedField(IntPtr refField);
//        
//        public static extern IntPtr FromReflectedMethod(IntPtr refMethod);
//        
//        public static extern short[] FromShortArray(IntPtr array);
//        
//        public static extern int GetArrayLength(IntPtr array);
//        
//        public static extern bool GetBooleanArrayElement(IntPtr array, int index);
//        
//        public static extern bool GetBooleanField(IntPtr obj, IntPtr fieldID);
//        
//        public static extern byte GetByteArrayElement(IntPtr array, int index);
//        
//        public static extern byte GetByteField(IntPtr obj, IntPtr fieldID);
//        
//        public static extern char GetCharArrayElement(IntPtr array, int index);
//        
//        public static extern char GetCharField(IntPtr obj, IntPtr fieldID);
//        
//        public static extern double GetDoubleArrayElement(IntPtr array, int index);
//        
//        public static extern double GetDoubleField(IntPtr obj, IntPtr fieldID);
//        
//        public static extern IntPtr GetFieldID(IntPtr clazz, string name, string sig);
//        
//        public static extern float GetFloatArrayElement(IntPtr array, int index);
//        
//        public static extern float GetFloatField(IntPtr obj, IntPtr fieldID);
//        
//        public static extern int GetIntArrayElement(IntPtr array, int index);
//        
//        public static extern int GetIntField(IntPtr obj, IntPtr fieldID);
//        
//        public static extern long GetLongArrayElement(IntPtr array, int index);
//        
//        public static extern long GetLongField(IntPtr obj, IntPtr fieldID);
//        
//        public static extern IntPtr GetMethodID(IntPtr clazz, string name, string sig);
//        
//        public static extern IntPtr GetObjectArrayElement(IntPtr array, int index);
//        
//        public static extern IntPtr GetObjectClass(IntPtr obj);
//        
//        public static extern IntPtr GetObjectField(IntPtr obj, IntPtr fieldID);
//        
//        public static extern short GetShortArrayElement(IntPtr array, int index);
//        
//        public static extern short GetShortField(IntPtr obj, IntPtr fieldID);
//        
//        public static extern bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID);
//        
//        public static extern byte GetStaticByteField(IntPtr clazz, IntPtr fieldID);
//        
//        public static extern char GetStaticCharField(IntPtr clazz, IntPtr fieldID);
//        
//        public static extern double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID);
//        
//        public static extern IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig);
//        
//        public static extern float GetStaticFloatField(IntPtr clazz, IntPtr fieldID);
//        
//        public static extern int GetStaticIntField(IntPtr clazz, IntPtr fieldID);
//        
//        public static extern long GetStaticLongField(IntPtr clazz, IntPtr fieldID);
//        
//        public static extern IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig);
//        
//        public static extern IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID);
//        
//        public static extern short GetStaticShortField(IntPtr clazz, IntPtr fieldID);
//        
//        public static extern string GetStaticStringField(IntPtr clazz, IntPtr fieldID);
//        
//        public static extern string GetStringField(IntPtr obj, IntPtr fieldID);
//        
//        public static extern string GetStringUTFChars(IntPtr str);
//        
//        public static extern int GetStringUTFLength(IntPtr str);
//        
//        public static extern IntPtr GetSuperclass(IntPtr clazz);
//        
//        public static extern int GetVersion();
//        
//        public static extern bool IsAssignableFrom(IntPtr clazz1, IntPtr clazz2);
//        
//        public static extern bool IsInstanceOf(IntPtr obj, IntPtr clazz);
//        
//        public static extern bool IsSameObject(IntPtr obj1, IntPtr obj2);
//        
//        public static extern IntPtr NewBooleanArray(int size);
//        
//        public static extern IntPtr NewByteArray(int size);
//        
//        public static extern IntPtr NewCharArray(int size);
//        
//        public static extern IntPtr NewDoubleArray(int size);
//        
//        public static extern IntPtr NewFloatArray(int size);
//        
//        public static extern IntPtr NewGlobalRef(IntPtr obj);
//        
//        public static extern IntPtr NewIntArray(int size);
//        
//        public static extern IntPtr NewLocalRef(IntPtr obj);
//        
//        public static extern IntPtr NewLongArray(int size);
//        
//        public static extern IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args);
//        
//        public static extern IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj);
//        
//        public static extern IntPtr NewShortArray(int size);
//        
//        public static extern IntPtr NewStringUTF(string bytes);
//        
//        public static extern IntPtr PopLocalFrame(IntPtr result);
//        
//        public static extern int PushLocalFrame(int capacity);
//        
//        public static extern void SetBooleanArrayElement(IntPtr array, int index, byte val);
//        
//        public static extern void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val);
//        
//        public static extern void SetByteArrayElement(IntPtr array, int index, sbyte val);
//        
//        public static extern void SetByteField(IntPtr obj, IntPtr fieldID, byte val);
//        
//        public static extern void SetCharArrayElement(IntPtr array, int index, char val);
//        
//        public static extern void SetCharField(IntPtr obj, IntPtr fieldID, char val);
//        
//        public static extern void SetDoubleArrayElement(IntPtr array, int index, double val);
//        
//        public static extern void SetDoubleField(IntPtr obj, IntPtr fieldID, double val);
//        
//        public static extern void SetFloatArrayElement(IntPtr array, int index, float val);
//        
//        public static extern void SetFloatField(IntPtr obj, IntPtr fieldID, float val);
//        
//        public static extern void SetIntArrayElement(IntPtr array, int index, int val);
//        
//        public static extern void SetIntField(IntPtr obj, IntPtr fieldID, int val);
//        
//        public static extern void SetLongArrayElement(IntPtr array, int index, long val);
//        
//        public static extern void SetLongField(IntPtr obj, IntPtr fieldID, long val);
//        
//        public static extern void SetObjectArrayElement(IntPtr array, int index, IntPtr obj);
//        
//        public static extern void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val);
//        
//        public static extern void SetShortArrayElement(IntPtr array, int index, short val);
//        
//        public static extern void SetShortField(IntPtr obj, IntPtr fieldID, short val);
//        
//        public static extern void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val);
//        
//        public static extern void SetStaticByteField(IntPtr clazz, IntPtr fieldID, byte val);
//        
//        public static extern void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val);
//        
//        public static extern void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val);
//        
//        public static extern void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val);
//        
//        public static extern void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val);
//        
//        public static extern void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val);
//        
//        public static extern void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val);
//        
//        public static extern void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val);
//        
//        public static extern void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val);
//        
//        public static extern void SetStringField(IntPtr obj, IntPtr fieldID, string val);
//        
//        public static extern int Throw(IntPtr obj);
//        
//        public static extern int ThrowNew(IntPtr clazz, string message);
//        
//        public static extern IntPtr ToBooleanArray(bool[] array);
//        
//        public static extern IntPtr ToByteArray(byte[] array);
//        
//        public static extern IntPtr ToCharArray(char[] array);
//        
//        public static extern IntPtr ToDoubleArray(double[] array);
//        
//        public static extern IntPtr ToFloatArray(float[] array);
//        
//        public static extern IntPtr ToIntArray(int[] array);
//        
//        public static extern IntPtr ToLongArray(long[] array);
//        public static IntPtr ToObjectArray(IntPtr[] array)
//        {
//            return ToObjectArray(array, IntPtr.Zero);
//        }
//
//        
//        public static extern IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass);
//        
//        public static extern IntPtr ToReflectedField(IntPtr clazz, IntPtr fieldID, bool isStatic);
//        
//        public static extern IntPtr ToReflectedMethod(IntPtr clazz, IntPtr methodID, bool isStatic);
//        
//        public static extern IntPtr ToShortArray(short[] array);
//    }
//}
//
