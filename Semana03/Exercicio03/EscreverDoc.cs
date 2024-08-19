using System;
using System.IO;


namespace CCcourse
class Program
{
    public static void Main(string[] args)
    {
        string[] documentos = { "Documento 1.", "Documento 2." }
        string nomeDoArquivo = "documentos.txt" ;
        File.WriteAIILines(nomeDoArquivo, documentos);
        Console.WriteLine("O arquivo foi criado! ");
        Console.ReadKey(true);
    }

}
