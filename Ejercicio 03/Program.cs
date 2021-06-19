using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b,resul;
            Console.WriteLine("Ingrese un numero:");
            a =(double) funciones.ReadInt();
            funciones.calcular(a);

               

            Console.WriteLine("Ingrese un nuevo numero:");
            a = (double)funciones.ReadInt();
            Console.WriteLine("Ingrese otro numero:");
            b = (double)funciones.ReadInt();

            resul=Math.Max(a, b);
            Console.WriteLine("El mayor:" + resul);
            resul=Math.Min(a, b);
            Console.WriteLine("El menor:" + resul);


        }
    }
}
