using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class cola
    {
        private nodo inicio;
        private int count;
        private int MAX;

        public cola(int max)
        {
            MAX = max;
            inicio = null;
        }

        private bool Underflow()
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

        private bool Overflow()
        {
            if (count == MAX)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Print()
        {
            if (Underflow())
            {
                Console.WriteLine("Cola vacia");
            }

            nodo impr = inicio;
            while (impr != null)
            {
                Console.Write(impr.Valor + " ");
                impr = impr.Sig;
            }
            Console.WriteLine();
        }
        public int Count()
        {
            nodo act = inicio;
            count = 0;

            while (act != null)
            {
                count++;
                act = act.Sig;
            }
            Console.WriteLine($"La cola tiene {count} elementos");
            return count;
        }
        public bool Insert(int num)
        {
            //regresa true al insertar exitosamente
            //regresa false si la cola esta llena y no se puedo insertar
            if (Overflow())
            {
                Console.WriteLine("FALSE: cola en estado Overflow");
                return false;
            }

            nodo nuevo = new nodo(num);

            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                nodo act = inicio;
                while (act.Sig != null)
                {
                    act = act.Sig;
                }
                act.Sig = nuevo;
            }

            count++;
            return true;
        }
        public int Extract()
        {
            //regresa el valor extraido de la cola
            //si la cola esta vacia regresa -1 porque no pudo extraer
            if (Underflow())
            {
                Console.WriteLine("FALSE: cola en estado Underflow");
                return -1;
            }

            int valorExt = inicio.Valor;
            inicio = inicio.Sig;
            count--;

            return valorExt;
        }
    }
}
