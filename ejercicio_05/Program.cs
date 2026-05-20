using ejercicio5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== PRUEBA CAJA DE AHORRO ===\n");

        CajaDeAhorro ahorro = new CajaDeAhorro();
        ahorro.Depositar(1000);
        ahorro.Extraer(400);
        ahorro.Extraer(800);
        ahorro.MostrarSaldo();

        Console.WriteLine("\n=== PRUEBA CUENTA CORRIENTE ===\n");

        CuentaCorriente corriente = new CuentaCorriente(500);
        corriente.Depositar(200);
        corriente.Extraer(600);
        corriente.Extraer(200);
        corriente.MostrarSaldo();

        Console.WriteLine("\n=== PRUEBA BANCO Y TRANSFERENCIAS ===\n");

        Banco banco = new Banco();
        CajaDeAhorro ahorro2 = new CajaDeAhorro();
        CuentaCorriente corriente2 = new CuentaCorriente(500);

        banco.AgregarCuenta(ahorro2);
        banco.AgregarCuenta(corriente2);

        ahorro2.Depositar(1000);

        banco.Transferir(ahorro2, corriente2, 300);
        banco.Transferir(ahorro2, corriente2, 900);

        Console.WriteLine();
        ahorro2.MostrarSaldo();
        corriente2.MostrarSaldo();
    }
}
