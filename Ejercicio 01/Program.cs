using System;
namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, ultimoDig;
            do
            {
                Console.WriteLine("Ingrese un numero Mayor y diferente que 0");
                num = funciones.ReadInt();
            } while ((num < 0) || (num == 0));

            while (num > 0)
            {
                ultimoDig = num % 10;
                Console.Write(ultimoDig);
                num /= 10;
            }
        }


    }
}
