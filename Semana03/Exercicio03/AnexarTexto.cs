using System;
using System.IO;


namespace CCcourse
class Program
{
    public static void Main(string[] args)
    {
        string nomeDoArquivo = "documentos.txt";
        string conteudo = File.ReadA11Text(nomeDoArquivo);
       
        Console.WriteLine("conteudo do arquivo: " );
        Console.WriteLine(conteudo) ;
        File.AppendA11Text(nomeDoArquivo, "Um outro arquivo. ");
        conteudo = File.ReadA11Text(nomeDoArquivo);
        Console.ReadKey(true);

    }

}
