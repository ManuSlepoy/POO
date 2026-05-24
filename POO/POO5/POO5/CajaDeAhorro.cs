using System;

public class CajaDeAhorro : CuentaBancaria
{
    public override bool extraer(int monto)
    {
        if (monto <= saldo)
        {
            saldo = saldo - monto;
            return true;
        }
        else
        {
            Console.WriteLine("No se puede extraer el monto solicitado porque supera el saldo");
            return false;
        }

    }
}