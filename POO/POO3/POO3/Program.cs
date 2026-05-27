using System;
namespace jugadores;

class Program
{
    static void Main()
    {
        Amateur amateur = new Amateur();
        Profesional profesional = new Profesional();

        Console.WriteLine("AMATEUR");

        amateur.correr(30);
        amateur.cansado();

        amateur.correr(30);
        amateur.cansado();

        amateur.descansar(10);
        amateur.cansado();

        amateur.correr(5);

        Console.WriteLine("PROFESIONAL");

        profesional.correr(30);
        profesional.cansado();

        profesional.correr(15);
        profesional.cansado();

        profesional.descansar(20);
        profesional.cansado();

        profesional.correr(10);
    }
}