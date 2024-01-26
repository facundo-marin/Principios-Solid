using SOLID.O;

DocumentoContable factura = new DocumentoContable(TipoDocumentoContable.Factura, 1234);
Console.WriteLine(factura.Descripcion());
DocumentoContable notaCredito = new DocumentoContable(TipoDocumentoContable.NotaCredito, 5678);
Console.WriteLine(notaCredito.Descripcion());
DocumentoContable notaDebito = new DocumentoContable(TipoDocumentoContable.NotaDebito, 91011);
Console.WriteLine(notaDebito.Descripcion());
//TODO: EJEMPLO COMO SE AGREGA CASO Nota de Debito.
Console.ReadKey();

