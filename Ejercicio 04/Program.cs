using System;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            string cad1, cad2, cad3;
            string[] vector;
            Random r = new Random();

            //Extraccion de caracteres/palabras y obtener el largo de una cadena.
            Console.WriteLine($"Ingrese una cadena de texto:");
            cad1 = "hola";
            int largo = cad1.Length;
            int numR = r.Next(0, largo);
            Console.WriteLine($"Caracter de la posicion {numR}:{cad1.Substring(numR, 1)}");
            Console.WriteLine($"Largo de la cadena {largo}");

            //Concatenacion.
            Console.WriteLine($"Ingrese otra cadena");
            cad2 = "como tas";

            cad3 = cad1 + " " + cad2;
            Console.WriteLine($"Concatenacion de la primer cadena y la segunda:{cad3}");


            Console.WriteLine($"Quiere ingresar a la calculadora? Si[1], No[0]");
            temp = funciones.ReadInt();
            if (temp == 1)
            {
                funciones.calculadora();
            }

            temp = 0;
            //Mostrar elementos de un string.
            foreach (var caracter in cad3)
            {

                Console.WriteLine($"Elemento numero[{temp}]:{caracter}");
                temp++;
            }
            //Transformo la cadena a minuscula.
            cad3 = cad3.ToLower();
            //Busqueda de palabra en cadena.
            Console.WriteLine($"-----Buscar Ocurrencia de UNA Palabra en la cadena-------");
            Console.WriteLine($"Buscar(si ingresa mas de una palabra, se usara la primera):");
            cad1 = Console.ReadLine();
            //Extraccion de cadenas
            //Extraigo las palabras y las separo si se encuentra algun espacio.
            vector = cad1.Split(" ");
            //Transformo la palabra en minuscula y la guardo en cad 1.
            cad1 = vector[0].ToLower();

            if ((cad3.IndexOf(cad1) >= 0))
            {
                vector = cad3.Split(" ");
                Console.WriteLine("Se encontro la palabra en la cadena!");
                //Muestro las subcadenas que tenia el string.
                foreach (var elemt in vector)
                {
                    Console.WriteLine($"Palabras en la cadena {elemt}");
                }
            }
            else
            {
                Console.WriteLine("No se encontro la palabra en la cadena! :[");
            }

            Console.WriteLine("--------Calculadora 2.0---------");


            Console.Write("Ingrese la operacion Ejemplo [X+X] :");
            cad2 = "2+2";
            if (cad2.Contains("+"))
            {
                vector = cad2.Split("+");
                Console.WriteLine(float.Parse(vector[0])+ float.Parse(vector[1]));
            }
            else
            {
                if (cad2.Contains("-"))
                {
                    vector = cad2.Split("-");
                    Console.WriteLine(float.Parse(vector[0]) - float.Parse(vector[1]));
                }
                else 
                {
                    if (cad2.Contains("*"))
                    {
                        vector = cad2.Split("*");
                        Console.WriteLine(float.Parse(vector[0]) * float.Parse(vector[1]));
                    }
                    else 
                    {
                        if (cad2.Contains("/"))
                        {
                            vector = cad2.Split("/");
                            Console.WriteLine(float.Parse(vector[0]) / float.Parse(vector[1]));
                        }
                        else
                        {
                            Console.WriteLine("No es una ecuacion.");
                        }
                    }
                }
            }



        }
    }
}
