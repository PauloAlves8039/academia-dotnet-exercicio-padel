﻿using Academia.DotNet.DesafioPadel.Exercicio.Business;
using Academia.DotNet.DesafioPadel.Exercicio.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Exercício Padel *****");

        List<AtletaPadel> listaDeAtletas = new List<AtletaPadel>();
        List<TreinadorPadel> listaDeTreinadores= new List<TreinadorPadel>();

        string opcaoDeEntrada = "";

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Padel");
            Console.WriteLine("1 - Cadastrar Atleta");
            Console.WriteLine("2 - Listar Atletas");
            Console.WriteLine("3 - Remover Atleta");
            Console.WriteLine("4 - Cadastrar Treinador");
            Console.WriteLine("5 - Listar Treinadores");
            Console.WriteLine("6 - Remover Treinador");
            Console.WriteLine("7 - Sair");
            Console.Write("Opção: ");
            opcaoDeEntrada = Console.ReadLine();

            switch (opcaoDeEntrada)
            {
                case "1":
                    Console.WriteLine("Cadastro de atleta");
                    AtletaBusiness.CadastrarAtleta(listaDeAtletas);
                    break;
                case "2":
                    Console.WriteLine("Listagem de atletas");
                    AtletaBusiness.ListarAtletas(listaDeAtletas);

                    break;
                case "3":
                    Console.WriteLine("Remoção de atleta");
                    AtletaBusiness.RemoverAtleta(listaDeAtletas);
                    break;
                case "4":
                    Console.WriteLine("Cadastro de treinador");
                    TreinadorBusiness.CadastrarTreinador(listaDeTreinadores);
                    break;
                case "5":
                    Console.WriteLine("Listagem de treinadores");
                    TreinadorBusiness.ListarTreinadores(listaDeTreinadores);
                    break;
                case "6":
                    Console.WriteLine("Remoção de treinador");
                    TreinadorBusiness.RemoverTreinador(listaDeTreinadores);
                    break;
                case "7":
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.Write("Tecle ENTER para continuar.....");
            Console.ReadKey(true);
        }
        while (opcaoDeEntrada != "7");

        Console.ReadKey();
    }
}