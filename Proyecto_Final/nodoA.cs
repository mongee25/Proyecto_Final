using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class nodoA
    {
        public int valor;
        public nodoA izq;
        public nodoA der;

        public nodoA(int Valor)
        {
            valor = Valor;
            izq = null;
            der = null;
        }
    }
}
