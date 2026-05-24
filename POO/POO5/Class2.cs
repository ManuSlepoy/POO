using System;
namespace banco;

public class CajaDeAhorro : CuentaBancaria
{
    public override void extraer(int monto)
    {
        if (monto <= saldo)
            saldo = saldo - monto;
        else
            Console.WriteLine("No se puede extraer el monto solicitado. Saldo insuficiente.");

    }
}