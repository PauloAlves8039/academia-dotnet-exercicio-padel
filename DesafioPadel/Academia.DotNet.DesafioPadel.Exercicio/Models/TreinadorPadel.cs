namespace Academia.DotNet.DesafioPadel.Exercicio.Models
{
    public class TreinadorPadel : Pessoa
    {
        public string RegistroConselho { get; set; }
        public string Clube { get; set; }

        public TreinadorPadel(string nome, string email, DateTime dataNascimento, string registroConselho, string clube) 
            : base(nome, email, dataNascimento)
        {
            RegistroConselho = registroConselho;
            Clube = clube;
        }
    }
}
