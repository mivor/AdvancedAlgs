using System.CodeDom;
using System.Reflection;

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
    }
}