using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, a, b;
            float result;
            do
            {
                do
                {
                    Console.WriteLine("----Opciones----\n Ingrese [1] para Suma \n Ingrese [2] para Resta \n Ingrese [3] para Division \n Ingrese [4] para Multiplicacion \n");
                    opcion = funciones.ReadInt();
                } while (opcion < 0 || opcion > 4);


                Console.WriteLine("Ingrese el primer numero");
                a = funciones.ReadInt();

                Console.WriteLine("Ingrese el segundo numero");
                b = funciones.ReadInt();


                switch (opcion)
                {
                    case 1:
                        result = a + b;
                        funciones.MostrarRes(result);
                        break;
                    case 2:
                        result = a - b;
                        funciones.MostrarRes(result);
                        break;
                    case 3:
                        while (b == 0)
                        {
                            Console.WriteLine("La division en 0 es absurda, cambie el valor.");
                            b = funciones.ReadInt();
                        }

                        result = (float)a / b;
                        funciones.MostrarRes(result);
                        break;
                    case 4:
                        result = a * b;
                        funciones.MostrarRes(result);
                        break;
                }
                do
	            {
                    Console.WriteLine("Quiere realizar otra operacion? Si[1], No [2]");
                    opcion=funciones.ReadInt();

	            } while (opcion<1|| opcion>2);
            } while (opcion==1);
            
            
        }
    }
}
