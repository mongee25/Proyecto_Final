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

        
        public void RecorridoLRP()
        {
            Queue<nodoA> modeCola = new Queue<nodoA>();
            modeCola.Enqueue(raiz);

            int sumRecorrido = 0;
            double contRecorrido = 0;

            while (modeCola.Count > 0)
            {
                nodoA nodoActual = modeCola.Dequeue();
                nodoA sol = raiz;
                string recorrido = $"{sol.valor}";

                while (sol != nodoActual)
                {
                    if (nodoActual.valor < sol.valor)
                    {
                        sol = sol.izq;
                        recorrido = recorrido + $",{sol.valor}";
                    }
                    else
                    {
                        sol = sol.der;
                        recorrido = recorrido + $",{sol.valor}";
                    }
                }

                int cantNodos = recorrido.Split(',').Length;
                Console.WriteLine($"{recorrido} = {cantNodos}");

               sumRecorrido = sumRecorrido + cantNodos;
                

                if (nodoActual.izq != null) modeCola.Enqueue(nodoActual.izq);
                if (nodoActual.der != null) modeCola.Enqueue(nodoActual.der);
            }

            double promedio = sumRecorrido / contRecorrido;
            Console.WriteLine();
            Console.WriteLine($"Suma total de los recorridos: {sumRecorrido}");
            Console.WriteLine($"Cantidad de nodos: {contRecorrido}");
            Console.WriteLine($"LRP: {sumRecorrido}/{contRecorrido} = {promedio:F3}");
        }
    }
}
