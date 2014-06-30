using System;

namespace Algs.Simple
{
    public static class Divide
    {
        public static bool Search(int[] array, int value)
        {
            var min = 0;
            var max = array.Length - 1;
            while (min < max)
            {
                var mid = (min + max)/2;
                if (array[mid] == value) return true;

                if (value < array[mid])
                    max = mid;
                else
                    min = mid + 1;
            }

            return array[min] == value;
        }

        public static long Exp(long n, long exp)
        {

            var sqroot = (long)(Math.Sqrt(exp)); 

            var prod = n; 

            for (int power = 2; power <= sqroot; power++)
            {
                prod *= n; 
            }

            var allTerms = sqroot;
            var prod2 = prod;
            if (exp != sqroot*sqroot)
            {
                prod2 *= n;
                if (exp >= sqroot * (sqroot + 1))
                    allTerms++;
            }

            var result = prod;

            long remainingTerms = allTerms - 1;
            for (; remainingTerms > exp % allTerms; remainingTerms--)
            {
                result *= prod;
            }
            for (; remainingTerms > 0; remainingTerms--)
            {
                result *= prod2;
            }

            return result;
        }
    }
}