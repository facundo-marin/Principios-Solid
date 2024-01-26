using SOLID.D;

Impresora impresora = new Impresora();

Factura factura = new Factura(1234, DateTime.Now, 3000);
NotaCredito notaCredito = new NotaCredito(123444, DateTime.Now, 4000);
Remito remito = new Remito(4555, DateTime.Now, 40);
FacturaLuz facturaLuz = new FacturaLuz(4555, "1321313");
Municipal municipal = new Municipal(458978, "1321313");

impresora.Imprimir(factura);
impresora.Imprimir(notaCredito);
impresora.Imprimir(remito);
impresora.Imprimir(facturaLuz);
impresora.Imprimir(municipal);

Console.ReadKey();