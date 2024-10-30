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
                        Console.WriteLine("");
                        Console.WriteLine("");

                        if (max > 0) 
                    {
                        Mipila = new Pila(max);
                    }
                    else
                    {
                        Console.WriteLine("Introduzca un tamaño de pila mayor a 0");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                    break;

                case 2:

                        if (Mipila == null)
                        {
                            Console.WriteLine("Introduzca un tamaño de pila primeramente");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        else 
                        { 
                        Console.WriteLine("Ingresa el numero a insertar");
                    int num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Mipila.Push(num);
                        }
                        break;

                    case 3:

                        if (Mipila == null)
                        {
                            Console.WriteLine("Introduzca un tamaño de pila primeramente");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        else 
                        { 

                        int res =  Mipila.Pop();
                            Console.WriteLine("");
                        

                        }

                        break;

                    case 4:

                        if (Mipila == null)
                        {
                            Console.WriteLine("Introduce el tamaño de la pila primero");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Mipila.PrintStack();
                        }
                   

                    break;

                    case 5:

                    Console.WriteLine("Saliendo....");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        break;

                    default:
                    Console.WriteLine("Introduzca una opcion valida");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;

                } 
                

            } while (op != 5);


        }
    }
}
