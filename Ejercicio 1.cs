using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos.
            Console.WriteLine("Ingrese el valor de la hipotenusa:");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del ángulo A:");
            double a = double.Parse(Console.ReadLine());

            //Cálculo del ángulo C
            Console.WriteLine("Considerando el triángulo rectágulo, el valor del ángulo C es:");
            double c = 180 - (90 + a);
            Console.WriteLine(c);

            //Cálculo del Z.
            Console.WriteLine("El valor del cateto Z es:");
            double z= t*Math.Sin(c) *180/Math.PI;
            Console.WriteLine(z);

            //Cálculo de Y.
            Console.WriteLine("El valor del cateto Y es:");
            double y = z/(Math.Tan(c)) * (180 / Math.PI);
            Console.WriteLine(y);

        }
    }
}
