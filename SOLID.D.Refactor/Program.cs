using SOLID.D.Refactor;
using SOLID.D.Refactor.Interface;

Impresora impresora = new Impresora();

IImprimible factura = new Factura(1234, DateTime.Now, 3000);
IImprimible notaCredito = new NotaCredito(123444, DateTime.Now, 4000);
IImprimible remito = new Remito(4555, DateTime.Now, 40);
IImprimible facturaLuz = new FacturaLuz(4555, "1321313");
IImprimible municipal = new Municipal(458978, "1321313");

impresora.Imprimir(factura);
impresora.Imprimir(notaCredito);
impresora.Imprimir(remito);
impresora.Imprimir(facturaLuz);
impresora.Imprimir(municipal);

Console.ReadKey();