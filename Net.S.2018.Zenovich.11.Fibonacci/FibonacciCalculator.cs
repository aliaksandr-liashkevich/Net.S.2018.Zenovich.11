using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.S._2018.Zenovich._11.Fibonacci
{
    /// <summary>
    /// Allows to get fibonacci number.
    /// </summary>
    public class FibonacciCalculator
    {
        /// <summary>
        /// Gets fibonacci numbers.
        /// </summary>
        /// <returns>The next fibonacci number.</returns>
        public static IEnumerable<int> GetFibonacciNumbers()
        {
            int previous = 0;
            int result = 1;

            yield return result;

            int temp = 0;
            while (true)
            {
                temp = previous;
                previous = result;
                result = temp + result;

                yield return result;
            }
        }
    }
}
