using System;

namespace Vector
{
    public class Vector
    {
        public double X, Y;

        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public Vector Add(Vector v)
        {
            return Geometry.Add(this, v);
        }

        public bool Belongs(Segment s)
        {
            return Geometry.IsVectorInSegment(this, s);
        }
    }

    public class Segment
    {
        public Vector Begin, End;

        public double GetLength()
        {
            return Geometry.GetLength(this);
        }

        public bool Contains(Vector v)
        {
            return Geometry.IsVectorInSegment(v, this);
        }
    }

    public class Geometry
    {
        public static double GetLength(Vector v)
        {
            return Math.Sqrt(v.X * v.X + v.Y * v.Y);
        }

        public static double GetLength(Segment s)
        {
            var v = new Vector 
	        { 
		        X = s.End.X - s.Begin.X, 
		        Y = s.End.Y - s.Begin.Y 
	        };

            return GetLength(v);
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector 
	        { 
		        X = v1.X + v2.X, 
		        Y = v1.Y + v2.Y 
	        };
        }

        public static bool IsVectorInSegment(Vector v, Segment s)
        {
            double segmentFullLength = GetLength(s);
            var v2 = new Vector 
	        { 
		        X = v.X - s.Begin.X, 
		        Y = v.Y - s.Begin.Y 
	        };
            double segmentFirstPartLength = GetLength(v2);
            var v3 = new Vector 
	        { 
		        X = s.End.X - v.X, 
		        Y = s.End.Y - v.Y 
	        };
            double segmentSecondPartLength = GetLength(v3);

            return segmentFirstPartLength + segmentSecondPartLength == segmentFullLength;
        }
    }
}