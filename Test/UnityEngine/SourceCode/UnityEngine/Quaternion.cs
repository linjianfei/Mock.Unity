﻿namespace UnityEngine
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine.Internal;

    [StructLayout(LayoutKind.Sequential)]
    public struct Quaternion
    {
        public const float kEpsilon = 1E-06f;
        public float x;
        public float y;
        public float z;
        public float w;
        public Quaternion(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.x;

                    case 1:
                        return this.y;

                    case 2:
                        return this.z;

                    case 3:
                        return this.w;
                }
                throw new IndexOutOfRangeException("Invalid Quaternion index!");
            }
            set
            {
                switch (index)
                {
                    case 0:
                        this.x = value;
                        break;

                    case 1:
                        this.y = value;
                        break;

                    case 2:
                        this.z = value;
                        break;

                    case 3:
                        this.w = value;
                        break;

                    default:
                        throw new IndexOutOfRangeException("Invalid Quaternion index!");
                }
            }
        }
        public void Set(float new_x, float new_y, float new_z, float new_w)
        {
            this.x = new_x;
            this.y = new_y;
            this.z = new_z;
            this.w = new_w;
        }

        public static Quaternion identity
        {
            get
            {
                return new Quaternion(0f, 0f, 0f, 1f);
            }
        }
        public static float Dot(Quaternion a, Quaternion b)
        {
            return ((((a.x * b.x) + (a.y * b.y)) + (a.z * b.z)) + (a.w * b.w));
        }

        public static Quaternion AngleAxis(float angle, Vector3 axis)
        {
            return Quaternion.identity;
        }

        
        public void ToAngleAxis(out float angle, out Vector3 axis)
        {
            angle = 0f;
            axis = Vector3.zero;
        }

        public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
        {
            return Quaternion.identity;
        }

        
        public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection)
        {
            this = FromToRotation(fromDirection, toDirection);
        }

        public static Quaternion LookRotation(Vector3 forward, [DefaultValue("Vector3.up")] Vector3 upwards)
        {
            return Quaternion.identity;
        }

        [ExcludeFromDocs]
        public static Quaternion LookRotation(Vector3 forward)
        {
            Vector3 up = Vector3.up;
            return Quaternion.identity;
        }

        
        [ExcludeFromDocs]
        public void SetLookRotation(Vector3 view)
        {
            Vector3 up = Vector3.up;
            this.SetLookRotation(view, up);
        }

        public void SetLookRotation(Vector3 view, [DefaultValue("Vector3.up")] Vector3 up)
        {
            this = LookRotation(view, up);
        }

        public static Quaternion Slerp(Quaternion a, Quaternion b, float t)
        {
            return Quaternion.identity;
        }

        
        public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t)
        {
            return Quaternion.identity;
        }

        
        public static Quaternion Lerp(Quaternion a, Quaternion b, float t)
        {
            return Quaternion.identity;
        }

        
        public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t)
        {
            return Quaternion.identity;
        }

        
        public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
        {
            float num = Angle(from, to);
            if (num == 0f)
            {
                return to;
            }
            float t = Mathf.Min((float) 1f, (float) (maxDegreesDelta / num));
            return SlerpUnclamped(from, to, t);
        }

        public static Quaternion Inverse(Quaternion rotation)
        {
            return Quaternion.identity;
        }

        
        public override string ToString()
        {
            object[] args = new object[] { this.x, this.y, this.z, this.w };
            return UnityString.Format("({0:F1}, {1:F1}, {2:F1}, {3:F1})", args);
        }

        public string ToString(string format)
        {
            object[] args = new object[] { this.x.ToString(format), this.y.ToString(format), this.z.ToString(format), this.w.ToString(format) };
            return UnityString.Format("({0}, {1}, {2}, {3})", args);
        }

        public static float Angle(Quaternion a, Quaternion b)
        {
            return ((Mathf.Acos(Mathf.Min(Mathf.Abs(Dot(a, b)), 1f)) * 2f) * 57.29578f);
        }

        public Vector3 eulerAngles
        {
            get
            {
                return (Vector3) (Internal_ToEulerRad(this) * 57.29578f);
            }
            set
            {
                this = Internal_FromEulerRad((Vector3) (value * 0.01745329f));
            }
        }
        public static Quaternion Euler(float x, float y, float z)
        {
            return Internal_FromEulerRad((Vector3) (new Vector3(x, y, z) * 0.01745329f));
        }

        public static Quaternion Euler(Vector3 euler)
        {
            return Internal_FromEulerRad((Vector3) (euler * 0.01745329f));
        }

        private static Vector3 Internal_ToEulerRad(Quaternion rotation)
        {
            return Vector3.zero;
        }

        
        private static Quaternion Internal_FromEulerRad(Vector3 euler)
        {
            return Quaternion.identity;
        }

       

        
        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public static Quaternion EulerRotation(float x, float y, float z)
        {
            return Internal_FromEulerRad(new Vector3(x, y, z));
        }

        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public static Quaternion EulerRotation(Vector3 euler)
        {
            return Internal_FromEulerRad(euler);
        }

        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public void SetEulerRotation(float x, float y, float z)
        {
            this = Internal_FromEulerRad(new Vector3(x, y, z));
        }

        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public void SetEulerRotation(Vector3 euler)
        {
            this = Internal_FromEulerRad(euler);
        }

        [Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
        public Vector3 ToEuler()
        {
            return Internal_ToEulerRad(this);
        }

        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public static Quaternion EulerAngles(float x, float y, float z)
        {
            return Internal_FromEulerRad(new Vector3(x, y, z));
        }

        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public static Quaternion EulerAngles(Vector3 euler)
        {
            return Internal_FromEulerRad(euler);
        }

        [Obsolete("Use Quaternion.ToAngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
        public void ToAxisAngle(out Vector3 axis, out float angle)
        {
            axis = Vector3.zero;
            angle = 0f;
        }

        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public void SetEulerAngles(float x, float y, float z)
        {
            this.SetEulerRotation(new Vector3(x, y, z));
        }

        [Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees")]
        public void SetEulerAngles(Vector3 euler)
        {
            this = EulerRotation(euler);
        }

        [Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
        public static Vector3 ToEulerAngles(Quaternion rotation)
        {
            return Internal_ToEulerRad(rotation);
        }

        [Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees")]
        public Vector3 ToEulerAngles()
        {
            return Internal_ToEulerRad(this);
        }

        [Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
        public static Quaternion AxisAngle(Vector3 axis, float angle)
        {
            return Quaternion.identity;
        }

        
        [Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
        public void SetAxisAngle(Vector3 axis, float angle)
        {
            this = AxisAngle(axis, angle);
        }

        public override int GetHashCode()
        {
            return (((this.x.GetHashCode() ^ (this.y.GetHashCode() << 2)) ^ (this.z.GetHashCode() >> 2)) ^ (this.w.GetHashCode() >> 1));
        }

        public override bool Equals(object other)
        {
            if (!(other is Quaternion))
            {
                return false;
            }
            Quaternion quaternion = (Quaternion) other;
            return (((this.x.Equals(quaternion.x) && this.y.Equals(quaternion.y)) && this.z.Equals(quaternion.z)) && this.w.Equals(quaternion.w));
        }

        public static Quaternion operator *(Quaternion lhs, Quaternion rhs)
        {
            return new Quaternion((((lhs.w * rhs.x) + (lhs.x * rhs.w)) + (lhs.y * rhs.z)) - (lhs.z * rhs.y), (((lhs.w * rhs.y) + (lhs.y * rhs.w)) + (lhs.z * rhs.x)) - (lhs.x * rhs.z), (((lhs.w * rhs.z) + (lhs.z * rhs.w)) + (lhs.x * rhs.y)) - (lhs.y * rhs.x), (((lhs.w * rhs.w) - (lhs.x * rhs.x)) - (lhs.y * rhs.y)) - (lhs.z * rhs.z));
        }

        public static Vector3 operator *(Quaternion rotation, Vector3 point)
        {
            Vector3 vector;
            float num = rotation.x * 2f;
            float num2 = rotation.y * 2f;
            float num3 = rotation.z * 2f;
            float num4 = rotation.x * num;
            float num5 = rotation.y * num2;
            float num6 = rotation.z * num3;
            float num7 = rotation.x * num2;
            float num8 = rotation.x * num3;
            float num9 = rotation.y * num3;
            float num10 = rotation.w * num;
            float num11 = rotation.w * num2;
            float num12 = rotation.w * num3;
            vector.x = (((1f - (num5 + num6)) * point.x) + ((num7 - num12) * point.y)) + ((num8 + num11) * point.z);
            vector.y = (((num7 + num12) * point.x) + ((1f - (num4 + num6)) * point.y)) + ((num9 - num10) * point.z);
            vector.z = (((num8 - num11) * point.x) + ((num9 + num10) * point.y)) + ((1f - (num4 + num5)) * point.z);
            return vector;
        }

        public static bool operator ==(Quaternion lhs, Quaternion rhs)
        {
            return (Dot(lhs, rhs) > 0.999999f);
        }

        public static bool operator !=(Quaternion lhs, Quaternion rhs)
        {
            return (Dot(lhs, rhs) <= 0.999999f);
        }
    }
}

