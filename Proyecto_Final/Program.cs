using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int modeGeneral;
            do
            {
                Console.WriteLine("-------MENÚ PROYECTO FINAL-------");
                Console.WriteLine("1.- Listas.\n2.- Pilas.\n3.- Colas.\n4.- Árboles.\n5.- Salir.");
                Console.Write("Seleccionar opción => ");
                modeGeneral = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------");
                Console.WriteLine();

                switch (modeGeneral)
                {
                    //LISTAS
                    case 1:
                        int modeL;
                        int valorL;
                        int posL;
                        lista Lista = new lista();

                        do
                        {
                            Console.WriteLine("-----MENÚ LISTAS-----");
                            Console.WriteLine("------------------------");
                            Console.WriteLine("1.- Insertar nodo.\n2.- Imprimir tamaño.\n3.- Buscar nodo.\n4.- Borrar nodo.\n5.- Modificar nodo.\n6.- Buscar valor.\n7.- Imprimir lista.\n8.- Regresar.");
                            Console.WriteLine("------------------------");
                            Console.Write("Seleccionar opción => ");
                            modeL = int.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            switch (modeL)
                            {
                                case 1:
                                    int opcion = 0;

                                    Console.WriteLine("Introduzca el valor del nodo");
                                    int valor = int.Parse(Console.ReadLine());
                                    Lista.Add(valor);
                                    Console.WriteLine();


                                    break;

                                case 2:
                                    Console.WriteLine($"El número de nodos de la lista es: {Lista.Count()}");
                                    Console.WriteLine();
                                    break;

                                case 3:
                                    Console.Write("Ingrese la posición del nodo a buscar: ");
                                    int pos = int.Parse(Console.ReadLine());
                                    valorL = Lista.Find(pos);
                                    if (valorL != -1)
                                        Console.WriteLine($"El valor de la posición es: {valorL}");
                                    else
                                        Console.WriteLine("-1 posición vacía");
                                    break;

                                case 4:
                                    Console.WriteLine("Ingrese la posición del nodo que quiera eliminar");
                                    pos = int.Parse(Console.ReadLine());
                                    if (Lista.Delete(pos))
                                        Console.WriteLine("TRUE Eliminado");
                                    else
                                        Console.WriteLine("FALSE No eliminado");
                                    break;

                                case 5:
                                    Console.Write("Ingrese la posición del nodo a modificar: ");
                                    pos = int.Parse(Console.ReadLine());
                                    Console.Write("Ingrese el nuevo valor del nodo: ");
                                    int num = int.Parse(Console.ReadLine());
                                    if (Lista.Change(pos, num))
                                        Console.WriteLine("TRUE Modificado");
                                    else
                                        Console.WriteLine("FALSE No modificado");
                                    break;

                                case 6:
                                    Console.Write("Ingrese el valor del nodo que quiera buscar: ");
                                    pos = int.Parse(Console.ReadLine());
                                    posL = Lista.FindValue(pos);
                                    if (posL != -1)
                                        Console.WriteLine($"Posición del nodo es: {posL}");
                                    else
                                        Console.WriteLine("-1 valor no encontrado en la lista.");
                                    break;

                                case 7:
                                    Lista.Print();
                                    break;

                                case 8:
                                    Console.WriteLine("Saliendo al menú principal...");
                                    break;

                                default:
                                    Console.WriteLine("Opción no válida");
                                    break;
                            }
                        }
                        while (modeL != 8);

                        Console.WriteLine();
                        break;
                    //------------------------------------------------------------------
                    //PILAS
                    case 2:
                        int modeP;
                        pila pilaON = null;

                        do
                        {
                            Console.WriteLine("-------MENÚ PILAS-------");
                            Console.WriteLine("1.-Establecer tamaño\n2.- Push\n3.- Pop\n4.- Imprimir\n5.- Regresar");
                            Console.Write("Seleccionar opción => ");
                            modeP = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("----------------------------");
                            Console.WriteLine();

                            switch (modeP)
                            {
                                case 1:
                                    Console.WriteLine("Introduzca el TOPE de la pila");
                                    int tope = int.Parse(Console.ReadLine());
                                    pilaON = new pila(tope);
                                    Console.WriteLine();
                                    break;

                                case 2:
                                    if (pilaON == null)
                                    {
                                        Console.WriteLine(" Establecer TOPE primero");
                                        break;
                                    }
                                    Console.WriteLine("Ingrese el valor para realizar el PUSH");
                                    int valorPush = int.Parse(Console.ReadLine());
                                    pilaON.Push(valorPush);
                                    Console.WriteLine();
                                    break;

                                case 3:
                                    if (pilaON == null)
                                    {
                                        Console.WriteLine("Establecer TOPE primero");
                                        break;
                                    }

                                    int valorPop = pilaON.Pop();
                                    if (valorPop != -1)
                                    {
                                        Console.WriteLine($"Valor sacado de la pila: {valorPop}");
                                    }
                                    Console.WriteLine();
                                    break;

                                case 4:
                                    if (pilaON == null)
                                    {
                                        Console.WriteLine("Estalecer TOPE primero");
                                    }
                                    pilaON.PrintStack();
                                    Console.WriteLine();
                                    break;

                                case 5:
                                    Console.WriteLine("Saliendo al menú principal...");
                                    break;

                                default:
                                    Console.WriteLine("Opción NO válida");
                                    break;
                            }
                        } while (modeP != 5);

                        Console.WriteLine();
                        break;
                    //------------------------------------------------------------------
                    //COLAS
                    case 3:
                        int modeC;
                        cola colaON = null;

                        do
                        {
                            Console.WriteLine("----------MENÚ COLAS----------");
                            Console.WriteLine("1.- Establecer Tamaño\n2.- Count\n3.- Insert\n4.- Extract\n5.- Imprimir\n6.- Regresar");
                            Console.WriteLine("------------------------------");
                            Console.Write("Seleccionar opción => ");
                            modeC = Convert.ToInt32(Console.ReadLine());

                            switch (modeC)
                            {
                                case 1:
                                    Console.Write("Establecer el tamaño máximo de la cola: ");
                                    int valor = Convert.ToInt32(Console.ReadLine());
                                    colaON = new cola(valor);
                                    Console.WriteLine("Tamaño de la cola establecido.");
                                    break;

                                case 2:
                                    if (colaON == null)
                                    {
                                        Console.WriteLine("Primero debes establecer el tamaño de la cola.");
                                    }
                                    colaON.Count();
                                    break;

                                case 3:
                                    if (colaON == null)
                                    {
                                        Console.WriteLine("Primero debes establecer el tamaño de la cola.");
                                    }
                                    else
                                    {
                                        Console.Write("Ingrese el valor a insertar en la cola: ");
                                        valor = Convert.ToInt32(Console.ReadLine());
                                        if (colaON.Insert(valor))
                                        {
                                            Console.WriteLine("Valor insertado correctamente en la cola.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("La cola está llena. No se pudo insertar el valor.");
                                        }
                                    }
                                    break;

                                case 4:
                                    if (colaON == null)
                                    {
                                        Console.WriteLine("Primero debes establecer el tamaño de la cola.");
                                    }
                                    else
                                    {
                                        int valorExtraido = colaON.Extract();
                                        if (valorExtraido != -1)
                                        {
                                            Console.WriteLine($"Valor extraído de la cola: {valorExtraido}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("La cola está vacía. No se pudo extraer ningún valor.");
                                        }
                                    }
                                    break;

                                case 5:
                                    if (colaON == null)
                                    {
                                        Console.WriteLine("Primero debes establecer el tamaño de la cola.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Contenido de la cola:");
                                        colaON.Print();
                                    }
                                    break;

                                case 6:
                                    Console.WriteLine("Saliendo al menú principal...");
                                    break;

                                default:
                                    Console.WriteLine("Opción no válida, intenta nuevamente.");
                                    break;
                            }
                        } while (modeC != 6);

                        Console.WriteLine();
                        break;
                    //------------------------------------------------------------------
                    //ÁRBOLES
                    case 4:
                        arbol miArbolito = new arbol();
                        int modeA;

                        do
                        {
                            Console.WriteLine("-------MENÚ ÁRBOLES-------");
                            Console.WriteLine("1.- Insertar nodo\n2.- Tamaño\n3.- Altura\n4.- LRP\n5. Recorrido\n6.- Regresar");
                            Console.Write("Seleccionar opción => ");
                            modeA = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("----------------------------");
                            Console.WriteLine();

                            switch (modeA)
                            {
                                case 1:
                                    Console.Write("Ingrese el valor del nodo a insertar: ");
                                    int valor = Convert.ToInt32(Console.ReadLine());
                                    miArbolito.Insertar(valor);
                                    Console.WriteLine("Nodo insertado correctamente.\n");
                                    break;

                                case 2:
                                    int tamaño = miArbolito.Tamaño(miArbolito.raiz);
                                    Console.WriteLine($"El tamaño del árbol es: {tamaño}\n");
                                    break;

                                case 3:
                                    int altura = miArbolito.Altura(miArbolito.raiz);
                                    Console.WriteLine($"La altura del árbol es: {altura}\n");
                                    break;

                                case 4:
                                    Console.WriteLine("LRP");
                                    miArbolito.RecorridoLRP();
                                    Console.WriteLine("\n");
                                    break;

                                case 5:
                                    Console.WriteLine("Recorrido Inorden:");
                                    miArbolito.Recorrido(miArbolito.raiz);
                                    Console.WriteLine("\n");
                                    break;

                                case 6:
                                    Console.WriteLine("Saliendo al menú principal...");
                                    break;

                                default:
                                    Console.WriteLine("Opción no válida, intenta nuevamente.");
                                    break;
                            }
                        }while(modeA != 6);

                        Console.WriteLine();
                        break;
                    //------------------------------------------------------------------
                    //SALIR
                    case 5:
                        Console.WriteLine("Nos vemos pronto...");
                        break;
                    //------------------------------------------------------------------
                    default:
                        Console.WriteLine("Opción no válida, intenta nuevamente.");
                        break;
                }
            } while (modeGeneral != 5);
        }
    }
}
