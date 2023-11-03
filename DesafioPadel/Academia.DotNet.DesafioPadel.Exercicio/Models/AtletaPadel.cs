namespace Academia.DotNet.DesafioPadel.Exercicio.Models
{
    public class AtletaPadel : Pessoa
    {
        private string posicaoQuadra;
        private string categoria;

        public string PosicaoQuadra
        {
            get { return posicaoQuadra; }
            set { posicaoQuadra = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public AtletaPadel(string nome, string email, DateOnly dataNascimento, string posicao, string categoria) 
            : base(nome, email, dataNascimento)
        {
            PosicaoQuadra = posicao;
            Categoria = categoria;
        }
    }
}
