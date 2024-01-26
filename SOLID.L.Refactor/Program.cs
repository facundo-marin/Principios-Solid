using SOLID.L.Refactor;

Impresora impresora = new Impresora();

DocumentoContable factura = new Factura(1, DateTime.Now);
DocumentoContable notaCredito = new NotaCredito(2, DateTime.Now);
Remito remito = new Remito(3, DateTime.Now, 10);

//TODO: Crear nota de debito

impresora.Imprimir(factura);
impresora.Imprimir(notaCredito);
impresora.ImprimirRemito(remito);

Console.ReadKey();