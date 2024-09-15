using System

namespace Aula_05
{
	class Aula_05

	{

		static void Main(string[] args)
		{
			Pessoa obj = new Pessoa();
			obj.nome = "João";
			obj.idade = 20;
			obj.mensagem();
		}


	}


	class Pessoa
	{
		public string nome;
		public int idade;
		public void mensagem
		{

			Console.WriteLine("Olá, " + nome + " você tem " + idade + " anos.");
        }
}

}