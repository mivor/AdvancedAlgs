using System;
using System.Collections.Generic;
using System.Linq;

namespace Algs.Simple
{
    public static class Greedy
    {
        public static int Spectacole(List<Tuple<int, int>> spectacole)
        {
            var sortedSpect = spectacole.OrderBy(sp => sp.Item2).ToList();
            var result = 1;
            var lastEndTime = spectacole.First().Item2;

            for (var i = 1; i < sortedSpect.Count; i++)
            {
                var curentSpect = sortedSpect[i];
                if (curentSpect.Item1 <= lastEndTime) continue;

                result++;
                lastEndTime = curentSpect.Item2;
            }

            return result;
        }
    }
}