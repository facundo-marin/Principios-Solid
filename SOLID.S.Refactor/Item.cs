namespace SOLID.S.Refactor
{
    public class Item
    {
        //item ahora conoce el subtotal
        public Item(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public double Subtotal()
        {
            return Cantidad * Producto.Precio;
        } 
    }
}
