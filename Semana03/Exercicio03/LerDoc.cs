using System;
using System.IO;


namespace CCcourse
class Program
{
    public static void Main(string[] args)
    {
        string arquivo =  "arquivo.txt";
        string texto = File.ReadA11Text(arquivo);
        Console.WriteLine("Conteúdo do arquivo");
        Console.ReadKe(true,1);
    }

}
