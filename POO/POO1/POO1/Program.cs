using System;
namespace semaforo;

class Program
{
    static void Main()
    {
        Semaforo semaforo = new Semaforo("Rojo");

        for (int i = 0; i < 60; i++)
        {
            semaforo.mostrarColor();
            semaforo.pasoDelTiempo(1);
        }

        semaforo.ponerEnIntermitente();

        for (int i = 0; i < 5; i++)
        {
            semaforo.mostrarColor();
            semaforo.pasoDelTiempo(1);
        }

        semaforo.sacarDeIntermitente();

        for (int i = 0; i < 10; i++)
        {
            semaforo.mostrarColor();
            semaforo.pasoDelTiempo(1);
        }
    }
}