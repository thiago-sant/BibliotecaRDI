using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp
{
	 public class Livro
	{
		public int Id{ get; set; }
		public int Titulo{ get; set; }
		public int Autor{ get; set; }
		public int Editora{ get; set; }
		public int QuantidadeExemplares{ get; set; }

		public void EmprestarLivro(int quantidadeEmprestada)
		{
			if (quantidadeExemplares >= quantidadeEmprestada)
			{
				quantidadeExemplares -= quantidadeEmprestada;
				Console.WriteLine($"{quantidadeEmprestada} exemplare(s) do livro {titulo} foram emprestados.");
			}
			else
			{
				Console.WriteLine($"Não há exemplares suficientes do livro {titulo} para serem emprestadas.");
			}
		}

		public void DevolverLivro(int quantidadeDevolvida)
		{
			quantidadeExemplares += quantidadeDevolvida;
			Console.WriteLine($"{quantidadeDevolvida} exemplare(s) do livro {titulo} foram emprestados.");
		}
	}
}
