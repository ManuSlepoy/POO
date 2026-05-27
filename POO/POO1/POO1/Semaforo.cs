using System;
using System.Security.Cryptography.X509Certificates;
namespace semaforo;

public class Semaforo
{
    public string color;
    public int sec;
    public bool intermitente;
    public bool cambio;

    public Semaforo(string colorInicio)
    {
        color = colorInicio;
        sec = 0;
        intermitente = false;
        cambio = true;
    }

    public void pasoDelTiempo(int segundos)
    {
        for (int i = 0; i < segundos; i++)
        {
            if (intermitente)
            {
                cambio = !cambio;
            }
            else
            {
                sec++;
                switch (color)
                {
                    case "Rojo":
                        if (sec == 30)
                        {
                            color = "Rojo + Amarillo";
                            sec = 0;
                        }
                        break;
                    case "Rojo + Amarillo":
                        if (sec == 2)
                        {
                            color = "Verde";
                            sec = 0;
                        }
                        break;
                    case "Verde":
                        if (sec == 20)
                        {
                            color = "Amarillo";
                            sec = 0;
                        }
                        break;
                    case "Amarillo":
                        if (sec == 2)
                        {
                            color = "Rojo";
                            sec = 0;
                        }
                        break;
                }
            }
        }
    }
    public void mostrarColor()
    {
        if (intermitente)
        {
            if (cambio)
            {
                Console.WriteLine("Amarillo");
            }
            else
            {
                Console.WriteLine("Apagado");
            }

        }
        else
        {
            Console.WriteLine(color);
        }
    }

    public void ponerEnIntermitente()
    {
        intermitente = true;
        cambio = true;
    }

    public void sacarDeIntermitente()
    {
        intermitente = false;
        sec = 0;
    }

}