using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp
{
	public class Biblioteca
	{
		public List<Pessoa> Pessoas { get; set; }
		public List<Livro> Livros { get; set; }

		public void CadastrarPessoa(Pessoa pessoa)
		{
			if (Pessoas.Any(p => p.Id == pessoa.Id))
			{
				Console.WriteLine("Pessoa já cadastrada.");
				return;
			}
			Pessoas.Add(pessoa);
		}

		public void CadastrarLivro(Livro livro)
		{
			if (Livros.Any(l => l.id == livro.id))
			{
				Console.WriteLine("Livro já cadastrado.");
				return;
			}
			Livros.Add(livro);
		}

		public void EmprestarLivroBiblioteca(int idLivro, int idPessoa)
		{
			var pessoa = Pessoas.FirstOrDefault(p => p.Id == idLivro);
			if (pessoa == null)
			{
				Console.WriteLine("Pessoa não cadastrada.");
				return;
			}

			var livro = Livros.FirstOrDefault(l => l.Id == idLivro);
			if (livro == null)
			{
				Console.WriteLine("Livro não cadastrado.");
				return;
			}

			livro.EmprestarLivro(1);
			pessoa.AdicionarLivroLista(livro);
			Console.WriteLine($"O Livro {livro.Titulo} foi emprestado para a pessoa {pessoa.Nome}");
		}

		public void DevolverLivroBiblioteca(int idLivro, int idPessoa)
		{
			var pessoa = Pessoas.FirstOrDefault(p => p.Id == idPessoa);
			if (pessoa == null)
			{
				Console.WriteLine("Pessoa não cadastrada.");
				return;
			}

			var livro = pessoa.LivrosEmprestados.FirstOrDefault(l => l.Id == idLivro);
			if (livro == null)
			{
				Console.WriteLine("Livro não cadastrado.");
				return;
			}

			livro.DevolverLivro(1);
			pessoa.RemoverLivroLista(idLivro);
			Console.WriteLine($"O Livro {livro.Titulo} que estava com a pessoa {pessoa.Nome} foi devolvido.");
		}
	}

	}
}
