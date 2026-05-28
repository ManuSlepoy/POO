using System;
namespace Juego;

public class Carta
{
    public string Palo { get; }
    public int Valor { get; }

    public Carta(string palo, int valor)
    {
        Palo = palo;
        Valor = valor;
    }

    public override string ToString()
    {
        return Valor + " de " + Palo;
    }
}