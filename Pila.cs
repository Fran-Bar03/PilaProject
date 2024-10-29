using ProyectoPila;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPila
{
    internal class Pila
    {
        private int MAX;
        private int tope = 0;
        private Nodo inicio;
        public Pila(int max)
        {
            MAX = max;
            inicio = null;
        }

        public bool Empty()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        public bool Full()
        {
            if (tope == MAX)
                return true;
            else
                return false;
        }

        public void PrintStack()
        {

            if (Empty()) 
            {
                Console.WriteLine("La pila esta vacia");

            }

          Nodo actual = inicio;

            while (actual != null)
            {
                Console.WriteLine($"{actual.Valor}");
                actual = actual.Sig;
            }





            //Imprime la pila
        }

        public bool Push(int num)
        {
            if (Full()) 
            {
                Console.WriteLine("La pila esta llena");
                return false;
                
            }

         Nodo nuevo = new Nodo(num);

            if (Empty())
            {
                inicio = nuevo;
            }

            else
            {
                nuevo.Sig = inicio;
                inicio = nuevo;
            }

            tope++;
            return true;


            //regresa true si la inserccion es exitosa
            //regresa false si la píla esta llena y no se inserto
        }

        public int Pop()
        {
            if (Empty()) 
            {
                Console.WriteLine("No se puedo eliminar, lista vacia");
                return -1;
            }

            int ValorE = inicio.Valor;

            inicio = inicio.Sig;

            tope--;

            Console.WriteLine($"El numero sacado de la pila : {ValorE}");

            return ValorE;
            



            //regresa el numero sacado de la pila
            //si la pila esta vacia regresa -1
        }


    }
}