namespace Academia.DotNet.DesafioPadel.Exercicio.Models
{
    public class TreinadorPadel : Pessoa
    {
        private string registroConselho;
        private string clube;

        public string RegistroConselho
        {
            get { return registroConselho; }
            set { registroConselho = value; }
        }

        public string Clube
        {
            get { return clube; }
            set { clube = value; }
        }

        public TreinadorPadel(string nome, string email, DateOnly dataNascimento, string registroConselho, string clube) 
            : base(nome, email, dataNascimento)
        {
            RegistroConselho = registroConselho;
            Clube = clube;
        }
    }
}
