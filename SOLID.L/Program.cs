using SOLID.L;

Impresora impresora = new Impresora();

Remito remito = new Remito(1, DateTime.Now, 10);
Factura factura = new Factura(2, DateTime.Now);
NotaCredito notaCredito = new NotaCredito(3, DateTime.Now);

impresora.ImprimirRemito(remito);
impresora.ImprimirFactura(factura);
impresora.ImprimirNotaCredito(notaCredito);

//como vemos remito imprime diferente tiene otro comportamiento esto nos dice que por mas que comparta los mismos atributos no es lo mismo
//puede ser que remito sea otro tipo de documento, y el Documento actual haga referencia a documento contable.
Console.ReadKey();
