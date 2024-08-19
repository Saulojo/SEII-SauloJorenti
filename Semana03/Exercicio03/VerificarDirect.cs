using System;
using System.IO;


namespace CCcourse
class Program
{
    public static void Main(string[] args)
    {

        string diretorio = "pasta";
        if (Directory.Exists(diretorio))
        {
            Console.WriteLine("O diretório existe");
        }
        else
        {
            Console.WriteLine("O diretório não existe");
        }
        Console.ReadKey(true);
    }

}
