namespace ejercicio5;

public abstract class CuentaBancaria
{
    private decimal _saldo;

    protected decimal Saldo => _saldo;

    public void Depositar(decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("El monto a depositar debe ser positivo.");
            return;
        }
        _saldo += monto;
    }

    public bool Extraer(decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("El monto a extraer debe ser positivo.");
            return false;
        }
        if (!PuedeExtraer(monto))
            return false;
        _saldo -= monto;
        return true;
    }

    protected abstract bool PuedeExtraer(decimal monto);

    public void MostrarSaldo()
    {
        Console.WriteLine($"Saldo actual: ${_saldo}");
    }
}
