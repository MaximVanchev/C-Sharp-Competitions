using System;
using System.Collections.Generic;

namespace cut
{
    class Program
    {

        public static long init(long[] h, int K)
        {
            List<long[]> safeTowers = new List<long[]>();
            for (int r = 0; r < h.Length; r++)
            {
                for (int l = 0; l < h.Length; l++)
                {
                    if (r == l)
                    {
                        continue;
                    }
                    int biggestTowerIndex = r;
                    if (h[l] > h[r])
                    {
                        biggestTowerIndex = l;
                    }
                    long cutTowers = 0;
                    for (int i = 0; i < h.Length; i++)
                    {
                        if (i == r || i == l)
                        {
                            continue;
                        }
                        if (h[biggestTowerIndex] < h[i])
                        {
                            cutTowers++;
                        }
                    }
                    if (cutTowers <= K)
                    {
                        bool b = true;
                        foreach (var item in safeTowers)
                        {
                            if (item[0] == r && item[1] == l || item[1] == r && item[0] == l)
                            {
                                b = false;
                                break;
                            }
                        }
                        if (b)
                        {
                            safeTowers.Add(new long[2] { r , l});
                        }
                    }
                }
            }
            return safeTowers.Count;
        }
    }
}
