using System.Runtime.ConstrainedExecution;

namespace TratamentoExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Digite o Dividendo: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Divisor: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            divide(numero1, numero2);
        }

        public static void divide(int dividendo, int divisor)
        {
            Console.WriteLine("Divisão = " + (dividendo / divisor));
        }

    }
}