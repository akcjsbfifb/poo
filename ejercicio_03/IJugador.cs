namespace ejercicio_03;

public interface IJugador
{
    bool Correr(int minutos);
    bool EstaCansado();
    void Descansar(int minutos);
}
