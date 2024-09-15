using System;

class Imposto
{
    public virtual void valeAlimentacao(double salario)
    {
        double desconto = salario * 0.1;
        Console.WriteLine("Desconto do vale alimentação :R$ " + desconto);
    }

    public void valeTransporte(double salario)
    {
        double desconto = salario * 0.06;
        Console.WriteLine("Desconto do vale transporte: R$" + desconto);
    }
}