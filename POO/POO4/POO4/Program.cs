using System;
namespace Vehiculos;

class Program
{
    static void Main()
    {
        Auto fiat = new Auto(45);
        Bicicleta bici = new Bicicleta();
        Camion camion = new Camion();
        bici.mover(20);
        Console.WriteLine(bici.posicion());
        bici.mover(10);
        Console.WriteLine(bici.posicion());
        bici.reiniciarPosicion();
        Carrera carrera = new Carrera();
        carrera.competir(bici, fiat, 20);
    }
}