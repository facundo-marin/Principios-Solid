using SOLID.I.Refactor;

Factura factura = new Factura(112313, DateTime.Now);
factura.CAI = "123123123";

FacturaElectronica facturaElectronica = new FacturaElectronica(132563, DateTime.Now);
facturaElectronica.CAE = "14476893";

facturaElectronica.Imprimir();
facturaElectronica.EnviarPorEmail();

factura.Imprimir();

Console.ReadKey();