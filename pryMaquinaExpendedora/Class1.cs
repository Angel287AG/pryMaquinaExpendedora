using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace pryMaquinaExpendedora
{
    // string paracel nombre por que es una cadena de letras 
    //el float en el precio es por que no todos los productos cuestan lo mismo ya que diferentes productos pueden tener costos decimales
    //el int en el inventario ya que no podemos poner solo un pedazo del producto,es decir no podemos vender medio gancito por lotanto tiene que ser entero
    internal class Class1
    {
        static void Main(string[] args)
        {

            Producto p1 = new Producto("agua", 20.0f, 10);
            Producto p2 = new Producto("gancito", 18.5f, 10);
            Producto p3 = new Producto("chocolate", 35.0f, 10);
            Producto p4 = new Producto("coca cola", 29.0f, 10);
            int opcion = 0;

            Producto[] productos = { p1, p2, p3, p4 };
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
                    Console.WriteLine("\n" + "producto".PadRight(15) + "precio".PadRight(10) + "inventario");
                    for (int i = 0; i < productos.Length; i++)
                    {
                        Console.WriteLine(productos[i].nombre.PadRight(15) + "$" + productos[i].precio.ToString().PadRight(10) + productos[i].inventario);
                    }
                }
                // Comprar
                else if (opcion == 2) 
                {
                    Console.Write("Seleccione producto (1,2,3,4): ");
                    int selecion = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Cantidad a comprar: ");
                    int cant = int.Parse(Console.ReadLine());

                    if (selecion >= 0 && selecion < 4)
                    {
                        productos[selecion].ProcesarCompra(cant);
                    }
                }
                // Abastecer
                else if (opcion == 3)
                {
                    Console.Write("Seleccione producto (1,2,3,4): ");
                    int selecion = int.Parse(Console.ReadLine()) - 1;
                    Console.Write("Cantidad a surtir: ");
                    int cant = int.Parse(Console.ReadLine());

                    if (selecion >= 0 && selecion < 4)
                    {
                       
                        productos[selecion].Surtirproducto(cant);
                    }
                }
            }
        
        }
    }
}