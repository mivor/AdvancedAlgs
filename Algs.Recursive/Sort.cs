namespace Algs.Simple
{
    public static class Sort
    {
        public static void Bubble(int[] array)
        {
            var sorted = false;

            while ( !sorted)
            {
                sorted = true;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                        sorted = false;
                    }
                }
            }
        }

        public static void Insertion(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        public static void InsertionRecursive(int[] array, int? i = null, int? j = null, int? key = null)
        {
            var nested = true;
            i = i ?? 1;
            if (j == null)
            {
                j = i - 1;
                nested = false;
            }

            if (i == array.Length) return;
            key = key ?? array[(int)i];

            if (j < 0 || array[(int) j] <= key)
            {
                array[(int) j + 1] = (int) key;
                if (nested) return;
            }
            else
            {
                array[(int)j + 1] = array[(int)j];
                InsertionRecursive(array, i, --j, key);
            }
            
            InsertionRecursive(array, ++i);
        }

        public static void Selection(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var smallestPos = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[smallestPos]) smallestPos = j;
                }

                if (i != smallestPos)
                    Swap(ref array[i], ref array[smallestPos]);
            }
        }

        public static void Merge(int[] array, int? min = null, int? max = null)
        {
            min = min ?? 0;
            max = max ?? array.Length - 1;
            if (min == max) return;
            
            var cent = (min + max)/2;

            Merge(array, min, cent);
            Merge(array, cent + 1, max);
            MergeParts(array, (int)min, (int) cent, (int) max);
        }

        private static void MergeParts(int[] array, int min, int cent, int max)
        {
            var temp = new int[max - min + 1];
            int i = min, j = cent + 1, k = 0;

            while (i <= cent && j <= max)
            {
                if (array[i] <= array[j])
                {
                    temp[k] = array[i];
                    i++;
                }
                else
                {
                    temp[k] = array[j];
                    j++;
                }
                k++;
            }

            while (i <= cent)
            {
                temp[k] = array[i];
                k++;
                i++;
            }
            while (j <= max)
            {
                temp[k] = array[j];
                k++;
                j++;
            }

            for (i = 0; i < k; i++)
            {
                array[min + i] = temp[i];
            }
        }

        private static void Swap(ref int x, ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }
    }
}