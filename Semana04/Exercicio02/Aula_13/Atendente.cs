using System;

class Atendente : Imposto
{
    public override void valeAlimentacao(double salario)
    {
        double desconto = salario * 0.12;
        Console.WriteLine("Desconto do gerente vale alimentação :R$ " + desconto);
    }

}