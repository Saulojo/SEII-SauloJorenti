using System

namespace Aula_13
{
    class Aula_13
    {
        static void Main(string[] args)
        {
            Imposto imposto = new Imposto();
            Gerente gerente = new Gerente();
            Atendente atendente = new Atendente();

            Estagiario estagiario = new Estagiario();
            estagiario.valeAlimentacao(1000);
            estagiario.valeTransporte(1000);
            gerente.valeAlimentacao(1000);
            atendente.valeAlimentacao(1000);
        }





    }

}