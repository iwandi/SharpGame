using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Math
{
    public class Vector4 : IEquatable<Vector4>
    {
        public static readonly Vector4 Zero = new Vector4(0f);
        public static readonly Vector4 One = new Vector4(1f);
        public static readonly Vector4 UnitX = new Vector4(1f, 0f, 0f, 0f);
        public static readonly Vector4 UnitY = new Vector4(0f, 1f, 0f, 0f);
        public static readonly Vector4 UnitZ = new Vector4(0f, 0f, 1f, 0f);
        public static readonly Vector4 UnitW = new Vector4(0f, 0f, 0f, 1f);

        public float X;
        public float Y;
        public float Z;
        public float W;

        public Vector4(float uniform)
        {
            X = uniform;
            Y = uniform;
            Z = uniform;
            W = uniform;
        }

        public Vector4(Vector2 xy, float z, float w)
        {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        public Vector4(Vector2 xy, Vector2 zw)
        {
            X = xy.X;
            Y = xy.Y;
            Z = zw.X;
            W = zw.Y;
        }

        public Vector4(Vector3 xyz, float w)
        {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        public Vector4(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        #region Add
        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
                    lhs.X + rhs.X,
                    lhs.Y + rhs.Y,
                    lhs.Z + rhs.Z,
                    lhs.W + rhs.W
                );
        }

        public static Vector4 operator +(Vector4 lhs, float rhs)
        {
            return new Vector4(
                    lhs.X + rhs,
                    lhs.Y + rhs,
                    lhs.Z + rhs,
                    lhs.W + rhs
                );
        }

        public static void Add(Vector4 lhs, Vector4 rhs, ref Vector4 result)
        {
            result.X = lhs.X + rhs.X;
            result.Y = lhs.Y + rhs.Y;
            result.Z = lhs.Z + rhs.Z;
            result.W = lhs.W + rhs.W;
        }

        public static void Add(Vector4 lhs, float rhs, ref Vector4 result)
        {
            result.X = lhs.X + rhs;
            result.Y = lhs.Y + rhs;
            result.Z = lhs.Z + rhs;
            result.W = lhs.W + rhs;
        }
        #endregion ADD

        #region Substract
        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
                    lhs.X - rhs.X,
                    lhs.Y - rhs.Y,
                    lhs.Z - rhs.Z,
                    lhs.W - rhs.W
                );
        }

        public static Vector4 operator -(Vector4 lhs, float rhs)
        {
            return new Vector4(
                    lhs.X - rhs,
                    lhs.Y - rhs,
                    lhs.Z - rhs,
                    lhs.W - rhs
                );
        }

        public static void Substract(Vector4 lhs, Vector4 rhs, ref Vector4 result)
        {
            result.X = lhs.X - rhs.X;
            result.Y = lhs.Y - rhs.Y;
            result.Z = lhs.Z - rhs.Z;
            result.W = lhs.W - rhs.W;
        }

        public static void Substract(Vector4 lhs, float rhs, ref Vector4 result)
        {
            result.X = lhs.X - rhs;
            result.Y = lhs.Y - rhs;
            result.Z = lhs.Z - rhs;
            result.W = lhs.W - rhs;
        }
        #endregion Substract

        #region Multiply
        public static Vector4 operator *(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
                    lhs.X * rhs.X,
                    lhs.Y * rhs.Y,
                    lhs.Z * rhs.Z,
                    lhs.W * rhs.W
                );
        }

        public static Vector4 operator *(Vector4 lhs, float rhs)
        {
            return new Vector4(
                    lhs.X * rhs,
                    lhs.Y * rhs,
                    lhs.Z * rhs,
                    lhs.W * rhs
                );
        }

        public static void Multiply(Vector4 lhs, Vector4 rhs, ref Vector4 result)
        {
            result.X = lhs.X * rhs.X;
            result.Y = lhs.Y * rhs.Y;
            result.Z = lhs.Z * rhs.Z;
            result.W = lhs.W * rhs.W;
        }

        public static void Multiply(Vector4 lhs, float rhs, ref Vector4 result)
        {
            result.X = lhs.X * rhs;
            result.Y = lhs.Y * rhs;
            result.Z = lhs.Z * rhs;
            result.W = lhs.W * rhs;
        }
        #endregion Multiply

        #region Divide
        public static Vector4 operator /(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
                    lhs.X / rhs.X,
                    lhs.Y / rhs.Y,
                    lhs.Z / rhs.Z,
                    lhs.W / rhs.W
                );
        }

        public static Vector4 operator /(Vector4 lhs, float rhs)
        {
            return new Vector4(
                    lhs.X / rhs,
                    lhs.Y / rhs,
                    lhs.Z / rhs,
                    lhs.W / rhs
                );
        }

        public static void Divide(Vector4 lhs, Vector4 rhs, ref Vector4 result)
        {
            result.X = lhs.X / rhs.X;
            result.Y = lhs.Y / rhs.Y;
            result.Z = lhs.Z / rhs.Z;
            result.W = lhs.W / rhs.W;
        }

        public static void Divide(Vector4 lhs, float rhs, ref Vector4 result)
        {
            result.X = lhs.X / rhs;
            result.Y = lhs.Y / rhs;
            result.Z = lhs.Z / rhs;
            result.W = lhs.W / rhs;
        }
        #endregion Divide

        #region Compare
        public static bool operator ==(Vector4 lhs, Vector4 rhs)
        {
            return lhs.X == rhs.X &&
                lhs.Y == rhs.Y &&
                lhs.Z == rhs.Z &&
                lhs.W == rhs.W;
        }

        public static bool operator !=(Vector4 lhs, Vector4 rhs)
        {
            return lhs.X != rhs.X ||
                lhs.Y != rhs.Y ||
                lhs.Z != rhs.Z ||
                lhs.W != rhs.W;
        }

        public bool Equals(Vector4 other)
        {
            return X == other.X &&
                Y == other.Y &&
                Z == other.Z &&
                W == other.W;
        }

        public override bool Equals(object obj)
        {
            return obj is Vector4 && Equals((Vector4)obj);
        }
        #endregion Compare

        #region Object Overrides
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ 
                Y.GetHashCode() ^ 
                Z.GetHashCode() ^ 
                W.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Vector4({0}, {1}, {2}, {3})", X, Y, Z, W);
        }
        #endregion Object Overrides

        #region Simple Algorythm
        public float Lenght()
        {
            return (float)System.Math.Sqrt(
                X * X +
                Y * Y + 
                Z * Z +
                W * W);
        }

        public float LenghtSquared()
        {
            return X * X +
                Y * Y +
                Z * Z +
                W * W;
        }

        public float Distance(Vector4 other)
        {
            float X = (this.X - other.X);
            float Y = (this.Y - other.Y);
            float Z = (this.Z - other.Z);
            float W = (this.W - other.W);
            return (float)System.Math.Sqrt(
                X * X +
                Y * Y +
                Z * Z +
                W * W);
            ///return (this - other).Lenght();
        }

        public static float Distance(Vector4 lhs, Vector4 rhs)
        {
            float X = (lhs.X - rhs.X);
            float Y = (lhs.Y - rhs.Y);
            float Z = (lhs.Z - rhs.Z);
            float W = (lhs.W - rhs.W);
            return (float)System.Math.Sqrt(
                X * X +
                Y * Y +
                Z * Z +
                W * W);
            //return (lhs - rhs).Lenght();
        }

        public float DistanceSquared(Vector4 other)
        {
            float X = (this.X - other.X);
            float Y = (this.Y - other.Y);
            float Z = (this.Z - other.Z);
            float W = (this.W - other.W);
            return X * X +
                Y * Y +
                Z * Z +
                W * W;
            //return (this - other).LenghtSquared();
        }

        public static float DistanceSquared(Vector4 lhs, Vector4 rhs)
        {
            float X = (lhs.X - rhs.X);
            float Y = (lhs.Y - rhs.Y);
            float Z = (lhs.Z - rhs.Z);
            float W = (lhs.W - rhs.W);
            return X * X +
                Y * Y +
                Z * Z +
                W * W;
            //return (lhs - rhs).LenghtSquared();
        }
        
        public Vector4 Max(Vector4 other)
        {
            return new  Vector4((float)System.Math.Max(X, other.X),
                (float)System.Math.Max(Y, other.Y),
                (float)System.Math.Max(Z, other.Z),
                (float)System.Math.Max(W, other.W));
        }

        public void Max(Vector4 lhs, Vector4 rhs, ref Vector4 result)
        {
            result.X = (float)System.Math.Max(lhs.X, rhs.X);
            result.Y = (float)System.Math.Max(lhs.Y, rhs.Y);
            result.Z = (float)System.Math.Max(lhs.Z, rhs.Z);
            result.W = (float)System.Math.Max(lhs.W, rhs.W);
        }

        public Vector4 Min(Vector4 other)
        {
            return new Vector4((float)System.Math.Min(X, other.X),
                (float)System.Math.Min(Y, other.Y),
                (float)System.Math.Min(Z, other.Z),
                (float)System.Math.Min(W, other.W));
        }

        public void Min(Vector4 lhs, Vector4 rhs, ref Vector4 result)
        {
            result.X = (float)System.Math.Min(lhs.X, rhs.X);
            result.Y = (float)System.Math.Min(lhs.Y, rhs.Y);
            result.Z = (float)System.Math.Min(lhs.Z, rhs.Z);
            result.W = (float)System.Math.Min(lhs.W, rhs.W);
        }

        public float MaxAxis()
        {
            return (float)System.Math.Max(System.Math.Max(X, Y), System.Math.Max(Z, W));
        }

        public float MinAxis()
        {
            return (float)System.Math.Min(System.Math.Min(X, Y), System.Math.Min(Z, W));
        }
        
        public Vector4 Clamp()
        {
            return Clamp(0f, 1f);
        }

        public Vector4 Clamp(float min, float max)
        {
            return new Vector4(MathHelper.Clamp(X, min, max),
                MathHelper.Clamp(Y, min, max),
                MathHelper.Clamp(Z, min, max),
                MathHelper.Clamp(W, min, max));
        }

        public Vector4 Clamp(Vector4 min, Vector4 max)
        {
            return new Vector4(MathHelper.Clamp(X, min.X, max.X),
                MathHelper.Clamp(Y, min.Y, max.Y),
                MathHelper.Clamp(Z, min.Z, max.Z),
                MathHelper.Clamp(W, min.W, max.W));
        }

        public void Clamp(Vector4 vec, ref Vector4 result)
        {
            Clamp(vec, 0f, 1f, ref result);
        }

        public void Clamp(Vector4 vec, float min, float max, ref Vector4 result)
        {
            result.X = MathHelper.Clamp(vec.X, min, max);
            result.Y = MathHelper.Clamp(vec.Y, min, max);
            result.Z = MathHelper.Clamp(vec.Z, min, max);
            result.W = MathHelper.Clamp(vec.W, min, max);
        }

        public void Clamp(Vector4 vec, Vector4 min, Vector4 max, ref Vector4 result)
        {
            result.X = MathHelper.Clamp(vec.X, min.X, max.X);
            result.Y = MathHelper.Clamp(vec.Y, min.Y, max.Y);
            result.Z = MathHelper.Clamp(vec.Z, min.Z, max.Z);
            result.W = MathHelper.Clamp(vec.W, min.W, max.W);
        }

        public Vector4 Normalize()
        {
            float l = Lenght();
            return new Vector4(X / l,
                Y / l,
                Z / l,
                W / l);
        }

        public static void Normalize(Vector4 vec, ref Vector4 result)
        {
            float l = vec.Lenght();
            result.X = vec.X / l;
            result.Y = vec.Y / l;
            result.Z = vec.Z / l;
            result.W = vec.W / l;
        }

        public float Dot(Vector4 other)
        {
            return X * other.X +
                Y * other.Y +
                Z * other.Z +
                W * other.W;
        }

        public static float Dot(Vector4 lhs, Vector4 rhs)
        {
            return lhs.X * rhs.X +
                lhs.Y * rhs.Y +
                lhs.Z * rhs.Z +
                lhs.W * rhs.W;
        }

        public static Vector4 Lerp(Vector4 start, Vector4 end, float amount)
        {
            return new Vector4(start.X + (start.X - end.X) * amount,
                start.Y + (start.Y - end.Y) * amount,
                start.Z + (start.Z - end.Z) * amount,
                start.W + (start.W - end.W) * amount);
        }

        public static Vector4 Lerp(Vector4 start, Vector4 end, Vector4 amount)
        {
            return new Vector4(start.X + (start.X - end.X) * amount.X,
                start.Y + (start.Y - end.Y) * amount.Y,
                start.Z + (start.Z - end.Z) * amount.Z,
                start.W + (start.W - end.W) * amount.W);
        }

        public static void Lerp(Vector4 start, Vector4 end, float amount, ref Vector4 result)
        {
            result.X = start.X + (start.X - end.X) * amount;
            result.Y = start.Y + (start.Y - end.Y) * amount;
            result.Z = start.Z + (start.Z - end.Z) * amount;
            result.W = start.W + (start.W - end.W) * amount;
        }

        public static void Lerp(Vector4 start, Vector4 end, Vector4 amount, ref Vector4 result)
        {
            result.X = start.X + (start.X - end.X) * amount.X;
            result.Y = start.Y + (start.Y - end.Y) * amount.Y;
            result.Z = start.Z + (start.Z - end.Z) * amount.Z;
            result.W = start.W + (start.W - end.W) * amount.W;
        }

        public static Vector4 SmoothStep(Vector4 start, Vector4 end, float step)
        {
            float amount = (step * step * (3 - 2 * step));

            return new Vector4(start.X + (start.X - end.X) * amount,
                start.Y + (start.Y - end.Y) * amount,
                start.Z + (start.Z - end.Z) * amount,
                start.W + (start.W - end.W) * amount);
        }

        public static Vector4 SmoothStep(Vector4 start, Vector4 end, Vector4 step)
        {
            return new Vector4(start.X + (start.X - end.X) * (step.X * step.X * (3 - 2 * step.X)),
                start.Y + (start.Y - end.Y) * (step.Y * step.Y * (3 - 2 * step.Y)),
                start.Z + (start.Z - end.Z) * (step.Z * step.Z * (3 - 2 * step.Z)),
                start.W + (start.W - end.W) * (step.W * step.W * (3 - 2 * step.W)));
        }

        public static void SmoothStep(Vector4 start, Vector4 end, float step, ref Vector4 result)
        {
            float amount = (step * step * (3 - 2 * step));

            result.X = start.X + (start.X - end.X) * amount;
            result.Y = start.Y + (start.Y - end.Y) * amount;
            result.Z = start.Z + (start.Z - end.Z) * amount;
            result.W = start.W + (start.W - end.W) * amount;
        }

        public static void SmoothStep(Vector4 start, Vector4 end, Vector4 step, ref Vector4 result)
        {
            result.X = start.X + (start.X - end.X) * (step.X * step.X * (3 - 2 * step.X));
            result.Y = start.Y + (start.Y - end.Y) * (step.Y * step.Y * (3 - 2 * step.Y));
            result.Z = start.Z + (start.Z - end.Z) * (step.Z * step.Z * (3 - 2 * step.Z));
            result.W = start.W + (start.W - end.W) * (step.W * step.W * (3 - 2 * step.W));
        }
        #endregion Simple Algotythm

        // CatmullRom 
        // Hermite 
        // Barycentric 
        // Transform

        // Unity Project
        // Unity MoveTowards

        #region Conversion
        public static implicit operator Vector2(Vector4 vec)
        {
            return new Vector2(vec.X, vec.Y);
        }

        public static void ToVector2(Vector4 vec, ref Vector2 result)
        {
            result.X = vec.X;
            result.Y = vec.Y;
        }

        public static implicit operator Vector3(Vector4 vec)
        {
            return new Vector3(vec.X, vec.Y, vec.Z);
        }

        public static void ToVector3(Vector4 vec, ref Vector3 result)
        {
            result.X = vec.X;
            result.Y = vec.Y;
            result.Z = vec.Z;
        }
        #endregion Conversion
    }
}
