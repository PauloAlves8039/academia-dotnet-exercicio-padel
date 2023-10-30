namespace Academia.DotNet.DesafioPadel.Exercicio.Models
{
    public class AtletaPadel : Pessoa
    {
        public string PosicaoQuadra { get; set; }
        public string Categoria { get; set; }

        public AtletaPadel(string nome, string email, DateTime dataNascimento, string posicao, string categoria) 
            : base(nome, email, dataNascimento)
        {
            PosicaoQuadra = posicao;
            Categoria = categoria;
        }
    }
}
