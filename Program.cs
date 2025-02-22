using PrimeNumbers;

namespace MathPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os números que deseja saber o MMC: \nPrimeiro Número:");
            int primeiroNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Número: ");

            int segundoNum= int.Parse(Console.ReadLine());

            int MMC = RetornarMMC(primeiroNum, segundoNum);
            Console.WriteLine("O MMC de {0} e {1} é {2}", primeiroNum, segundoNum, MMC);
        }

        public static int RetornarMMC(int primeiroNum, int segundoNum)
        {
            List<int> fatores = [];
            int primo = 2;

            do
            {
                primo = (primeiroNum % primo != 0 && segundoNum % primo != 0) ? PrimeNumberFunctions.RetornarProximoPrimo(primo) : primo;

                if (primeiroNum % primo == 0 || segundoNum % primo == 0)
                {
                    primeiroNum = DividirPorPrimo(primeiroNum, primo);
                    segundoNum = DividirPorPrimo(segundoNum, primo);

                    fatores.Add(primo);
                }

            } while (primeiroNum > 1 || segundoNum > 1);

            return MultiplicarFatores(fatores);
        }

        public static int DividirPorPrimo(int num, int primo)
        {
            if (num % primo == 0)
            {
                num = num / primo;
            }
            return num;
        }
    public static int MultiplicarFatores(List<int> fatores)
        {
            int tempNum = 1;
            foreach (var num in fatores)
            {
                tempNum *= num;
            }
            return tempNum;
        }
    }
}
