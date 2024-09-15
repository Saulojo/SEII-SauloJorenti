using System


class Pessoa
{
    public void apresentar1()
    {
        Console.WriteLine("Olá!")
        }

    public void apresentar2(string nome)
    {
        Console.WriteLine("Olá! Meu nome é " + nome);
    }

    public void apresentar3(string nome, int idade)
    {
        Console.WriteLine("Olá! Meu nome é " + nome + " e tenho " + idade + " anos.");
    }

}