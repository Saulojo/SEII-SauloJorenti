using System;

class Calculo: IPadrao
{
    public void somar(int n1, int n2)
    {
        Console.WriteLine("A soma dos valores �: " + (n1 + n2));
    }

    publiic void subtrair(int n1, int n2)
    {
        Console.WriteLine("A subtra��o dos valores �: " + (n1 - n2));
    }
}
