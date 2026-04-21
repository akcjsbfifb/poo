namespace ejercicio_03;

class Program
{
    static void Main()
    {
        IJugador amateur = new JugadorAmateur();
        IJugador profesional = new JugadorProfesional();

        Console.WriteLine("=== JUGADOR AMATEUR (limite: 20 min) ===");
        Console.WriteLine("Corre 15 min: " + amateur.Correr(15));
        Console.WriteLine("Corre 10 min: " + amateur.Correr(10));
        Console.WriteLine("Esta cansado: " + amateur.EstaCansado());
        
        Console.WriteLine("\n=== JUGADOR PROFESIONAL (limite: 40 min) ===");
        Console.WriteLine("Corre 35 min: " + profesional.Correr(35));
        Console.WriteLine("Corre 10 min: " + profesional.Correr(10));
        Console.WriteLine("Esta cansado: " + profesional.EstaCansado());
        
        Console.WriteLine("\n=== DESCANSAN ===");
        amateur.Descansar(10);
        profesional.Descansar(20);
        
        Console.WriteLine("Amateur cansado tras descanso: " + amateur.EstaCansado());
        Console.WriteLine("Profesional cansado tras descanso: " + profesional.EstaCansado());
        
        Console.WriteLine("\n=== VUELVEN A CORRER ===");
        Console.WriteLine("Amateur corre 5 min: " + amateur.Correr(5));
        Console.WriteLine("Profesional corre 10 min: " + profesional.Correr(10));
    }
}
