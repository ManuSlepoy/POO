using System;
namespace cronometro;

class Program
{
    static void Main()
    {
        Cronometro cronometro = new Cronometro();
        for (int i = 0; i < 5000; i++)
        {
            cronometro.incrementarTiempo();
        }
        Console.WriteLine(cronometro.mostrarTiempo());
    }
}