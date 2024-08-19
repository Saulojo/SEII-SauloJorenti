using System;
using System.IO;


namespace CCcourse
class Program
{
    public static void Main(string[] args)
    {
        
        string nomeDoArquivo = "arquivo .txt"
        Console.WriteLine(File.Exists(nomeDoArquivo));
        File.WriteA11Text(nomeDoArquivo, "Algum texto");
        Console.WriteLine(File.Exists(nomeDoArquivo)) ;
        Console.ReadKey(true);

    }

}
