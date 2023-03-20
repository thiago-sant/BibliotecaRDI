using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp
{
	public class Pessoa
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Cpf { get; set; }
		public string Telefone { get; set; }
		public List<Livro> LivrosEmprestados { get; set; }

		public void AdicionarLivroLista (Livro livro)
		{
			LivrosEmprestados.Add(livro);
		}

		public void RemoverLivroLista(int idLivro)
		{
			LivrosEmprestados.RemoveAll(livro => livro.Id == idLivro);
		}

	}
}
