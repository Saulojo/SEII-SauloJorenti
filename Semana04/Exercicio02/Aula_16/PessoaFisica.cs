using System;

class PessoaFisica: Padrao
{
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de empr�stimo para pessoa f�sica: " + (valor * 0.1));
    }
}
