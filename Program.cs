using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para converter uma temperatura digitada pelo usuário em °F para °C, digite: ");

            Console.WriteLine("a temperatura em°F: ");
            double f = Convert.ToDouble(Console.ReadLine());

            double resultado = (f - 32)/1.8; 

            Console.WriteLine($"A temperatura convertida dá: {resultado:N2} °F"); 
        }
    }
}
