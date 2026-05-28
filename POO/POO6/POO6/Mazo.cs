using System;
namespace Juego;

public class Mazo
{
    private List<Carta> cartas = new List<Carta>();
    private Random random = new Random();

    public Mazo()
    {
        string[] palos = { "Espada", "Basto", "Oro", "Copa" };

        foreach(string palo in palos)
        {
            for(int i = 1; i <= 12; i++)
            {
                cartas.Add(new Carta(palo, i));
            }
        }
    }

    public void barajar()
    {
        for(int i = 0; i < cartas.Count;  i++)
        {
            int j = random.Next(cartas.Count);

            Carta aux = cartas[i];
            cartas[i] = cartas[j];
            cartas[j] = aux;
        }
    }

    public Carta robarCarta()
    {
        if(cartas.Count == 0)
        {
            Console.WriteLine("El mazo está vacío");
            return null;
        }

        Carta carta = cartas[0];
        cartas.RemoveAt(0);

        return carta;
    }

    public int cuantasCartasQuedan()
    {
        return cartas.Count;
    }
}