using System;
namespace Juego;

public class Mano
{
    private List<Carta> cartas = new List<Carta>();

    public void recibirCarta(Carta carta)
    {
        cartas.Add(carta);
    }

    public void mostrarMano()
    {
        foreach(Carta carta in cartas)
        {
            Console.WriteLine(carta);
        }
    }

    public int cantidadDeCartas()
    {
        return cartas.Count;
    }
}