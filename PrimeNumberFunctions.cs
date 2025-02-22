namespace PrimeNumbers
{
    public static class PrimeNumberFunctions
    {
        public static int RetornarProximoPrimo(int num = 1)
        {
            if (num < 1)
            {
                num = 1;
            }

            do
            {
                num++;
            } while (!ValidarNumeroPrimo(num));

            return num;
        }

        public static bool ValidarNumeroPrimo(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void LogarPrimos(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (!ValidarNumeroPrimo(i))
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public static void LogarMaiorPrimo(int num)
        {
            for (int i = num; i > 2; i--)
            {
                if (!ValidarNumeroPrimo(i))
                {
                    continue;
                }
                Console.WriteLine(i);
                break;
            }
        }
    }
}
