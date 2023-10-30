namespace Academia.DotNet.DesafioPadel.Exercicio.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa(string nome, string email, DateTime dataNascimento)
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
            var today = DateTime.Now;
            var age = today.Year - DataNascimento.Year;

            if (today < DataNascimento.AddYears(age))
            {
                age--;
            }
            return age;
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
