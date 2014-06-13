using Algs.Common;

namespace Algs.Recursive
{
    public class Cmmdc : ICommand
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Result { get; set; }

        public Cmmdc(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Execute()
        {
            Result = Compute(X, Y);
        }

        private int Compute(int x, int y)
        {
            if (y == 0) return x;
            if (x == 0) return y;

            return Compute(y, x%y);
        }
    }
}