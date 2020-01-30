using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculemos su tarifa de Compensación Familiar:");
            Console.WriteLine("Ingrese su salario:");
            double salario = double.Parse(Console.ReadLine());

            if (salario < 1755606)
            {
                Console.WriteLine("Usted pertenece a la Tarifa A");
            }
             else if(1755606<=salario && salario <= 3511212)
            {
                Console.WriteLine("Usted pertenece a la Tarifa B");
            }
            else{
                Console.WriteLine("Usted pertenece a la Tarifa C");
            }
        }
    }
}
