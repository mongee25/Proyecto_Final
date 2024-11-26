using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class nodo
    {
        private int valor;
        private nodo sig;

        public nodo(int Valor)
        {
            this.Valor = Valor;
            sig = null;
        }

        public int Valor { get => valor; set => valor = value; }
        internal nodo Sig { get => sig; set => sig = value; }
    }
}
