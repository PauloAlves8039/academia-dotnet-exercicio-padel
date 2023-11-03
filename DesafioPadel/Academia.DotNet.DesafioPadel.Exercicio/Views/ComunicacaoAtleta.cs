using Academia.DotNet.DesafioPadel.Exercicio.Models;
using Academia.DotNet.DesafioPadel.Exercicio.Utils;

namespace Academia.DotNet.DesafioPadel.Exercicio.Views
{
    public class ComunicacaoAtleta
    {
        public static void CadastrarAtleta(List<AtletaPadel> listaDeAtletas)
        {
            string email = "";
            string nome = "";
            DateOnly dataNascimento = new DateOnly();
            string posicaoQuadra = "";
            string categoria = "";

            bool emailValidado = false;
            bool nomeValidado = false;
            bool dataValidada = false;
            bool posicaoValidada = false;
            bool categoriaValidada = false;

            while (true)
            {
                if (!emailValidado)
                {
                    Console.Write("Informe o email: ");
                    email = Console.ReadLine();
                    emailValidado = Utilitario.ValidarFormatoDoEmail(email);

                    if (!emailValidado)
                    {
                        Console.WriteLine("Email inválido. Por favor, insira um email válido.");
                        continue;
                    }
                }

                if (Pessoa.EstaContido(email, listaDeAtletas))
                {
                    Console.WriteLine("Email já existe! Não é possível adicionar o atleta.");
                    Console.WriteLine("Por favor, verifique o email ou escolha outro.");
                    emailValidado = false;
                    continue;
                }


                if (!nomeValidado)
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine().ToUpper();
                    nomeValidado = Utilitario.ValidarNome(nome);

                    if (!nomeValidado)
                    {
                        Console.WriteLine("Nome inválido. Por favor, insira um nome válido.");
                        continue;
                    }
                }

                if (!dataValidada)
                {
                    Console.Write("Data nascimento [dd/mm/aaaa]: ");
                    string dataInformada = Console.ReadLine();
                    dataValidada = Utilitario.ValidarDataDeNascimento(dataInformada, out dataNascimento);

                    if (!dataValidada)
                    {
                        continue;
                    }
                }

                if (!posicaoValidada)
                {
                    Console.Write("Posição na quadra [direita ou esquerda]: ");
                    posicaoQuadra = Console.ReadLine().ToUpper();
                    posicaoValidada = Utilitario.ValidarPosicaoQuadra(posicaoQuadra);

                    if (!posicaoValidada)
                    {
                        continue;
                    }
                }

                if (!categoriaValidada)
                {
                    Console.Write("Categoria [1 ou 2 ou 3 ou 4 ou 5]: ");
                    categoria = Console.ReadLine();
                    categoriaValidada = Utilitario.ValidarCategoria(categoria);

                    if (!categoriaValidada)
                    {
                        continue;
                    }
                }

                var atleta = new AtletaPadel(nome, email, dataNascimento, posicaoQuadra, categoria);
                listaDeAtletas.Add(atleta);

                Console.WriteLine("Atleta cadastrado com sucesso!");
                break;
            }
        }

        public static void ListarAtletas(List<AtletaPadel> listaDeAtletas)
        {
            if (listaDeAtletas.Count == 0)
            {
                Console.WriteLine("Nenhum atleta cadastrado.");
            }
            else
            {
                Console.WriteLine("Lista de Atletas:");

                foreach (var atleta in listaDeAtletas)
                {
                    Console.WriteLine($"Nome: {atleta.Nome}");
                    Console.WriteLine($"Email: {atleta.Email}");
                    Console.WriteLine($"Data de Nascimento: {atleta.DataNascimento:dd/MM/yyyy}");
                    Console.WriteLine($"Posição na quadra: {atleta.PosicaoQuadra}");
                    Console.WriteLine($"Categoria: {atleta.Categoria}");
                    Console.WriteLine();
                }
            }
        }

        public static void RemoverAtleta(List<AtletaPadel> listaDeAtletas)
        {
            Console.Write("Digite o email ou parte do nome do atleta que deseja remover: ");
            string pesquisa = Console.ReadLine().ToUpper();

            int indice = Pessoa.PesquisaNomeEmail(pesquisa, listaDeAtletas);

            if (indice != -1)
            {
                Console.WriteLine($"Atleta encontrado:");
                Console.WriteLine($"Nome: {listaDeAtletas[indice].Nome}");
                Console.WriteLine($"Email: {listaDeAtletas[indice].Email}");
                Console.WriteLine($"Data de Nascimento: {listaDeAtletas[indice].DataNascimento:dd/MM/yyyy}");
                Console.WriteLine($"Posição na quadra: {listaDeAtletas[indice].PosicaoQuadra}");
                Console.WriteLine($"Categoria: {listaDeAtletas[indice].Categoria}");
                Console.WriteLine();

                Console.Write("Tem certeza que deseja remover este atleta? (S/N): ");
                string confirmacao = Console.ReadLine().ToUpper();

                if (confirmacao == "S")
                {
                    listaDeAtletas.RemoveAt(indice);
                    Console.WriteLine("Atleta removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Operação de remoção cancelada.");
                }
            }
            else
            {
                Console.WriteLine("Atleta não encontrado.");
            }
        }
    }
}
