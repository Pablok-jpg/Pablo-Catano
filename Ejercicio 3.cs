using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos.
            Console.WriteLine("Ingrese el valor del cateto Z:");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del ángulo C:");
            double c = double.Parse(Console.ReadLine());

            //Cálculo del ángulo A
            Console.WriteLine("Considerando el triángulo rectágulo, el valor del ángulo A es:");
            double a = 180 - (90 + c);
            Console.WriteLine(a);

            //Cálculo de T
            Console.WriteLine("El valor de la hipotenusa es:");
            double t = z / (Math.Sin(c));
            Console.WriteLine(t);

            //Cálculo de Y.
            Console.WriteLine("El valor del cateto Y es:");
            double y = z/(Math.Tan(c));
            Console.WriteLine(y);
        }
    }
}
