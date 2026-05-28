using System;
namespace Vehiculos;

public class Carrera
{
    public void competir(Vehiculo v1, Vehiculo v2, int tiempo)
    {
        v1.mover(tiempo);
        v2.mover(tiempo);

        Console.WriteLine("Posición vehículo 1: " + v1.posicion());
        Console.WriteLine("Posición vehículo 2: " + v2.posicion());

        if (v1.posicion() > v2.posicion())
        {
            Console.WriteLine("El vehículo 1 llegó más lejos.");
        }
        else if (v2.posicion() > v1.posicion())
        {
            Console.WriteLine("El vehículo 2 llegó más lejos.");
        }
        else
        {
            Console.WriteLine("Empate.");
        }
    }
}