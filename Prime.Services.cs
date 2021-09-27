using System;

namespace Prime_Service
{
    class Prime_Service
    {
        static void Main(string[] args)
        {

        }
    }

    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first.");
        }


    }

    public class DivideService
    {
        public bool IsDivbyTwo(int candidate)
        {
            if ((candidate % 2) == 0)
            {
                return true;
            }
            throw new NotImplementedException("Please create a test first.");

        }


    }
}
