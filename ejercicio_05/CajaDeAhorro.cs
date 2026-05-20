namespace ejercicio5;

public class CajaDeAhorro : CuentaBancaria
{
    protected override bool PuedeExtraer(decimal monto)
    {
        if (monto > Saldo)
        {
            Console.WriteLine("Saldo insuficiente. Operacion rechazada.");
            return false;
        }
        return true;
    }
}
