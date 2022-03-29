using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace listasdoblementeligadas
{
    public class listasdoblementeenlazada
    {
        Nodo PrimerNodo;
        Nodo UltimoNodo;
        Nodo NodoActual;
        public listasdoblementeenlazada()
        {
            PrimerNodo = null;
            UltimoNodo = null;
            NodoActual = null;
        }
        public bool EstaVacia()
        {
            return PrimerNodo == null;
        }
        public bool UnicoNodo()
        {
            return (PrimerNodo.ligasiguiente == null);
        }
        public string Agregar_Nodo_Al_Final()
        {
            int Dato;
            Console.WriteLine("ingrese el elemento que desea insertar");
            Dato = Convert.ToInt32(Console.ReadLine());
            Nodo NuevoNodo = new Nodo(Dato);
            if (EstaVacia())
            {
                PrimerNodo = NuevoNodo;
            }
            else
            {
                UltimoNodo.ligasiguiente = NuevoNodo;
                NuevoNodo.ligaanterior = UltimoNodo;
            }
            UltimoNodo = NuevoNodo;
            NodoActual = NuevoNodo;
            return "Dato ingresado satisfactoriamente" + Dato.ToString();
        }
                public string Recorrido_Hacia_Adelante()
        {
            int totaln = 0;
            string lista = "";
            Nodo Nodo_Aux = PrimerNodo;
            while (Nodo_Aux != null)
            {
                lista += Nodo_Aux.Dato + "-->>";
                Nodo_Aux = Nodo_Aux.ligasiguiente;
                totaln++;
            }
            Console.WriteLine("Los nodos en la lita son: {0}", totaln);
            lista += "Nulo";
            return lista;
        }
        public string Recorrido_Hacia_Atras()
        {
            int TotalNodos = 0;
            string Lista = "";
            Nodo Nodo_Aux = UltimoNodo;
            while (Nodo_Aux != null)
            {
                Lista += Nodo_Aux.Dato + "-->>";
                Nodo_Aux = Nodo_Aux.ligaanterior;
                TotalNodos++;
            }
            Lista += "Nulo";
            Console.WriteLine("El total de nodos son: {0}", TotalNodos);

            return Lista;
        }

        public void Forma_Circular()
        {
            UltimoNodo.ligasiguiente = PrimerNodo;
            PrimerNodo.ligaanterior = UltimoNodo;
        }
        public void Deshacercircular()
        {

            UltimoNodo.ligasiguiente = null;
            PrimerNodo.ligaanterior = null;
        }
        public string Eliminar_Nodo_Al_Final()
        {
            Nodo NodoSiguiente;
            Nodo NodoActual;
            NodoActual = PrimerNodo;
            NodoSiguiente = NodoActual.ligasiguiente;
            if (!EstaVacia())
            {
                if (UnicoNodo())
                {
                    PrimerNodo = null;
                }
                else
                {
                    while (NodoSiguiente.ligasiguiente != null)
                    {
                        NodoActual = NodoSiguiente;
                        NodoSiguiente = NodoSiguiente.ligasiguiente;
                    }
                    NodoSiguiente = null;
                    NodoActual.ligasiguiente = null;
                }
            }
            else { return "Lista Vacia"; }
            return "Elemetno eliminado";
        }
        public string Eliminar_Al_Inicio_RECORRIENDO_HACIA_ATRAS()
        {
            Nodo NodoSiguiente;
            Nodo NodoActual;
            NodoActual = UltimoNodo;
            NodoSiguiente = NodoActual.ligaanterior;
            if (!EstaVacia())
            {
                if (UnicoNodo())
                {
                    PrimerNodo = null;
                }
                else
                {
                    while (NodoSiguiente.ligaanterior != null)
                    {
                        NodoActual = NodoSiguiente;
                        NodoSiguiente = NodoSiguiente.ligaanterior;
                    }
                    NodoSiguiente = null;
                    NodoActual.ligaanterior = null;
                }
            }
            else { return "Esta Vacia"; }
            return "eliminado";
        }
        public string Eliminar_Nodo_Al_Incio()
        {
            Nodo NodoAuxiliar;
            NodoAuxiliar = PrimerNodo;
            if (!EstaVacia())
            {
                if (UnicoNodo())
                {
                    PrimerNodo = null;
                }
                else
                {
                    NodoAuxiliar = PrimerNodo;
                    PrimerNodo = NodoAuxiliar.ligasiguiente;
                    PrimerNodo.ligaanterior = null;
                }
            }
            else { return "ESTA VAcia"; }
            return "eliminado";
        }
        public string Eliminar_Nodo_Antes_De_Valor_Especifico()
        {
            int ValorNodo;
            Nodo NodoAuxiliar;
            Nodo NodoActual;
            Nodo NodoSiguiente;
            if (!EstaVacia())
            {
                if (UnicoNodo())
                {
                    int Respuesta;
                    Console.WriteLine("hay un solo nodo en la lista lo desea eliminar ? ");
                    Console.WriteLine(" Si = 1 No = 0");
                    Respuesta = Convert.ToInt32(Console.ReadLine());
                    if (Respuesta == 1)
                    {
                        PrimerNodo = null;

                    }
                    if (Respuesta == 2)
                    {
                        return "no se elimino";
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese el Valor del nodo de referencia que desea eliminar");
                    ValorNodo = Convert.ToInt32(Console.ReadLine());
                    if (PrimerNodo.Dato == ValorNodo)
                    {
                        Console.WriteLine("El valor que dio es el valor del primer nodo");
                        return "No se elimino ningun Nodo";
                    }
                    else
                    {
                        NodoActual = PrimerNodo;
                        NodoSiguiente = NodoActual.ligasiguiente;
                        NodoAuxiliar = NodoActual;
                        if (NodoSiguiente.Dato == ValorNodo)
                        {
                            //SE PUEDE UTILIZAR EL METODO DE ELIMINAR AL INICIO*****
                            NodoAuxiliar = NodoSiguiente;
                            NodoSiguiente = NodoSiguiente.ligasiguiente;
                            NodoActual.ligasiguiente = NodoSiguiente;
                            NodoSiguiente.ligaanterior = NodoActual;
                            NodoAuxiliar = null;
                        }
                        else
                        {
                            while (NodoSiguiente.Dato != ValorNodo)
                            {
                                NodoAuxiliar = NodoActual;
                                NodoActual = NodoActual.ligasiguiente;
                                NodoSiguiente = NodoSiguiente.ligasiguiente;
                            }
                            NodoAuxiliar.ligasiguiente = NodoSiguiente;
                            NodoSiguiente.ligaanterior = NodoAuxiliar;
                            NodoActual = null;
                        }
                        return "Elemento Eliminado";
                    }
                }

            }
            else { return "Esta Vacia"; }
            return "";
        }
        public string Eliminar_Nodo_Despues_De_Valor_Especifico()
        {
            int ValorNodo;
            Nodo NodoAuxiliar;
            Nodo NodoActual;
            Nodo NodoSiguiente;
            if (!EstaVacia())
            {
                if (UnicoNodo())
                {
                    PrimerNodo = null;
                }
                else
                {
                    Console.WriteLine("Ingrese el Valor del nodo de referencia que desea eliminar");
                    ValorNodo = Convert.ToInt32(Console.ReadLine());
                    NodoActual = PrimerNodo;
                    NodoSiguiente = NodoActual.ligasiguiente;
                    NodoAuxiliar = NodoSiguiente.ligasiguiente;
                    while (NodoActual.Dato != ValorNodo)
                    {
                        NodoActual = NodoActual.ligasiguiente;
                        NodoSiguiente = NodoSiguiente.ligasiguiente;
                        NodoAuxiliar = NodoSiguiente.ligasiguiente;
                    }
                    NodoActual.ligasiguiente = NodoAuxiliar;
                    NodoAuxiliar.ligaanterior = NodoActual;
                    NodoSiguiente = null;
                }
            }
            else { return "Esta Vacia"; }
            return "Elemetno eliminado";
        }
        public string Eliminar_Un_Valor_Especifico()
        {
            int ValorNodo;
            Nodo NodoAuxiliar;
            Nodo NodoActual;
            Nodo NodoSiguiente;
            if (!EstaVacia())
            {
                if (UnicoNodo())

                {
                    PrimerNodo = null;
                }
                else
                {
                    Console.WriteLine("Ingrese el Valor del nodo que desea eliminar");
                    ValorNodo = Convert.ToInt32(Console.ReadLine());
                    NodoActual = PrimerNodo;
                    NodoSiguiente = NodoActual.ligasiguiente;
                    NodoAuxiliar = NodoActual;
                    if (PrimerNodo.Dato == ValorNodo)
                    {
                        Eliminar_Nodo_Al_Incio();

                        //
                    }
                    if (UltimoNodo.Dato == ValorNodo)
                    {
                        Eliminar_Nodo_Al_Final();
                    }
                    else
                    {
                        while (NodoActual.Dato != ValorNodo)
                        {
                            NodoAuxiliar = NodoActual;
                            NodoActual = NodoActual.ligasiguiente;
                            NodoSiguiente = NodoSiguiente.ligasiguiente;
                        }
                        NodoAuxiliar.ligasiguiente = NodoSiguiente;
                        NodoSiguiente.ligaanterior = NodoAuxiliar;
                        NodoActual = null;
                    }
                    if (UltimoNodo.Dato == ValorNodo)

                    {
                        Console.WriteLine("El nodo que eliminara es el ultimo nodo");
                        NodoActual = UltimoNodo;
                        NodoSiguiente = NodoActual.ligaanterior;
                        NodoSiguiente.ligasiguiente = null;
                        NodoActual = null;
                        UltimoNodo = NodoSiguiente;
                    }
                }
            }
            else { return "Esta Vacia"; }
            return "";
        }
    }


}

