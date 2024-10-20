
using System.Diagnostics;

namespace exercicio02{
    class Program{

        static void Main(string [] args){
            Stopwatch sw = new Stopwatch();
            sw.Start();
            executarComTasks();
            sw.Stop();
            System.Console.WriteLine("demorou: "+sw.ElapsedMilliseconds+" milissegundos");

        }
        static void realizarOP(int op, string nome, string sobrenome){
            Console.WriteLine($"inicando operação "+op+"...");
            for (int i = 0; i < 1000000000; i++)
            {
                var p = new Pessoa(nome,sobrenome,35);
            }

            Console.WriteLine($"finalizando operação "+op+"...");

        }
        static void executarLinear(){
            realizarOP(1,"jefinho","da Silva");
            realizarOP(2,"Jacinto","Pinto");
            realizarOP(3,"Carol","Marcones");
        }
        static void executarComThreads(){

            var t1 = new Thread(()=>{
                    realizarOP(1,"Saulo","da Silva");
            });
            var t2 = new Thread(()=>{
                    realizarOP(2,"Gomes","Linda");
            });
            var t3 = new Thread(()=>{
                    realizarOP(3,"Xeila","Carla");
            });
            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join();
            t2.Join();
            t3.Join();
        }
        static void executarComTasks(){
            var t1 =  Task<int>.Run(()=>{
                    realizarOP(1,"Saulo","da Silva");
                    return 1;
            });
            var t2 =  Task<int>.Run(()=>{
                    realizarOP(2,"Gomes","Linda");
                    return 2;
            });
            var t3 =  Task<int>.Run(()=>{
                    realizarOP(3,"Xeila","Carla");
                    return 3;
            });
            System.Console.WriteLine("Task "+t1.Result+" Finalizou");
            System.Console.WriteLine("Task "+t2.Result+" Finalizou");
            System.Console.WriteLine("Task "+t3.Result+" Finalizou");

        }



}

}