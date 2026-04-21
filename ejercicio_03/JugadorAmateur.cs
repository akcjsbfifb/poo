namespace ejercicio_03;

public class JugadorAmateur : IJugador
{
    private int minutosCorridos;
    private bool cansado;
    private const int MaximoMinutos = 20;

    public bool Correr(int minutos)
    {
        if (cansado)
        {
            return false;
        }
        
        int minutosRestantes = MaximoMinutos - minutosCorridos;
        
        if (minutos > minutosRestantes)
        {
            minutosCorridos = MaximoMinutos;
            cansado = true;
            return false;
        }
        
        minutosCorridos = minutosCorridos + minutos;
        return true;
    }

    public bool EstaCansado()
    {
        return cansado;
    }

    public void Descansar(int minutos)
    {
        minutosCorridos = minutosCorridos - minutos;
        
        if (minutosCorridos < 0)
        {
            minutosCorridos = 0;
        }
        
        if (minutosCorridos < MaximoMinutos)
        {
            cansado = false;
        }
    }
}
