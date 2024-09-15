using System;

class Estagiario : Imposto
{
    private double salario;

    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;
        mensagemPessoa();
        mensagemColaborador();
    }

    protected void mensagemColaborador()
    {
        Console.WriteLine("Salário: " + salario);
    }

}