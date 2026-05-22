using System;
namespace pryMaquinaExpendedora;
public class Producto
{
    // float para precios con decimales para no confundirse y entenderlo con mas claridad
    //int para inventario (piezas enteras) un mejor entendimiento 
    //strin oara el nombre por que es una cadena de letras
    //en el encapsulamiento el Main no puede cambiar el inventario directamente
    //debe pasar por este método que valida si hay existencias 
    public string nombre;
    public float precio;
    public int inventario;

    public Producto(string nombre, float precio, int inventario)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.inventario = inventario;
    }

    //Compra
    public void ProcesarCompra(int cantidad)
    {
        if (cantidad > 0 && cantidad <= this.inventario)
        {
            float total = cantidad * this.precio;
            this.inventario = this.inventario- cantidad;
            Console.WriteLine("\nVenta exitosa: " + this.nombre);
            Console.WriteLine("Total a pagar: $" + total);
        }
        else
        {
            Console.WriteLine("No hay suficiente en el inventario");
        }
    }

    //rabastecer
    public void Surtirproducto(int cantidad)
    {
        this.inventario=this.inventario + cantidad;
        Console.WriteLine("inventario de " + this.nombre + " exitosa.");
    }
}

