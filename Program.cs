using Estoque;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;



internal class Program
{
    private static void Main(string[] args)
    {
        Produto p = new Produto();
        Console.WriteLine("Entre os dados do Produto");
        Console.Write("Nome do produto : ");
        p.Nome = Console.ReadLine();
        Console.Write("Preco : ");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantide no Estoque : ");
        p.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados do produto :" + p);

        Console.WriteLine();
        Console.WriteLine("Digite a quantidade de produtos a ser adicionado ");
        int qtde = int.Parse(Console.ReadLine());
        p.AdicionarProduto(qtde);

        Console.WriteLine("quantidade Atual :" + p);


        Console.WriteLine();
        Console.WriteLine("Digite a quantidade de produtos a ser removido do estoque ");
         qtde = int.Parse(Console.ReadLine());
        p.RemoverProduto(qtde);


        Console.WriteLine("quantidade Atual :" + p);

    }
}