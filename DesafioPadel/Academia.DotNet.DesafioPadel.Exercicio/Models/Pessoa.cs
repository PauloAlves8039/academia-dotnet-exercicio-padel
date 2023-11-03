namespace Academia.DotNet.DesafioPadel.Exercicio.Models
{
    public class Pessoa
    {
        private string nome;
        private string email;
        private DateOnly dataNascimento;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateOnly DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public Pessoa(string nome, string email, DateOnly dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public int Idade()
        {
            DateOnly hoje = DateOnly.FromDateTime(DateTime.Now);
            int idade = hoje.Year - DataNascimento.Year;

            DateOnly aniversario = DataNascimento.AddYears(idade);

            if (hoje < aniversario)
            {
                idade--;
            }

            return idade;
        }

        public string Sobrenome()
        {
            string[] vetor = Nome.Split(' ');

            if (vetor.Length > 1)
            {
                return vetor[vetor.Length - 1];
            }
            else
            {
                return Nome;
            }
        }

        public static bool EstaContido<T>(string email, List<T> listaInformada) where T : Pessoa
        {
            foreach (var item in listaInformada)
            {
                if (item.Email == email)
                {
                    return true;
                }
            }

            return false;
        }

        public static int PesquisaNomeEmail<T>(string pesquisar, List<T> listaInformada) where T : Pessoa
        {
            for (int i = 0; i < listaInformada.Count; i++)
            {
                if (pesquisar.Equals(listaInformada[i].Email, StringComparison.OrdinalIgnoreCase) || listaInformada[i].Nome.Contains(pesquisar))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
