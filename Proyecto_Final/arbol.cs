using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class arbol
    {
        public nodoA raiz;
        private nodoA obs;

        public void Insertar(int v)
        {
            nodoA nuevo, psave;
            Boolean Found = false;
            psave = obs;
            Found = FindKey(v);
            if (Found)
            {
                Console.WriteLine("El nodo ya existe");
                obs = psave;
            }
            else
            {
                nuevo = new nodoA(v);
                if (raiz == null)
                {
                    raiz = nuevo;
                    obs = nuevo;
                }
                else
                {
                    if (v < obs.valor)
                    {
                        obs.izq = nuevo;
                    }
                    else
                    {
                        obs.der = nuevo;
                    }
                    obs = nuevo;
                }
            }
        }

        private bool FindKey(int v)
        {
            Boolean Found = false;
            nodoA q;
            q = raiz;
            while (!Found && q != null)
            {
                if (v == q.valor)
                {
                    obs = q;
                    Found = true;
                }
                else
                {
                    if (v < q.valor)
                    {
                        if (q.izq == null)
                        {
                            obs = q;
                        }
                        q = q.izq;
                    }
                    else
                    {
                        if (q.der == null)
                        {
                            obs = q;
                        }
                        q = q.der;
                    }
                }
            }
            return Found;
        }

        public void Recorrido(nodoA q)
        {
            if (q != null)
            {
                Console.Write($"{q.valor},");
                Recorrido(q.izq);

                Console.Write($"{q.valor},");
                Recorrido(q.der);
                Console.Write($"{q.valor},");
            }
        }

        public int Tamaño(nodoA q)
        {
            if (q == null)
                return 0;
            return 1 + Tamaño(q.izq) + Tamaño(q.der);
        }

        public int Altura(nodoA q)
        {
            if (q == null)
                return 0;
            int izquierda = Altura(q.izq);
            int derecha = Altura(q.der);
            return 1 + Math.Max(izquierda, derecha);
        }

        // Recorrido en Postorden (LRP)
        /*public void RecorridoLRP(nodoA q)
        {
            if (q != null)
            {
                RecorridoLRP(q.izq);
                RecorridoLRP(q.der);
                Console.Write($"{q.valor},");
            }
        }*/
        
        public void RecorridoLRP()
        {
            Queue<nodoA> Cola = new Queue<nodoA>();
            Cola.Enqueue(raiz);

            int sumaRecorridos = 0;
            double countRecorridos = 0;

            while (Cola.Count > 0)
            {
                nodoA nodoActual = Cola.Dequeue();
                nodoA temp = raiz;
                string recorrido = $"{temp.valor}";

                while (temp != nodoActual)
                {
                    if (nodoActual.valor < temp.valor)
                    {
                        temp = temp.izq;
                        recorrido = recorrido + $",{temp.valor}";
                    }
                    else
                    {
                        temp = temp.der;
                        recorrido = recorrido + $",{temp.valor}";
                    }
                }

                int cantidadNodos = recorrido.Split(',').Length;
                Console.WriteLine($"{recorrido} = {cantidadNodos}");

                sumaRecorridos += cantidadNodos;
                countRecorridos++;

                if (nodoActual.izq != null) Cola.Enqueue(nodoActual.izq);
                if (nodoActual.der != null) Cola.Enqueue(nodoActual.der);
            }

            double promedio = sumaRecorridos / countRecorridos;
            Console.WriteLine($"\nSuma total de recorridos: {sumaRecorridos}");
            Console.WriteLine($"Cantidad de nodos: {countRecorridos}");
            Console.WriteLine($"LRP {sumaRecorridos}/{countRecorridos} = {promedio:F3}");
        }
    }
}
