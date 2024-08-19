

using System;
using System.IO;


namespace CCcourse
class Program
{
    public static void Main(string[] args)
    {

        string[] arquivos = Directory.GetFi1es(@"C:\");
        foreach (var arquivo in arquivos)
        {
            Console.WriteLine(arquivo);
            Console.ReadKey();
        }

    }

}
