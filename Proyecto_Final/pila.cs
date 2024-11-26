using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class pila
    {
        private int MAX;
        private int tope = 0;
        private nodo inicio;

        public pila(int max)
        {
            MAX = max;
            inicio = null;
        }
        public bool Empty()
        {
            if (inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Full()
        {
            if (tope == MAX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PrintStack()
        {
            //imprime la pila
            if (Empty())
            {
                Console.WriteLine("La pila está vacía, inserte un valor");
                return;
            }

            nodo act = inicio;
            while (act != null)
            {
                Console.WriteLine(act.Valor);
                act = act.Sig;
            }
        }
        public bool Push(int num)
        {
            //regresa true si la insercion es exitosa
            //regresa false si la pila esta llena y no se inserto
            if (Full())
            {
                Console.WriteLine("FALSE: Pila LLENA");
                return false;
            }

            nodo sol = new nodo(num);
            sol.Sig = inicio;
            inicio = sol;
            tope++;
            Console.WriteLine("TRUE: inserción exitosa");
            return true;
        }
        public int Pop()
        {
            //regresa el numero sacado de la pila
            //si la pila esta vacia regresa -1
            if (Empty())
            {
                Console.WriteLine("La pila está vacía, inserte un valor");
                return -1;
            }

            int num = inicio.Valor;
            inicio = inicio.Sig;
            tope--;
            return num;
        }
    }
}
