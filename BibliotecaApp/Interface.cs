using System;
using System.Collections.Generic;
using BibliotecaApp;

namespace Biblioteca
{
	//Parte não terminada
	
	class Interface
	{
		//Biblioteca biblioteca;

		public Interface()
		{
			Biblioteca biblioteca = new Biblioteca();
		}

		public void Menu()
		{
			int opcao = 0;
			do
			{
				Console.WriteLine("Menu:");
				Console.WriteLine("1 - Cadastrar Pessoa");
				Console.WriteLine("2 - Cadastrar Livro");
				Console.WriteLine("3 - Emprestar Livro");
				Console.WriteLine("4 - Devolver Livro");
				Console.WriteLine("5 - Listar todos os livros");
				Console.WriteLine("6 - Listar todas as pessoas cadastradas");
				Console.WriteLine("7 - Listar todos os livros emprestados");
				Console.WriteLine("0 - Sair");
				Console.Write("Escolha uma opção: ");

				if (int.TryParse(Console.ReadLine(), out opcao))
				{
					Console.WriteLine();

					switch (opcao)
					{
						case 1:
							CadastrarPessoa();
							break;
						case 2:
							CadastrarLivro();
							break;
						case 3:
							EmprestarLivro();
							break;
						case 4:
							DevolverLivro();
							break;
						case 5:
							ListarLivros();
							break;
						case 6:
							ListarPessoas();
							break;
						case 7:
							ListarLivrosEmprestados();
							break;
						case 0:
							Console.WriteLine("Saindo...");
							break;
						default:
							Console.WriteLine("Opção inválida. Tente novamente.");
							break;
					}
				}
				else
				{
					Console.WriteLine("Opção inválida. Tente novamente.");
				}

				Console.WriteLine();
			} while (opcao != 0);
		}

		public void CadastrarPessoa()
		{
			Console.WriteLine("Cadastro de Pessoa");
			Console.Write("Informe o Id: ");
			int id = int.Parse(Console.ReadLine());

			if (biblioteca.BuscarPessoa(id) != null)
			{
				Console.WriteLine("Pessoa já cadastrada");
				return;
			}

			Console.Write("Informe o Nome: ");
			string nome = Console.ReadLine();

			Console.Write("Informe o CPF: ");
			string cpf = Console.ReadLine();

			Console.Write("Informe o Telefone: ");
			string telefone = Console.ReadLine();

			Pessoa pessoa = new Pessoa(id, nome, cpf, telefone);
			biblioteca.CadastrarPessoa(pessoa);

			Console.WriteLine("Pessoa cadastrada com sucesso!");
		}

		public void CadastrarLivro()
		{
			Console.WriteLine("Cadastro de Livro");
			Console.Write("Informe o Id: ");
			int id = int.Parse(Console.ReadLine());

			if (biblioteca.BuscarLivro(id) != null)
			{
				Console.WriteLine("Livro já cadastrado");
				return;
			}

			Console.Write("Informe o Título: ");
			string titulo = Console.ReadLine();

			Console.Write("Informe o Autor: ");
			string autor = Console.ReadLine();

			Console.Write("Informe a Editora: ");
			string editora = Console.ReadLine();

			Console.Write("Informe a Quantidade de Exemplares: ");
			int quantidadeExemplares = int.Parse(Console.ReadLine());

			Livro livro = new Livro(id, titulo, autor, editora, quantidadeExemplares);
			biblioteca.CadastrarLivro(livro);

			Console.WriteLine("Livro cadastrado com sucesso!");
		}

		public void EmprestarLivro()
		{

		}

	}
}