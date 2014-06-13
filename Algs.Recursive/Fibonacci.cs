using Algs.Common;

namespace Algs.Recursive
{
    public class Fibonacci : ICommand
    {
        public int Result { get; set; }
        public int Number { get; set; }

        public Fibonacci(int number)
        {
            Number = number;
        }

        public void Execute()
        {
            Result = Compute(Number);
        }

        private int Compute(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Compute(n - 1) + Compute(n - 2);
        }
    }
}