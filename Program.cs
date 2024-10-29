using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pila Mipila = null;
           int op = 0;
            do {
            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("|--------- PROYECTO PILAS ----------|");
            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("");
            Console.WriteLine("1.Insertar tamaño");
            Console.WriteLine("2.Push");
            Console.WriteLine("3.Pop");
            Console.WriteLine("4.Imprimir");
            Console.WriteLine("5.Salir");
            Console.WriteLine("");
            Console.WriteLine("Seleccionar opcion =>");
            op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");




                switch (op) 
            {
                case 1:
                    Console.WriteLine("Dame el numero a insertar");
                    int max = Convert.ToInt32(Console.ReadLine());

                    if(max > 0) 
                    {
                        Mipila = new Pila(max);
                    }
                    else
                    {
                        Console.WriteLine("Introduzca un tamaño de pila mayor a 0");
                    }

                    break;

                case 2:

                        if (Mipila == null)
                        {
                            Console.WriteLine("Introduzca un tamaño de pila primeramente");
                        }
                        else 
                        { 
                        Console.WriteLine("Ingresa el numero a insertar");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Mipila.Push(num);
                        }
                        break;

                    case 3:

                        if (Mipila == null)
                        {
                            Console.WriteLine("Introduzca un tamaño de pila primeramente");
                        }

                        else 
                        { 

                        int res =  Mipila.Pop();
                        

                        }

                        break;

                    case 4:

                    Mipila.PrintStack();

                    break;

                    case 5:

                    Console.WriteLine("Saliendo....");

                    break;

                    default:
                    Console.WriteLine("Introduzca una opcion valida");
                    break;

                } 


            } while (op != 5);


        }
    }
}
