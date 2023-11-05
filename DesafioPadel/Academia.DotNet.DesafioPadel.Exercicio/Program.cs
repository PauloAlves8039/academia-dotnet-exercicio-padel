using Academia.DotNet.DesafioPadel.Exercicio.Communications;
using Academia.DotNet.DesafioPadel.Exercicio.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        List<AtletaPadel> listaDeAtletas = new List<AtletaPadel>();
        List<TreinadorPadel> listaDeTreinadores= new List<TreinadorPadel>();

        string opcaoDeEntrada = "";

        do
        {
            Console.Clear();
            Console.WriteLine("******   Menu Padel   *******");
            Console.WriteLine("*   1 - Cadastrar Atleta    *");
            Console.WriteLine("*   2 - Listar Atletas      *");
            Console.WriteLine("*   3 - Remover Atleta      *");
            Console.WriteLine("*   4 - Cadastrar Treinador *");
            Console.WriteLine("*   5 - Listar Treinadores  *");
            Console.WriteLine("*   6 - Remover Treinador   *");
            Console.WriteLine("*   7 - Sair                *");
            Console.WriteLine("*****************************");
            Console.Write("\nOpção: ");
            opcaoDeEntrada = Console.ReadLine();

            switch (opcaoDeEntrada)
            {
                case "1":
                    Console.WriteLine("Cadastro de atleta");
                    ComunicacaoAtleta.CadastrarAtleta(listaDeAtletas);
                    break;
                case "2":
                    Console.WriteLine("Listagem de atletas");
                    ComunicacaoAtleta.ListarAtletas(listaDeAtletas);

                    break;
                case "3":
                    Console.WriteLine("Remoção de atleta");
                    ComunicacaoAtleta.RemoverAtleta(listaDeAtletas);
                    break;
                case "4":
                    Console.WriteLine("Cadastro de treinador");
                    ComunicaoTreinador.CadastrarTreinador(listaDeTreinadores);
                    break;
                case "5":
                    Console.WriteLine("Listagem de treinadores");
                    ComunicaoTreinador.ListarTreinadores(listaDeTreinadores);
                    break;
                case "6":
                    Console.WriteLine("Remoção de treinador");
                    ComunicaoTreinador.RemoverTreinador(listaDeTreinadores);
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