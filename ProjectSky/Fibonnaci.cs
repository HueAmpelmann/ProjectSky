using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectSky
{
    public class Fibonnaci : IFibonnaci
    {
        private Dictionary<int, long> m_cache = new Dictionary<int, long>();

        public long Calculate(int n)
        {
            if (n <= 1)
                return n;

            long result;

            // If it's in the cache, return it from the cache
            if (m_cache.TryGetValue(n, out result))
                return result;


            // Recursion is good, right?
            result = Calculate(n - 1) + Calculate(n - 2);

            m_cache.Add(n, result);

            return result;
        }
    }
}
