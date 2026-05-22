using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace pryMaquinaExpendedora
{
    // strin oara el nombre por que es una cadena de letras 
    //el float en el precio es por que no todos los productos cuestan lo mismo ya que diferentes productos pueden tener costos decimales
    //el int en el inventario ya que no podemos poner solo un pedazo del producto,es decir no podemos vender medio gancito por lotanto tiene que ser entero
    internal class Class1
    {
        static void Main(string[] args)
        {
            
            string[,] productos = {
                // nombre del producto   precio    cantidad
                { "agua",               "20",        "10" },
                { "gancito",            "18.5",      "10" },
                { "chocolate",          "35",        "10" },
                { "coca cola",          "29",         "10" }
            };

            int opcion = 0;

            while (opcion != 4)
            {
                Console.WriteLine("\nselecione uno opcion");
                Console.WriteLine("1. Ver Vitrina");
                Console.WriteLine("2. Comprar");
                Console.WriteLine("3. Abastecer");
                Console.WriteLine("4. Salir");
                Console.Write("opcion=");
                opcion = int.Parse(Console.ReadLine());

                //vtrina
                if (opcion == 1)
                {
                    int[] ancho = { 15, 20, 10 };
                    Console.WriteLine("{0,-10}{1,-20}{2,-10}", "producto", "prcio","inventario");
                    for (int f = 0; f < productos.GetLength(0); f++)
                    {
                        for (int c = 0; c < productos.GetLength(1); c++)
                        {
                            Console.Write(productos[f, c].PadRight(ancho[c]));
                        }
                        Console.WriteLine();
                    }
                }
                //compra
                else if (opcion == 2)
                {
                    Console.Write("Seleccione producto (1-4): ");
                    int opciones= int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Cantidad a comprar: ");
                    int cant = int.Parse(Console.ReadLine());

                    if (opciones >= 0 && opciones < 4)
                    {

                        Producto.ProcesarCompra(productos, opciones, cant);
                    }
                }
                //actualizar inventario
                else if (opcion == 3)
                {
                    Console.Write("Seleccione producto (1-4): ");
                    int opciones = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Cantidad a surtir: ");
                    int cant = int.Parse(Console.ReadLine());

                    if (opciones >= 0 && opciones < 4)
                    {
                        Producto.Surtir(productos, opciones, cant);
                    }
                }
            }
        }
    }
}