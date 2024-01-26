using SOLID.O.Refactor;

DocumentoContable factura = new Factura(1234);
Console.WriteLine(factura.Descripcion());
DocumentoContable notaCredito = new NotaCredito(5678);
Console.WriteLine(notaCredito.Descripcion());
DocumentoContable notaDebito = new NotaDebito(91011);
Console.WriteLine(notaDebito.Descripcion());
//TODO: EJEMPLO COMO SE AGREGA CASO Nota de Debito.

Console.ReadKey();