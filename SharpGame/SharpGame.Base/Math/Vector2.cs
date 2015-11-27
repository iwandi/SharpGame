using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Math
{
    public struct Vector2
    {
        public static readonly Vector2 Zero = new Vector2(0f);
        public static readonly Vector2 One = new Vector2(1f);
        public static readonly Vector2 UnitX = new Vector2(1f, 0f);
        public static readonly Vector2 UnitY = new Vector2(0f, 1f);

        public float X;
        public float Y;

        public Vector2(float uniform)
        {
            X = uniform;
            Y = uniform;
        }

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        #region Add
        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(
                    lhs.X + rhs.X,
                    lhs.Y + rhs.Y
                );
        }

        public static Vector2 operator +(Vector2 lhs, float rhs)
        {
            return new Vector2(
                    lhs.X + rhs,
                    lhs.Y + rhs
                );
        }

        public static void Add(Vector2 lhs, Vector2 rhs, ref Vector2 result)
        {
            result.X = lhs.X + rhs.X;
            result.Y = lhs.Y + rhs.Y;
        }

        public static void Add(Vector2 lhs, float rhs, ref Vector2 result)
        {
            result.X = lhs.X + rhs;
            result.Y = lhs.Y + rhs;
        }
        #endregion ADD

        #region Substract
        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(
                    lhs.X - rhs.X,
                    lhs.Y - rhs.Y
                );
        }

        public static Vector2 operator -(Vector2 lhs, float rhs)
        {
            return new Vector2(
                    lhs.X - rhs,
                    lhs.Y - rhs
                );
        }

        public static void Substract(Vector2 lhs, Vector2 rhs, ref Vector2 result)
        {
            result.X = lhs.X - rhs.X;
            result.Y = lhs.Y - rhs.Y;
        }

        public static void Substract(Vector2 lhs, float rhs, ref Vector2 result)
        {
            result.X = lhs.X - rhs;
            result.Y = lhs.Y - rhs;
        }
        #endregion Substract

        #region Multiply
        public static Vector2 operator *(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(
                    lhs.X * rhs.X,
                    lhs.Y * rhs.Y
                );
        }

        public static Vector2 operator *(Vector2 lhs, float rhs)
        {
            return new Vector2(
                    lhs.X * rhs,
                    lhs.Y * rhs
                );
        }

        public static void Multiply(Vector2 lhs, Vector2 rhs, ref Vector2 result)
        {
            result.X = lhs.X * rhs.X;
            result.Y = lhs.Y * rhs.Y;
        }

        public static void Multiply(Vector2 lhs, float rhs, ref Vector2 result)
        {
            result.X = lhs.X * rhs;
            result.Y = lhs.Y * rhs;
        }
        #endregion Multiply

        #region Divide
        public static Vector2 operator /(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(
                    lhs.X / rhs.X,
                    lhs.Y / rhs.Y
                );
        }

        public static Vector2 operator /(Vector2 lhs, float rhs)
        {
            return new Vector2(
                    lhs.X / rhs,
                    lhs.Y / rhs
                );
        }

        public static void Divide(Vector2 lhs, Vector2 rhs, ref Vector2 result)
        {
            result.X = lhs.X / rhs.X;
            result.Y = lhs.Y / rhs.Y;
        }

        public static void Divide(Vector2 lhs, float rhs, ref Vector2 result)
        {
            result.X = lhs.X / rhs;
            result.Y = lhs.Y / rhs;
        }
        #endregion Divide

        #region Compare
        public static bool operator ==(Vector2 lhs, Vector2 rhs)
        {
            return lhs.X == rhs.X &&
                lhs.Y == rhs.Y;
        }

        public static bool operator !=(Vector2 lhs, Vector2 rhs)
        {
            return lhs.X != rhs.X ||
                lhs.Y != rhs.Y;
        }

        public bool Equals(Vector2 other)
        {
            return X == other.X &&
                Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            return obj is Vector2 && Equals((Vector2)obj);
        }
        #endregion Compare

        #region Object Overrides
        public override int GetHashCode()
        {
            return X.GetHashCode() ^
                Y.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Vector2({0}, {1})", X, Y);
        }
        #endregion Object Overrides

        #region Simple Algorythm
        public float Lenght()
        {
            return (float)System.Math.Sqrt(
                X * X +
                Y * Y);
        }

        public float LenghtSquared()
        {
            return X * X +
                Y * Y;
        }

        public float Distance(Vector2 other)
        {
            float X = (this.X - other.X);
            float Y = (this.Y - other.Y);
            return (float)System.Math.Sqrt(
                X * X +
                Y * Y);
            ///return (this - other).Lenght();
        }

        public static float Distance(Vector2 lhs, Vector2 rhs)
        {
            float X = (lhs.X - rhs.X);
            float Y = (lhs.Y - rhs.Y);
            return (float)System.Math.Sqrt(
                X * X +
                Y * Y);
            //return (lhs - rhs).Lenght();
        }

        public float DistanceSquared(Vector2 other)
        {
            float X = (this.X - other.X);
            float Y = (this.Y - other.Y);
            return X * X +
                Y * Y;
            //return (this - other).LenghtSquared();
        }

        public static float DistanceSquared(Vector2 lhs, Vector2 rhs)
        {
            float X = (lhs.X - rhs.X);
            float Y = (lhs.Y - rhs.Y);
            return X * X +
                Y * Y;
            //return (lhs - rhs).LenghtSquared();
        }

        public Vector2 Max(Vector2 other)
        {
            return new Vector2((float)System.Math.Max(X, other.X),
                (float)System.Math.Max(Y, other.Y));
        }

        public void Max(Vector2 lhs, Vector2 rhs, ref Vector2 result)
        {
            result.X = (float)System.Math.Max(lhs.X, rhs.X);
            result.Y = (float)System.Math.Max(lhs.Y, rhs.Y);
        }

        public Vector2 Min(Vector2 other)
        {
            return new Vector2((float)System.Math.Min(X, other.X),
                (float)System.Math.Min(Y, other.Y));
        }

        public void Min(Vector2 lhs, Vector2 rhs, ref Vector2 result)
        {
            result.X = (float)System.Math.Min(lhs.X, rhs.X);
            result.Y = (float)System.Math.Min(lhs.Y, rhs.Y);
        }

        public float MaxAxis()
        {
            return System.Math.Max(X, Y);
        }

        public float MinAxis()
        {
            return System.Math.Min(X, Y);
        }

        public Vector2 Clamp()
        {
            return Clamp(0f, 1f);
        }

        public Vector2 Clamp(float min, float max)
        {
            return new Vector2(MathHelper.Clamp(X, min, max),
                MathHelper.Clamp(Y, min, max));
        }

        public Vector2 Clamp(Vector2 min, Vector2 max)
        {
            return new Vector2(MathHelper.Clamp(X, min.X, max.X),
                MathHelper.Clamp(Y, min.Y, max.Y));
        }

        public void Clamp(Vector2 vec, ref Vector2 result)
        {
            Clamp(vec, 0f, 1f, ref result);
        }

        public void Clamp(Vector2 vec, float min, float max, ref Vector2 result)
        {
            result.X = MathHelper.Clamp(vec.X, min, max);
            result.Y = MathHelper.Clamp(vec.Y, min, max);
        }

        public void Clamp(Vector2 vec, Vector2 min, Vector2 max, ref Vector2 result)
        {
            result.X = MathHelper.Clamp(vec.X, min.X, max.X);
            result.Y = MathHelper.Clamp(vec.Y, min.Y, max.Y);
        }

        public Vector2 Normalize()
        {
            float l = Lenght();
            return new Vector2(X / l,
                Y / l);
        }

        public static void Normalize(Vector2 vec, ref Vector2 result)
        {
            float l = vec.Lenght();
            result.X = vec.X / l;
            result.Y = vec.Y / l;
        }

        public float Dot(Vector2 other)
        {
            return X * other.X +
                Y * other.Y;
        }

        public static float Dot(Vector2 lhs, Vector2 rhs)
        {
            return lhs.X * rhs.X +
                lhs.Y * rhs.Y;
        }

        public static Vector2 Lerp(Vector2 start, Vector2 end, float amount)
        {
            return new Vector2(start.X + (start.X - end.X) * amount,
                start.Y + (start.Y - end.Y) * amount);
        }

        public static Vector2 Lerp(Vector2 start, Vector2 end, Vector2 amount)
        {
            return new Vector2(start.X + (start.X - end.X) * amount.X,
                start.Y + (start.Y - end.Y) * amount.Y);
        }

        public static void Lerp(Vector2 start, Vector2 end, float amount, ref Vector2 result)
        {
            result.X = start.X + (start.X - end.X) * amount;
            result.Y = start.Y + (start.Y - end.Y) * amount;
        }

        public static void Lerp(Vector2 start, Vector2 end, Vector2 amount, ref Vector2 result)
        {
            result.X = start.X + (start.X - end.X) * amount.X;
            result.Y = start.Y + (start.Y - end.Y) * amount.Y;
        }

        public static Vector2 SmoothStep(Vector2 start, Vector2 end, float step)
        {
            float amount = (step * step * (3 - 2 * step));

            return new Vector2(start.X + (start.X - end.X) * amount,
                start.Y + (start.Y - end.Y) * amount);
        }

        public static Vector2 SmoothStep(Vector2 start, Vector2 end, Vector2 step)
        {
            return new Vector2(start.X + (start.X - end.X) * (step.X * step.X * (3 - 2 * step.X)),
                start.Y + (start.Y - end.Y) * (step.Y * step.Y * (3 - 2 * step.Y)));
        }

        public static void SmoothStep(Vector2 start, Vector2 end, float step, ref Vector2 result)
        {
            float amount = (step * step * (3 - 2 * step));

            result.X = start.X + (start.X - end.X) * amount;
            result.Y = start.Y + (start.Y - end.Y) * amount;
        }

        public static void SmoothStep(Vector2 start, Vector2 end, Vector2 step, ref Vector2 result)
        {
            result.X = start.X + (start.X - end.X) * (step.X * step.X * (3 - 2 * step.X));
            result.Y = start.Y + (start.Y - end.Y) * (step.Y * step.Y * (3 - 2 * step.Y));
        }
        #endregion Simple Algotythm

        #region Conversion
        public static implicit operator Vector3(Vector2 vec)
        {
            return new Vector3(vec.X, vec.Y, 0f);
        }

        public Vector4 ToVector3(float z)
        {
            return new Vector3(X, Y, z);
        }
        
        public static void ToVector3(Vector2 vec, ref Vector3 result)
        {
            result.X = vec.X;
            result.Y = vec.Y;
            result.Z = 0f;
        }

        public static void ToVector3(Vector2 vec, float z, ref Vector3 result)
        {
            result.X = vec.X;
            result.Y = vec.Y;
            result.Z = z;
        }  

        public static implicit operator Vector4(Vector2 vec)
        {
            return new Vector4(vec.X, vec.Y, 0f, 0f);
        }

        public Vector4 ToVector4(float z, float w)
        {
            return new Vector4(X, Y, z, w);
        }

        public static void ToVector4(Vector2 vec, ref Vector4 result)
        {
            result.X = vec.X;
            result.Y = vec.Y;
            result.Z = 0f;
            result.W = 0f;
        }

        public static void ToVector4(Vector2 vec, float z, float w, ref Vector4 result)
        {
            result.X = vec.X;
            result.Y = vec.Y;
            result.Z = z;
            result.W = w;
        }
        #endregion Conversion
    }
}
