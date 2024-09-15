using System;

class Gerente : Imposto
{

    public override void valeAlimentacao(double salario)
    {
        double desconto = salario * 0.15;
        Console.WriteLine("Desconto do gerente vale alimentação :R$ " + desconto);
    }

}