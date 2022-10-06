namespace ReadOnlyVectorTask
{
    public class ReadOnlyVector
    {
        public readonly double X, Y;

        public ReadOnlyVector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public ReadOnlyVector Add(ReadOnlyVector other)
        {
            double x = this.X + other.X;
            double y = this.Y + other.Y;
            return new ReadOnlyVector(x, y);
        }

        public ReadOnlyVector WithX(double x)
        {
            return new ReadOnlyVector(x, this.Y);
        }

        public ReadOnlyVector WithY(double y)
        {
            return new ReadOnlyVector(this.X, y);
        }
    }
}