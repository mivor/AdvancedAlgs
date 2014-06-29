namespace Algs.Simple
{
    public static class Recursive
    {
        public static int Cmmdc(int x, int y)
        {
            if (y == 0) return x;
            if (x == 0) return y;

            return Cmmdc(y, x % y);
        }

        public static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2); 
        }

        public static int Factorial(int n)
        {
            if (n == 0) return 1;

            return n * Factorial(n - 1);
        }
    }
}