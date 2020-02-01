using System;
using System.Collections.Generic;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            var nonPrime = new List<int> {-1, 0 ,1 };

            if (nonPrime.Contains(candidate)) 
            { 
                return false;
            }

            throw new NotImplementedException("not implemented");
        }
    }
}
