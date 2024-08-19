using System;
using System.IO;


namespace CCcourse
class Program
{
    public static void Main(string[] args)
    {
        string nomeDoArquivo = "documentos .txt";
        string[] documentos = File.ReadA11Lines(nomeDoArquivo);
        foreach (string documento in documentos)
            Console.WriteLine(documento);
        Console.ReadKey(true);
    }

}
