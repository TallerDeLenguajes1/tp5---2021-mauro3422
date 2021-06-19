using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_02
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
        public static void MostrarRes(float res)
        {
            Console.WriteLine("El resultado es:"+res);
        }
    }
}

