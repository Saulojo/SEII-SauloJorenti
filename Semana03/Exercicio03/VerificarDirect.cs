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
            Console.WriteLine("O diret�rio existe");
        }
        else
        {
            Console.WriteLine("O diret�rio n�o existe");
        }
        Console.ReadKey(true);
    }

}
