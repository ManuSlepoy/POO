using System;

public class CuentaBancaria
{
    protected int saldo = 0;
    public bool registrado = false;

    public void depositar(int monto)
    {
        if (monto > 0)
        {
            saldo += monto;
        }
    }

    public virtual bool extraer(int monto)
    {
        saldo = saldo - monto;
        return true;
    }

    public void mostrarSaldo()
    {
        Console.WriteLine($"Saldo actual: " +saldo);
    }
}