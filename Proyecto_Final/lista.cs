using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class lista
    {
        nodo inicio;
        public lista()
        {
            inicio = null;
        }

        public void Add(int num)
        {
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
        }
        public void Print()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                nodo act;
                act = inicio;
                while (act != null)
                {
                    Console.Write($"{act.Valor} => ");
                    act = act.Sig;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public int Find(int pos)
        {
            if (inicio == null || pos < 0)
            {
                return -1;
            }

            int indice = 0;
            nodo act = inicio;

            while (act != null)
            {
                if (indice == pos)
                {
                    return act.Valor;
                }
                act = act.Sig;
                indice++;
            }
            return -1;
        }

        public int Count()
        {
            if (inicio == null)
            {
                return 0;
            }
            nodo act = inicio;
            int conta = 0;

            while (act != null)
            {
                conta++;
                act = act.Sig;
            }

            return conta;
        }

        public int FindValue(int num)
        {
            if (inicio == null)
            {
                return -1;
            }

            nodo act = inicio;

            int pos = 0;
            while (act != null)
            {
                if (act.Valor == num)
                {
                    return pos;
                }
                act = act.Sig;
                pos++;
            }
            return -1;
        }

        public bool Change(int pos, int num)
        {
            if (inicio == null)
                return false;

            nodo act = inicio;
            int indice = 0;

            while (act != null)
            {
                if (indice == pos)
                {
                    act.Valor = num;
                    return true;
                }

                act = act.Sig;
                indice++;
            }

            return false;
        }

        public bool Delete(int pos)
        {
            if (inicio == null)
            {
                return false;
            }

            if (pos == 0)
            {
                inicio = inicio.Sig;
                return true;
            }

            nodo act = inicio;
            int indice = 0;

            while (act.Sig != null)
            {
                if (indice == pos - 1)
                {
                    act.Sig = act.Sig.Sig;
                    return true;
                }

                act = act.Sig;
                indice++;
            }

            return false;
        }
    }
}
