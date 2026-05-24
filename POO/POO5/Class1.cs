using System;
namespace banco;

public class CuentaBancaria
{
    private int saldo;

    public virtual CuentaBancaria()
    {
        saldo = 0;
    }

    public void depositar(int monto)
    {
        if (monto > 0)
        {
            saldo += monto;
        }
    }

    public virtual void extraer(int monto)
        saldo = saldo - monto;

    public void mostrarSaldo()
    {
        Console.WriteLine("El saldo actual es: " + saldo);
    }
}