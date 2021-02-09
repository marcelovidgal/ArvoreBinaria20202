using System;

namespace ArvoreBinaria
{
	class ProgramaArvoreBinaria
	{
		static void Main(string[] args)
		{
			Console.WriteLine("arvore binaria!");

			ArvoreBinaria arvoreBinaria = new ArvoreBinaria();
			
			/*
			// parte 1
			arvoreBinaria.CriarArvore();
			arvoreBinaria.Exibir();
			Console.WriteLine();

			Console.WriteLine("pre-ordem: ");
			arvoreBinaria.PercorrerPreOrdem();
			Console.WriteLine();

			Console.WriteLine("em ordem: ");
			arvoreBinaria.PercorrerEmOrdem();
			Console.WriteLine();

			Console.WriteLine("pos-ordem: ");
			arvoreBinaria.PercorrerPosOrdem();
			Console.WriteLine();

			Console.WriteLine("ordenado por nivel: ");
			arvoreBinaria.PercorrerOrdemPorNivel();
			Console.WriteLine();
			
			Console.WriteLine("altura da arvore: " + ab.ObterAltura());
			*/

			// parte 2
			arvoreBinaria.Inserir('A');
			arvoreBinaria.Exibir();

			arvoreBinaria.Inserir('B');
			arvoreBinaria.Inserir('C');
			arvoreBinaria.Inserir('D');
			arvoreBinaria.Exibir();

			arvoreBinaria = new ArvoreBinaria();
			arvoreBinaria.Inserir('C');
			arvoreBinaria.Exibir();

			arvoreBinaria.Inserir('A');
			arvoreBinaria.Inserir('B');
			arvoreBinaria.Inserir('D');
			arvoreBinaria.Inserir('E');
			arvoreBinaria.Exibir();

			arvoreBinaria = new ArvoreBinaria();
			arvoreBinaria.Inserir('C');
			arvoreBinaria.Inserir('D');
			arvoreBinaria.Inserir('A');
			arvoreBinaria.Inserir('B');
			arvoreBinaria.Inserir('E');
			arvoreBinaria.Exibir();

			Console.WriteLine(arvoreBinaria.GetValorMinimo());
			Console.WriteLine(arvoreBinaria.GetValorMaximo());
			arvoreBinaria.PercorrerEmOrdem();

			//arvoreBinaria.Remover('A');
			arvoreBinaria.Remover('C');

			arvoreBinaria.PercorrerEmOrdem();

			// parte 3

			// parte 4

		}
	}
}