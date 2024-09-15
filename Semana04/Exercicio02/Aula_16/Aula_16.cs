using System

namespace Aula_16
{
    class Aula_16
    {
        static void Main(string[] args)
        {

        
            PessoaFiisica pf = new PessoaFisica();
            pf.taxaEmprestimo(1000);

            PessoaJuridica pj = new PessoaJuridica();
            pj.taxaEmprestimo(1000);
        }
    }

}