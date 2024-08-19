using System;
using System.IO;


namespace CCcourse
class Program
{
    public static void Main(string[] args)
    {
        string nomeDoArquivo = "arquivo.txt";

        string texto = "Este é um documento de texto. ";
        File.WriteA11Text(nomeDoArquivo, texto);

        Console.WriteLine("Arquivo criado com sucesso!");
        Console.ReadKey(true);
    }

}
