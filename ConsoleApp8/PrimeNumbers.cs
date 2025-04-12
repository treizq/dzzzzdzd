using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class PrimeNumbers
    {
        public IEnumerable<int> GetPrimes(int limit)
        {
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i))
                {
                    yield return i;
                }
            }
        }

        public IEnumerable<int> GetAllPrimes()
        {
            int number = 2;
            while (true)
            {
                if (IsPrime(number))
                {
                    yield return number; 
                }
                number++;
            }
        }

        public IEnumerable<int> SkipPrimes(int count)
        {
            int skipped = 0;
            foreach (var prime in GetAllPrimes())
            {
                if (skipped >= count)
                {
                    yield return prime;
                }
                skipped++;
            }
        }

        private bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}