using System;
namespace banco;

public class CuentaCorriente : CuentaBancaria
{
    private int limite;

    public CuentaCorriente(int limite)
    {
        this.limite = limite;
    }
    public override bool extraer(int monto)
    {
        if (monto <= limite + saldo)
        {
            saldo = saldo - monto;
            return true;
        }
        else
        {
            Console.WriteLine("No se puede extraer el monto solicitado porque supera el limite");
            return false;
        }
    }
}