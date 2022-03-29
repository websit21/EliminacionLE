
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace listasdoblementeligadas
{
    public class Nodo
    {
        public Nodo ligaanterior { get; set; }
        public int Dato { get; set; }
        public Nodo ligasiguiente { get; set; }
        public Nodo(int Dato)
        {
            ligaanterior = null;
            this.Dato = Dato;
            ligasiguiente = null;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            listasdoblementeenlazada lista = new listasdoblementeenlazada();
            int res;
            do
            {
                Console.Clear();
                Console.WriteLine("--------------LISTAS DOBLEMENTE LIGADAS------------------\n\n");
                Console.WriteLine("\n\t1. INSERCION DE NODOS");
                Console.WriteLine("\n\t2. ELIMINACION DE NODOS");
                Console.WriteLine("\n\t3. RECORRIDO HACIA ADELANTE");
                Console.WriteLine("\n\t5. SALIR");
                Console.WriteLine("\nSELECCIONE UNA OPCION");
                res = Convert.ToInt32(Console.ReadLine());
                switch (res)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("----------------INSERCION NODOS------------\n\n");
                        Console.WriteLine("\n\t1. INSERTAR NODO");
                        Console.WriteLine("\n\t2. REGRESAR AL MENU PRINCIPAL");
                        Console.WriteLine("\t\t\t SELECCIONE UNA OPCION");
                        res = Convert.ToInt32(Console.ReadLine());
                        switch (res)
                        {
                            case 1:
                                Console.WriteLine(lista.Recorrido_Hacia_Adelante());
                                Console.WriteLine("\t\t --------INSERTAR AL INICIO------ - ");
                                Console.WriteLine(lista.Agregar_Nodo_Al_Final());
                                Console.WriteLine(lista.Recorrido_Hacia_Adelante());
                                break;
                           
                           
                            case 2:
                        break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\t\t-------------ELIMINADO NODOS---------- - ");
                        Console.WriteLine("\n\t1. ELIMINAR AL INICIO");
                        Console.WriteLine("\n\t2. ELIMINAR AL FINAL");
                        Console.WriteLine("\n\t3. ELIMINAR UN ELEMENTO ANTES DE UN DATO X");
                        Console.WriteLine("\n\t4. ELIMINAR UN ELEMENTO DESPUÉS DE UN DATO X");
                        Console.WriteLine("\n\t5. ELIMINAR UN NODO EN UNA POSICIÓN ESPECÍFICA");
                        Console.WriteLine("\n\t6. REGRESAR AL MENU PRINCIPAL");
                        Console.WriteLine("\t\t\t SELECCIONE UNA OPCION");
                        res = Convert.ToInt32(Console.ReadLine());
                        switch (res)
                        {
                            case 1:
                                Console.WriteLine(lista.Recorrido_Hacia_Adelante());
                                Console.WriteLine("\t\tELIMINAR AL INICIO");
                                Console.WriteLine(lista.Eliminar_Nodo_Al_Incio());
                                Console.WriteLine(lista.Recorrido_Hacia_Adelante());
                                break;
                            case 2:
                                Console.WriteLine(lista.Recorrido_Hacia_Adelante());
                                Console.WriteLine("\t\tELIMINAR AL FINAL");
                                Console.WriteLine(lista.Eliminar_Nodo_Al_Final());
                                Console.WriteLine(lista.Recorrido_Hacia_Adelante());
                                break;
                            case 3:
                                Console.WriteLine(lista.Recorrido_Hacia_Adelante());
                                Console.WriteLine("\t\tELIMINAR UN NODO ANTES DE UN VALOR DADO COMO REFERENCIA");
                                Console.WriteLine(lista.Eliminar_Nodo_Antes_De_Valor_Especifico());
                        Console.WriteLine(lista.Recorrido_Hacia_Adelante());
                                break;
                            case 4:
                                Console.WriteLine(lista.Recorrido_Hacia_Adelante());
                                Console.WriteLine("\t\tEliminar NODO DESPUES DE UN VALOR DADO COMO REFERENCIA");
                                Console.WriteLine(lista.Eliminar_Nodo_Despues_De_Valor_Especifico());
                                Console.WriteLine(lista.Recorrido_Hacia_Adelante());
                                break;
                            
                            case 5:
                                Console.WriteLine(lista.Recorrido_Hacia_Adelante());
                                Console.WriteLine("ELIMINAR NODO CON VALOR ESPECIFICO");
                                Console.WriteLine(lista.Eliminar_Un_Valor_Especifico());
                                Console.WriteLine(lista.Recorrido_Hacia_Adelante());
                                break;
                            case 6:
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("\t\t\t--------RECORRIDO HACIA ADELANTE----------");
                        Console.WriteLine(lista.Recorrido_Hacia_Adelante());
                        break;
                   
                    case 4:
                        break;
                          }
                Console.WriteLine("CONTINUAR EN EL PROGRAMA SI = 1 NO = 0");
                res = Convert.ToInt32(Console.ReadLine());
            } while (res == 1);
        }
    }
}
