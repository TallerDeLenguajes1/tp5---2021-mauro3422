using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_04
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
         public static void calculadora()
        {
            int opcion, a, b;
            float result;
            do
            {
                do
                {
                    Console.WriteLine("----Opciones----\n Ingrese [1] para Suma \n Ingrese [2] para Resta \n Ingrese [3] para Division \n Ingrese [4] para Multiplicacion \n");
                    opcion = ReadInt();
                } while (opcion < 0 || opcion > 4);


                Console.WriteLine("Ingrese el primer numero");
                a = ReadInt();

                Console.WriteLine("Ingrese el segundo numero");
                b = ReadInt();


                switch (opcion)
                {
                    case 1:
                        result = a + b;
                        Console.WriteLine($"La suma de {a} y de {b} es{result}");
                        break;
                    case 2:
                        result = a - b;
                        Console.WriteLine($"La resta de {a} y de {b} es{result}");
                        break;
                    case 3:
                        while (b == 0)
                        {
                            Console.WriteLine("La division en 0 es absurda, cambie el valor.");
                            b = funciones.ReadInt();
                        }

                        result = (float)a / b;
                        Console.WriteLine($"La division de {a} y de {b} es{result}");
                        break;
                    case 4:
                        result = a * b;
                        Console.WriteLine($"La multiplicacion de {a} y de {b} es{result}");
                        break;
                }
                do
                {
                    Console.WriteLine("Quiere realizar otra operacion? Si[1], No [2]");
                    opcion = funciones.ReadInt();

                } while (opcion < 1 || opcion > 2);
            } while (opcion == 1);


        }
    }
}
