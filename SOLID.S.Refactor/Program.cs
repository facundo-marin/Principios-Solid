using SOLID.S.Refactor;

Cliente cliente = new Cliente("Lopez", "Diego");
Factura factura = new Factura(2222, cliente);
ImprimirFactura imprimirFactura = new ImprimirFactura();

Item item1 = new Item(new Producto("Coca Cola", 10), 100);
Item item2 = new Item(new Producto("Pepsi", 5), 50);
Item item3 = new Item(new Producto("Sprite", 20), 75);

factura.Items.Add(item1);
factura.Items.Add(item2);
factura.Items.Add(item3);

Console.WriteLine($"Total: {factura.Total()}");

imprimirFactura.Imprimir(factura);
Console.ReadKey();
