using System


class Pessoa
{
    public void apresentar1()
    {
        Console.WriteLine("Ol�!")
        }

    public void apresentar2(string nome)
    {
        Console.WriteLine("Ol�! Meu nome � " + nome);
    }

    public void apresentar3(string nome, int idade)
    {
        Console.WriteLine("Ol�! Meu nome � " + nome + " e tenho " + idade + " anos.");
    }

}