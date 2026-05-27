using System;
namespace jugadores;

public interface JugadorI
{
    public bool correr(int minutos);
    public bool cansado();
    public void descansar(int minutos);
}

public class Jugador : JugadorI
{
    public int minC = 0;
    public int limite;

    public bool correr(int minutos)
    {
        if (cansado())
        {
            Console.WriteLine("El jugador está cansado, no puede correr");
            return false;
        }

        if(minC + minutos <= limite)
        {
            minC += minutos;
            Console.WriteLine("El jugador pudo correr");
            return true;
        }

        else
        {
            minC = limite;
            Console.WriteLine("El jugador se cansó mientras corria");
            return false;
        }
    }

    public bool cansado()
    {
        if (minC < limite)
        {
            Console.WriteLine("El jugador no está cansado");
            return false;
        }
        else
        {
            Console.WriteLine("El jugador está cansado");
            return true;
        }
    }

    public void descansar(int minutos)
    {
        minC -= minutos;
        Console.WriteLine("El jugador descansó " + minutos + " minutos");
    }
}

public class Amateur : Jugador
{
    public Amateur()
    {
        limite = 20;
    }
}

public class Profesional : Jugador
{
    public Profesional()
    {
        limite = 40;
    }
}