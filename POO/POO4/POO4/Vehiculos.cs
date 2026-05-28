using System;
namespace Vehiculos;

public interface Vehiculo
{
    public void mover(int tiempo);
    public int posicion();
    public void reiniciarPosicion();
}

public class VehiculoX : Vehiculo
{
    public int mxs;
    public int pos = 0;
    public void mover(int tiempo)
    {
        pos += mxs * tiempo;
    }

    public int posicion()
    {
        return pos;
    }

    public void reiniciarPosicion()
    {
        pos = 0;
    }
}

public class Bicicleta : VehiculoX
{
    public Bicicleta()
    {
        mxs = 10;
    }
}

public class Camion : VehiculoX
{
    public Camion()
    {
        mxs = 30;
    }
}

public class Auto : VehiculoX
{
    public Auto()
    {
        mxs = 40;
    }

    public Auto(int vel)
    {
        mxs = vel;
    }
}