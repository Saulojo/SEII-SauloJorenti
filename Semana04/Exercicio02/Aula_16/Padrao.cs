using System;

abstract class Padrao
{
    public abstract void taxaEmprestimo(double valor);

    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Valor final: " + (valor + (valor * taxa)));
    }
}