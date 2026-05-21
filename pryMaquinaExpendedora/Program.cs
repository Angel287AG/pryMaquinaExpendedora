namespace pryMaquinaExpendedora
{
    internal class Expendedora
    {
        //atributos
        public string nombre;
        private int inventario;
        private double precio;

       
        //constructor
        public Expendedora(string nombre, double precio, int inventario)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.inventario = inventario;
        }
        public string nombredelproducto ()
        {
            return nombre;
        }
        public int Elinventario()
        {
            return inventario;
        }
        public double Elprecio()
        {
            return precio;
        }
        public void compras(int cantidad)
        {
            if (cantidad<= inventario)
            {
                double totaldelacompra = cantidad * precio;
                inventario = inventario - cantidad;

                Console.WriteLine("su compra fue realizada correctamente");

                Console.WriteLine("el total a pagar de la compra es de $" + totaldelacompra);
            }
            else
            {
                Console.WriteLine("no hay suficinte del producto en el invenventario");
            }

        }
        public void actualizarinventario(int cantidad)
        {
            int abastecimiento = 0;
            abastecimiento = abastecimiento + cantidad;
            Console.WriteLine("El inventario se acctualizo correctamente");
        }

    }
}
