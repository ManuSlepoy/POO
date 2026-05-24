using System;
namespace banco;

public class Banco
{

    private List<CuentaBancaria> cuentas = new List<CuentaBancaria>();

    public void agregarCuenta(CuentaBancaria cuenta)
    {
        cuentas.Add(cuenta);
        cuenta.registrado = true;
    }

    public void transferir(CuentaBancaria origen, CuentaBancaria destino, int monto)
    {
        if (origen.registrado == true && destino.registrado == true)
        {
            if (monto > 0) { 
                if (origen.extraer(monto))
                {
                    destino.depositar(monto);
                    Console.WriteLine("Transferencia exitosa.");
                }
            }
            else
            {
                Console.WriteLine("El monto debe ser positivo.");
            }
        }
        else
        {
            Console.WriteLine("Ambas cuentas deben estar registradas en el banco.");
        }
    }
}