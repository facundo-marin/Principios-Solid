using SOLID.S;

Factura factura = new Factura(2222, "Lopez", "Diego");

Item item1 = new Item(new Producto("Coca Cola", 10), 100);
Item item2 = new Item(new Producto("Pepsi", 5), 50);
Item item3 = new Item(new Producto("Sprite", 20), 75);

factura.Items.Add(item1);
factura.Items.Add(item2);
factura.Items.Add(item3);

factura.Imprimir();
//Console.WriteLine($"Total: {factura.Total()}");

Console.ReadLine();