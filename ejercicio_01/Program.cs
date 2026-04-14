namespace ejercicio_01;

class Semaforo
{
    private string colorActual;
    private int segundosEnColor;
    private bool intermitente;
    private int segundosIntermitente;

    public Semaforo(string colorInicial)
    {
        colorActual = colorInicial;
        segundosEnColor = 0;
        intermitente = false;
        segundosIntermitente = 0;
    }

    public void pasoDelTiempo(int segundos)
    {
        if (intermitente)
        {
            segundosIntermitente += segundos;
        }
        else
        {
            segundosEnColor += segundos;
            while (true)
            {
                int duracion = getDuracionColor(colorActual);
                if (segundosEnColor >= duracion)
                {
                    segundosEnColor -= duracion;
                    colorActual = getSiguienteColor(colorActual);
                }
                else
                {
                    break;
                }
            }
        }
    }

    private int getDuracionColor(string color)
    {
        switch (color)
        {
            case "Rojo": return 30;
            case "RojoAmarillo": return 2;
            case "Verde": return 20;
            case "Amarillo": return 2;
            default: return 0;
        }
    }

    private string getSiguienteColor(string color)
    {
        switch (color)
        {
            case "Rojo": return "RojoAmarillo";
            case "RojoAmarillo": return "Verde";
            case "Verde": return "Amarillo";
            case "Amarillo": return "Rojo";
            default: return "Rojo";
        }
    }

    public void mostrarColor()
    {
        if (intermitente)
        {
            int estado = segundosIntermitente % 2;
            if (estado == 0)
            {
                Console.WriteLine("Amarillo (intermitente)");
            }
            else
            {
                Console.WriteLine("Apagado (intermitente)");
            }
        }
        else
        {
            if (colorActual == "RojoAmarillo")
            {
                Console.WriteLine("Rojo + Amarillo");
            }
            else
            {
                Console.WriteLine(colorActual);
            }
        }
    }

    public void ponerEnIntermitente()
    {
        intermitente = true;
        segundosIntermitente = 0;
    }

    public void sacarDeIntermitente()
    {
        intermitente = false;
        segundosEnColor = 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Semaforo semaforo = new Semaforo("Verde");

        Console.WriteLine("Estado inicial:");
        semaforo.mostrarColor();

        semaforo.pasoDelTiempo(10);
        Console.WriteLine("\nDespues de 10 segundos:");
        semaforo.mostrarColor();

        semaforo.pasoDelTiempo(11);
        Console.WriteLine("\nDespues de 21 segundos totales:");
        semaforo.mostrarColor();

        semaforo.pasoDelTiempo(5);
        Console.WriteLine("\nDespues de 27 segundos totales:");
        semaforo.mostrarColor();

        Console.WriteLine("\n=== Probando modo intermitente ===");
        semaforo.ponerEnIntermitente();

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Segundo {i}: ");
            semaforo.mostrarColor();
            semaforo.pasoDelTiempo(1);
        }

        Console.WriteLine("\nSaliendo de intermitente...");
        semaforo.sacarDeIntermitente();
        semaforo.mostrarColor();

        Console.WriteLine("\n=== Fin de prueba ===");
    }
}
