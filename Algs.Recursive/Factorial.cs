using Algs.Common;

namespace Algs.Recursive
{
    public class Factorial : ICommand
    {
        public int Result { get; set; }
        public int Number { get; set; }

        public Factorial(int number)
        {
            Number = number;
        }

        public void Execute()
        {
            Result = Compute(Number);
        }

        private int Compute(int n)
        {
            if (n == 0) return 1;
            
            return n*Compute(n - 1);
        }
    }
}