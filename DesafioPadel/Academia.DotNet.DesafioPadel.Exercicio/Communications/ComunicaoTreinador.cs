using Academia.DotNet.DesafioPadel.Exercicio.Models;
using Academia.DotNet.DesafioPadel.Exercicio.Utils;

namespace Academia.DotNet.DesafioPadel.Exercicio.Communications
{
    public class ComunicaoTreinador
    {
        public static void CadastrarTreinador(List<TreinadorPadel> listaDeTreinadores)
        {
            string email = "";
            string nome = "";
            DateOnly dataNascimento = new DateOnly();
            string registroConselho = "";
            string clube = "";

            bool emailValidado = false;
            bool nomeValidado = false;
            bool dataValidada = false;
            bool registroConselhoValidado = false;
            bool clubeValidado = false;

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

                if (Pessoa.EstaContido(email, listaDeTreinadores))
                {
                    Console.WriteLine("Email já existe para um treinador! Não é possível adicionar o treinador.");
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
                    Console.Write("Data nascimento [dd/MM/aaaa]: ");
                    string dataInformada = Console.ReadLine();
                    dataValidada = Utilitario.ValidarDataDeNascimento(dataInformada, out dataNascimento);

                    if (!dataValidada)
                    {
                        continue;
                    }
                }

                if (!registroConselhoValidado)
                {
                    Console.Write("Registro do conselho: ");
                    registroConselho = Console.ReadLine();
                    registroConselhoValidado = Utilitario.ValidarRegistroConselho(registroConselho);

                    if (!registroConselhoValidado)
                    {
                        continue;
                    }
                }

                if (!clubeValidado)
                {
                    Console.Write("Clube: ");
                    clube = Console.ReadLine();
                    clubeValidado = Utilitario.ValidarClube(clube);

                    if (!clubeValidado)
                    {
                        continue;
                    }
                }

                var treinador = new TreinadorPadel(nome, email, dataNascimento, registroConselho, clube);
                listaDeTreinadores.Add(treinador);

                Console.WriteLine("Treinador cadastrado com sucesso!");
                break;
            }
        }

        public static void ListarTreinadores(List<TreinadorPadel> listaDeTreinadores)
        {
            if (listaDeTreinadores.Count == 0)
            {
                Console.WriteLine("Nenhum treinador cadastrado.");
            }
            else
            {
                Console.WriteLine("Lista de Treinadores:");

                foreach (var treinador in listaDeTreinadores)
                {
                    Console.WriteLine($"Nome: {treinador.Nome}");
                    Console.WriteLine($"Email: {treinador.Email}");
                    Console.WriteLine($"Data de Nascimento: {treinador.DataNascimento:dd/MM/yyyy}");
                    Console.WriteLine($"Registro Conselho: {treinador.RegistroConselho}");
                    Console.WriteLine($"Clube: {treinador.Clube}");
                    Console.WriteLine();
                }
            }
        }

        public static void RemoverTreinador(List<TreinadorPadel> listaDeTreinadores)
        {
            Console.Write("Digite o email ou parte do nome do treinador que deseja remover: ");
            string pesquisa = Console.ReadLine().ToUpper();

            int indice = Pessoa.PesquisaNomeEmail(pesquisa, listaDeTreinadores);

            if (indice != -1)
            {
                Console.WriteLine($"Treinador encontrado:");
                Console.WriteLine($"Nome: {listaDeTreinadores[indice].Nome}");
                Console.WriteLine($"Email: {listaDeTreinadores[indice].Email}");
                Console.WriteLine($"Data de Nascimento: {listaDeTreinadores[indice].DataNascimento:dd/MM/yyyy}");
                Console.WriteLine($"Registro Conselho: {listaDeTreinadores[indice].RegistroConselho}");
                Console.WriteLine($"Clube: {listaDeTreinadores[indice].Clube}");
                Console.WriteLine();

                Console.Write("Tem certeza que deseja remover este treinador? (S/N): ");
                string confirmacao = Console.ReadLine().ToUpper();

                if (confirmacao == "S")
                {
                    listaDeTreinadores.RemoveAt(indice);
                    Console.WriteLine("Treinador removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Operação de remoção cancelada.");
                }
            }
            else
            {
                Console.WriteLine("Treinador não encontrado.");
            }
        }
    }
}
