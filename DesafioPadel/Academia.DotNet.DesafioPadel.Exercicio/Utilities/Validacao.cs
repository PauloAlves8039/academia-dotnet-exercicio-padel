using System.Globalization;
using System.Text.RegularExpressions;

namespace Academia.DotNet.DesafioPadel.Exercicio.Utilities
{
    public class Validacao
    {
        public static bool ValidarNome(string nomeInformado)
        {
            if (string.IsNullOrWhiteSpace(nomeInformado))
            {
                Console.WriteLine("Nome não pode estar em branco. Por favor, insira um nome válido.");
                return false;
            }

            if (!nomeInformado.Contains(" "))
            {
                Console.WriteLine("O nome deve conter pelo menos um espaço para o sobrenome. Por favor, insira um nome completo.");
                return false;
            }

            return true;
        }

        public static bool ValidarFormatoDoEmail(string emailInformado)
        {
            if (string.IsNullOrWhiteSpace(emailInformado))
            {
                return false;
            }

            var formatoDoEmail = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

            return Regex.IsMatch(emailInformado, formatoDoEmail);
        }

        public static bool ValidarDataDeNascimento(string dataInformada, out DateTime dataValida)
        {
            if (DateTime.TryParseExact(dataInformada, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataValida))
            {
                return true;
            }

            Console.WriteLine("Data de nascimento inválida. Por favor, insira uma data no formato dd/MM/aaaa.");
            return false;
        }

        public static bool ValidarPosicaoQuadra(string posicaoInformada)
        {
            if (string.IsNullOrWhiteSpace(posicaoInformada))
            {
                Console.WriteLine("A posição na quadra não pode estar em branco. Por favor, insira uma posição válida.");
                return false;
            }

            if (!posicaoInformada.Equals("direita", StringComparison.OrdinalIgnoreCase) && !posicaoInformada.Equals("esquerda", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Posição na quadra inválida. Escolha entre 'direita' ou 'esquerda'.");
                return false;
            }

            return true;
        }

        public static bool ValidarCategoria(string categoriaInformada)
        {
            if (string.IsNullOrWhiteSpace(categoriaInformada))
            {
                Console.WriteLine("A categoria não pode estar em branco. Por favor, insira uma categoria válida.");
                return false;
            }

            if (!new[] { "1", "2", "3", "4", "5" }.Contains(categoriaInformada))
            {
                Console.WriteLine("Categoria inválida. Escolha entre '1', '2', '3', '4' ou '5'.");
                return false;
            }

            return true;
        }

        public static bool ValidarRegistroConselho(string registroConselho)
        {
            if (string.IsNullOrWhiteSpace(registroConselho))
            {
                Console.WriteLine("O registro do conselho não pode estar em branco. Por favor, insira um registro válido.");
                return false;
            }

            return true;
        }

        public static bool ValidarClube(string clube)
        {
            if (string.IsNullOrWhiteSpace(clube))
            {
                Console.WriteLine("O nome do clube não pode estar em branco. Por favor, insira um nome de clube válido.");
                return false;
            }

            return true;
        }

    }
}
