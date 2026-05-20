namespace ejercicio5;

public class CuentaCorriente : CuentaBancaria
{
    private decimal _descubierto;

    public CuentaCorriente(decimal descubierto)
    {
        _descubierto = descubierto;
    }

    protected override bool PuedeExtraer(decimal monto)
    {
        if (monto > Saldo + _descubierto)
        {
            Console.WriteLine("Limite de descubierto superado. Operacion rechazada.");
            return false;
        }
        return true;
    }
}
