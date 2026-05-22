using System;
namespace pryMaquinaExpendedora;
public class Producto
{
       // float: para precios con decimales para no confundirse
       //int: para inventario (piezas enteras) un mejor entendimiento
       //Encapsulamiento: El Main no puede cambiar el stock directamente
       //debe pasar por este método que valida si hay existencias

    public static void ProcesarCompra(string[,] datos, int indice, int cantidad)
    {
        float precio = float.Parse(datos[indice, 1]);
        int stockActual = int.Parse(datos[indice, 2]);

        if (cantidad <= stockActual)
        {
            float total = cantidad * precio;
            datos[indice, 2] = (stockActual - cantidad).ToString();

            Console.WriteLine(" Venta exitosa. Cobro total: $" + total);
        }
        else
        {
            Console.WriteLine("\n No hay suficiente en el inventario");
        }
    }

    public static void Surtir(string[,] datos, int indice, int cantidad)
    {
        int stockActual = int.Parse(datos[indice, 2]);
        datos[indice, 2] = (stockActual + cantidad).ToString();
        Console.WriteLine("\nInventario actualizado por el proveedor.");
    }
}

