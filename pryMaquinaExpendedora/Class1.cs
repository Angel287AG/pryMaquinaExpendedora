using System;
using System.Collections.Generic;
using System.Text;

namespace pryMaquinaExpendedora
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string[,] productos =
            {
            {"agua ","20","10" },
            {"gancito ","18.5","10" },
            {"chocolate ","35","10" },
            {"coca cola ","29","10" }
            };
            int[] anchCol = { 15, 10, 10, };
            int opcion = 0;
            Console.WriteLine("bienvenido a la maquina expendedora");
            Console.WriteLine("seleccione el numero de movimiento");
            Console.WriteLine("1.ver productos");
            Console.WriteLine("2.comprar");
            Console.WriteLine("3.abastecer");
            Console.WriteLine("4.salir ");
            opcion = int.Parse(Console.ReadLine());
            
            if(opcion==1)
            { 
            
                for (int f=0;f<4;f++)
                {
                    
                        Console.Write(productos[f, 0]);
                    
                    Console.WriteLine();
                }

            }
        }
            
        
                
        
    }
}