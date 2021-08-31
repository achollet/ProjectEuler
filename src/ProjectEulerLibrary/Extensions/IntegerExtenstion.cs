namespace ProjectEulerLibrary.Extensions
{
    public static class IntegerExtenstion
    {
        public static bool IsMultipleOf(this int source, int value)
            => source % value == 0;

        public static bool IsEven(this int source)
            => source % 2 != 0;

        public static bool IsPrimeNumber(this int source) 
        {
            bool isPrime = true;

            if (source == 1 || source == 2)
                return true;

            for (int i = 2; i < source; i++)
            {
                if (source.IsMultipleOf(i))
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}
