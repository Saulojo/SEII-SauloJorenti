using System;

class Pessoa
{
    public double peso, altura;

    public double calculo()
    {
        return peso / (altura * altura);
    }

    public string situacao(double imc)
    {
        string retorno
        if (imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if (imc < 24.9)
        {
            retorno = "Peso normal";
        }
        else if (imc < 29.9)
        {
            retorno = "Sobrepeso";
        }
        else if (imc < 34.9)
        {
            retorno = "Obesidade grau 1";
        }
        else if (imc < 39.9)
        {
            retorno = "Obesidade grau 2";
        }
        else
        {
            retorno = "Obesidade grau 3";
        }
    }

    public void mensagem()
    {
        double imc = calculo();
        string situacao = situacao(imc);
        Console.WriteLine("IMC: " + imc);
        Console.WriteLine("Situação: " + situacao);
    }
}