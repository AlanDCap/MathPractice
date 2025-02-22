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


            if (num <= 1) return false;
            if (num <= 2) return true;
            if (num % 2 == 0 || num % 3 == 0) return false;

            /* Revisões do código feita por IA. 
             * Reduziu o tempo de execução de 2 min para 8 segundos, ao validar os primos de um a um milhão.
            
            Otimização com Incremento de 6:
            Ela itera apenas sobre números da forma 6k ± 1 (onde k é um inteiro). 
            Isso ocorre porque todos os números primos maiores que 3 podem ser expressos nessa forma.
            O loop for incrementa a variavel i de 6 em 6, ou seja, a variavel i sempre vai ser um número da forma 6k-1, e a expressão i+2 sempre vai ser um número da forma 6k+1.
            */
            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0) return false;
            }

            return true;
            //for (int i = 2; i < num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        return false;
            //    }
            //}
            //return true;
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
