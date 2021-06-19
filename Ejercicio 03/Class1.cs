using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_03
{
    class funciones
    {
        public static int ReadInt()
        {
            int num;
            string arr;
            arr = Console.ReadLine();
            num = Convert.ToInt32(arr);

            return num;

        }
        public static void calcular(double a)
        {
            double aResultado = Math.Abs(a);
            Console.WriteLine("Valor Absoluto:" + aResultado);
            aResultado =Math.Pow(a, 2);
            Console.WriteLine("Cuadrado:" + aResultado);
            aResultado = Math.Sqrt(a);
            Console.WriteLine("Raiz Cuadrada:" + aResultado);
            aResultado = Math.Sin(a);
            Console.WriteLine("Seno:" + aResultado);
            aResultado = Math.Cos(a);
            Console.WriteLine("Coseno:" + aResultado);
            aResultado=Math.Truncate(aResultado);
            Console.WriteLine("Parte entera :" + aResultado);
        }
        
    }
}

