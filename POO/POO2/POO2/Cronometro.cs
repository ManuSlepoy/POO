using System;
namespace cronometro;

public class Cronometro
{
    public int min, sec;
    public void reiniciar()
    {
        min = 0;
        sec = 0;
    }

    public void incrementarTiempo()
    {
        sec++;
        if (sec == 60)
        {
            sec = 0;
            min++;
        }
    }

    public string mostrarTiempo()
    {
        return $"{min:D2} minutos, {sec:D2} segundos";
    }
}