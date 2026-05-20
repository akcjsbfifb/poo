namespace ejercicio5;

public class Banco
{
    private List<CuentaBancaria> _cuentas = new List<CuentaBancaria>();

    public void AgregarCuenta(CuentaBancaria cuenta)
    {
        _cuentas.Add(cuenta);
    }

    public void Transferir(CuentaBancaria origen, CuentaBancaria destino, decimal monto)
    {
        if (!_cuentas.Contains(origen))
        {
            Console.WriteLine("Transferencia rechazada: la cuenta origen no esta registrada en el banco.");
            return;
        }
        if (!_cuentas.Contains(destino))
        {
            Console.WriteLine("Transferencia rechazada: la cuenta destino no esta registrada en el banco.");
            return;
        }
        if (monto <= 0)
        {
            Console.WriteLine("Transferencia rechazada: el monto debe ser positivo.");
            return;
        }
        if (!origen.Extraer(monto))
        {
            Console.WriteLine("Transferencia rechazada: la cuenta origen no pudo realizar la extraccion.");
            return;
        }
        destino.Depositar(monto);
        Console.WriteLine("Transferencia realizada con exito.");
    }
}
