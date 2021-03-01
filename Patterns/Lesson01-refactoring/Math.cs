namespace Lesson01_refactoring
{
    internal class Math
    {
        internal static long Factorial(int num)
        {
            long result = 1;

            for (int i = 1; i <= num; i++)
            {
                if (long.MaxValue / result < i)
                {
                    result = -1;
                    break;
                }
                else
                {
                    result *= i;
                }
            }

            return result;
        }

        internal static int Sum(int num)
        {
            int result = 0;

            for (int i = 1; i <= num; i++)
            {
                result += i;
            }

            return result;
        }

        internal static int MaxEven(int num)
        {
            int result = num - 1;

            if (result % 2 != 0)
                result--;

            return result;
        }

    }
}
