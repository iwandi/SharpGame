using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Math
{
    public struct Vector3
    {
        public static readonly Vector3 Zero = new Vector3(0f);
        public static readonly Vector3 One = new Vector3(1f);
        public static readonly Vector3 UnitX = new Vector3(1f, 0f, 0f);
        public static readonly Vector3 UnitY = new Vector3(0f, 1f, 0f);
        public static readonly Vector3 UnitZ = new Vector3(0f, 0f, 1f);

        public float X;
        public float Y;
        public float Z;

        public Vector3(float uniform)
        {
            X = uniform;
            Y = uniform;
            Z = uniform;
        }

        public Vector3(Vector2 xy, float z)
        {
            X = xy.X;
            Y = xy.Y;
            Z = z;
        }

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        #region Add
        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(
                    lhs.X + rhs.X,
                    lhs.Y + rhs.Y,
                    lhs.Z + rhs.Z
                );
        }

        public static Vector3 operator +(Vector3 lhs, float rhs)
        {
            return new Vector3(
                    lhs.X + rhs,
                    lhs.Y + rhs,
                    lhs.Z + rhs
                );
        }

        public static void Add(Vector3 lhs, Vector3 rhs, ref Vector3 result)
        {
            result.X = lhs.X + rhs.X;
            result.Y = lhs.Y + rhs.Y;
            result.Z = lhs.Z + rhs.Z;
        }

        public static void Add(Vector3 lhs, float rhs, ref Vector3 result)
        {
            result.X = lhs.X + rhs;
            result.Y = lhs.Y + rhs;
            result.Z = lhs.Z + rhs;
        }
        #endregion ADD

        #region Substract
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(
                    lhs.X - rhs.X,
                    lhs.Y - rhs.Y,
                    lhs.Z - rhs.Z
                );
        }

        public static Vector3 operator -(Vector3 lhs, float rhs)
        {
            return new Vector3(
                    lhs.X - rhs,
                    lhs.Y - rhs,
                    lhs.Z - rhs
                );
        }

        public static void Substract(Vector3 lhs, Vector3 rhs, ref Vector3 result)
        {
            result.X = lhs.X - rhs.X;
            result.Y = lhs.Y - rhs.Y;
            result.Z = lhs.Z - rhs.Z;
        }

        public static void Substract(Vector3 lhs, float rhs, ref Vector3 result)
        {
            result.X = lhs.X - rhs;
            result.Y = lhs.Y - rhs;
            result.Z = lhs.Z - rhs;
        }
        #endregion Substract

        #region Multiply
        public static Vector3 operator *(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(
                    lhs.X * rhs.X,
                    lhs.Y * rhs.Y,
                    lhs.Z * rhs.Z
                );
        }

        public static Vector3 operator *(Vector3 lhs, float rhs)
        {
            return new Vector3(
                    lhs.X * rhs,
                    lhs.Y * rhs,
                    lhs.Z * rhs
                );
        }

        public static void Multiply(Vector3 lhs, Vector3 rhs, ref Vector3 result)
        {
            result.X = lhs.X * rhs.X;
            result.Y = lhs.Y * rhs.Y;
            result.Z = lhs.Z * rhs.Z;
        }

        public static void Multiply(Vector3 lhs, float rhs, ref Vector3 result)
        {
            result.X = lhs.X * rhs;
            result.Y = lhs.Y * rhs;
            result.Z = lhs.Z * rhs;
        }
        #endregion Multiply

        #region Divide
        public static Vector3 operator /(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(
                    lhs.X / rhs.X,
                    lhs.Y / rhs.Y,
                    lhs.Z / rhs.Z
                );
        }

        public static Vector3 operator /(Vector3 lhs, float rhs)
        {
            return new Vector3(
                    lhs.X / rhs,
                    lhs.Y / rhs,
                    lhs.Z / rhs
                );
        }

        public static void Divide(Vector3 lhs, Vector3 rhs, ref Vector3 result)
        {
            result.X = lhs.X / rhs.X;
            result.Y = lhs.Y / rhs.Y;
            result.Z = lhs.Z / rhs.Z;
        }

        public static void Divide(Vector3 lhs, float rhs, ref Vector3 result)
        {
            result.X = lhs.X / rhs;
            result.Y = lhs.Y / rhs;
            result.Z = lhs.Z / rhs;
        }
        #endregion Divide

        #region Compare
        public static bool operator ==(Vector3 lhs, Vector3 rhs)
        {
            return lhs.X == rhs.X &&
                lhs.Y == rhs.Y &&
                lhs.Z == rhs.Z;
        }

        public static bool operator !=(Vector3 lhs, Vector3 rhs)
        {
            return lhs.X != rhs.X ||
                lhs.Y != rhs.Y ||
                lhs.Z != rhs.Z;
        }

        public bool Equals(Vector3 other)
        {
            return X == other.X &&
                Y == other.Y &&
                Z == other.Z;
        }

        public override bool Equals(object obj)
        {
            return obj is Vector3 && Equals((Vector3)obj);
        }
        #endregion Compare

        #region Object Overrides
        public override int GetHashCode()
        {
            return X.GetHashCode() ^
                Y.GetHashCode() ^
                Z.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Vector3({0}, {1}, {2})", X, Y, Z);
        }
        #endregion Object Overrides

        #region Simple Algorythm
        public float Lenght()
        {
            return (float)System.Math.Sqrt(
                X * X +
                Y * Y +
                Z * Z);
        }

        public float LenghtSquared()
        {
            return X * X +
                Y * Y +
                Z * Z;
        }

        public float Distance(Vector3 other)
        {
            float X = (this.X - other.X);
            float Y = (this.Y - other.Y);
            float Z = (this.Z - other.Z);
            return (float)System.Math.Sqrt(
                X * X +
                Y * Y +
                Z * Z);
            ///return (this - other).Lenght();
        }

        public static float Distance(Vector3 lhs, Vector3 rhs)
        {
            float X = (lhs.X - rhs.X);
            float Y = (lhs.Y - rhs.Y);
            float Z = (lhs.Z - rhs.Z);
            return (float)System.Math.Sqrt(
                X * X +
                Y * Y +
                Z * Z);
            //return (lhs - rhs).Lenght();
        }

        public float DistanceSquared(Vector3 other)
        {
            float X = (this.X - other.X);
            float Y = (this.Y - other.Y);
            float Z = (this.Z - other.Z);
            return X * X +
                Y * Y +
                Z * Z;
            //return (this - other).LenghtSquared();
        }

        public static float DistanceSquared(Vector3 lhs, Vector3 rhs)
        {
            float X = (lhs.X - rhs.X);
            float Y = (lhs.Y - rhs.Y);
            float Z = (lhs.Z - rhs.Z);
            return X * X +
                Y * Y +
                Z * Z;
            //return (lhs - rhs).LenghtSquared();
        }

        public Vector3 Max(Vector3 other)
        {
            return new Vector3((float)System.Math.Max(X, other.X),
                (float)System.Math.Max(Y, other.Y),
                (float)System.Math.Max(Z, other.Z));
        }

        public void Max(Vector3 lhs, Vector3 rhs, ref Vector3 result)
        {
            result.X = (float)System.Math.Max(lhs.X, rhs.X);
            result.Y = (float)System.Math.Max(lhs.Y, rhs.Y);
            result.Z = (float)System.Math.Max(lhs.Z, rhs.Z);
        }

        public Vector3 Min(Vector3 other)
        {
            return new Vector3((float)System.Math.Min(X, other.X),
                (float)System.Math.Min(Y, other.Y),
                (float)System.Math.Min(Z, other.Z));
        }

        public void Min(Vector3 lhs, Vector3 rhs, ref Vector3 result)
        {
            result.X = (float)System.Math.Min(lhs.X, rhs.X);
            result.Y = (float)System.Math.Min(lhs.Y, rhs.Y);
            result.Z = (float)System.Math.Min(lhs.Z, rhs.Z);
        }

        public float MaxAxis()
        {
            return (float)System.Math.Max(System.Math.Max(X, Y), Z);
        }

        public float MinAxis()
        {
            return (float)System.Math.Min(System.Math.Min(X, Y), Z);
        }

        public Vector3 Clamp()
        {
            return Clamp(0f, 1f);
        }

        public Vector3 Clamp(float min, float max)
        {
            return new Vector3(MathHelper.Clamp(X, min, max),
                MathHelper.Clamp(Y, min, max),
                MathHelper.Clamp(Z, min, max));
        }

        public Vector3 Clamp(Vector3 min, Vector3 max)
        {
            return new Vector3(MathHelper.Clamp(X, min.X, max.X),
                MathHelper.Clamp(Y, min.Y, max.Y),
                MathHelper.Clamp(Z, min.Z, max.Z));
        }

        public void Clamp(Vector3 vec, ref Vector3 result)
        {
            Clamp(vec, 0f, 1f, ref result);
        }

        public void Clamp(Vector3 vec, float min, float max, ref Vector3 result)
        {
            result.X = MathHelper.Clamp(vec.X, min, max);
            result.Y = MathHelper.Clamp(vec.Y, min, max);
            result.Z = MathHelper.Clamp(vec.Z, min, max);
        }

        public void Clamp(Vector3 vec, Vector3 min, Vector3 max, ref Vector3 result)
        {
            result.X = MathHelper.Clamp(vec.X, min.X, max.X);
            result.Y = MathHelper.Clamp(vec.Y, min.Y, max.Y);
            result.Z = MathHelper.Clamp(vec.Z, min.Z, max.Z);
        }

        public Vector3 Normalize()
        {
            float l = Lenght();
            return new Vector3(X / l,
                Y / l,
                Z / l);
        }

        public static void Normalize(Vector3 vec, ref Vector3 result)
        {
            float l = vec.Lenght();
            result.X = vec.X / l;
            result.Y = vec.Y / l;
            result.Z = vec.Z / l;
        }

        public float Dot(Vector3 other)
        {
            return X * other.X +
                Y * other.Y +
                Z * other.Z;
        }

        public static float Dot(Vector3 lhs, Vector3 rhs)
        {
            return lhs.X * rhs.X +
                lhs.Y * rhs.Y +
                lhs.Z * rhs.Z;
        }

        public static Vector3 Lerp(Vector3 start, Vector3 end, float amount)
        {
            return new Vector3(start.X + (start.X - end.X) * amount,
                start.Y + (start.Y - end.Y) * amount,
                start.Z + (start.Z - end.Z) * amount);
        }

        public static Vector3 Lerp(Vector3 start, Vector3 end, Vector3 amount)
        {
            return new Vector3(start.X + (start.X - end.X) * amount.X,
                start.Y + (start.Y - end.Y) * amount.Y,
                start.Z + (start.Z - end.Z) * amount.Z);
        }

        public static void Lerp(Vector3 start, Vector3 end, float amount, ref Vector3 result)
        {
            result.X = start.X + (start.X - end.X) * amount;
            result.Y = start.Y + (start.Y - end.Y) * amount;
            result.Z = start.Z + (start.Z - end.Z) * amount;
        }

        public static void Lerp(Vector3 start, Vector3 end, Vector3 amount, ref Vector3 result)
        {
            result.X = start.X + (start.X - end.X) * amount.X;
            result.Y = start.Y + (start.Y - end.Y) * amount.Y;
            result.Z = start.Z + (start.Z - end.Z) * amount.Z;
        }

        public static Vector3 SmoothStep(Vector3 start, Vector3 end, float step)
        {
            float amount = (step * step * (3 - 2 * step));

            return new Vector3(start.X + (start.X - end.X) * amount,
                start.Y + (start.Y - end.Y) * amount,
                start.Z + (start.Z - end.Z) * amount);
        }

        public static Vector3 SmoothStep(Vector3 start, Vector3 end, Vector3 step)
        {
            return new Vector3(start.X + (start.X - end.X) * (step.X * step.X * (3 - 2 * step.X)),
                start.Y + (start.Y - end.Y) * (step.Y * step.Y * (3 - 2 * step.Y)),
                start.Z + (start.Z - end.Z) * (step.Z * step.Z * (3 - 2 * step.Z)));
        }

        public static void SmoothStep(Vector3 start, Vector3 end, float step, ref Vector3 result)
        {
            float amount = (step * step * (3 - 2 * step));

            result.X = start.X + (start.X - end.X) * amount;
            result.Y = start.Y + (start.Y - end.Y) * amount;
            result.Z = start.Z + (start.Z - end.Z) * amount;
        }

        public static void SmoothStep(Vector3 start, Vector3 end, Vector3 step, ref Vector3 result)
        {
            result.X = start.X + (start.X - end.X) * (step.X * step.X * (3 - 2 * step.X));
            result.Y = start.Y + (start.Y - end.Y) * (step.Y * step.Y * (3 - 2 * step.Y));
            result.Z = start.Z + (start.Z - end.Z) * (step.Z * step.Z * (3 - 2 * step.Z));
        }
        #endregion Simple Algotythm

        #region Conversion
        public static implicit operator Vector2(Vector3 vec)
        {
            return new Vector2(vec.X, vec.Y);
        }

        public static void ToVector2(Vector3 vec, ref Vector2 result)
        {
            result.X = vec.X;
            result.Y = vec.Y;
        }

        public static implicit operator Vector4(Vector3 vec)
        {
            return new Vector4(vec.X, vec.Y, vec.Z, 0f);
        }

        public Vector4 ToVector4(float w)
        {
            return new Vector4(X, Y, Z, w);
        }

        public static void ToVector4(Vector4 vec, ref Vector4 result)
        {
            result.X = vec.X;
            result.Y = vec.Y;
            result.Z = vec.Z;
            result.W = 0f;
        }

        public static void ToVector4(Vector4 vec,float w, ref Vector4 result)
        {
            result.X = vec.X;
            result.Y = vec.Y;
            result.Z = vec.Z;
            result.W = w;
        }
        #endregion Conversion
    }
}
