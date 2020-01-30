using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculemos su Cuota Moderadora:");
            Console.WriteLine("Ingrese su salario:");
            double salario = double.Parse(Console.ReadLine());

            if (salario < 1755606)
            {
                Console.WriteLine("Usted pertenece a la Tarifa A (3.400)");
            }
            else if (1755606 <= salario && salario <= 4389015)
            {
                Console.WriteLine("Usted pertenece a la Tarifa B (13.500)");
            }
            else
            {
                Console.WriteLine("Usted pertenece a la Tarifa C (35.600)");
            }
        }
    }
}
