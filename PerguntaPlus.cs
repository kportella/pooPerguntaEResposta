namespace pooPerguntaEResposta
{
    public class PerguntaPlus : Pergunta
    {
        public PerguntaPlus() : base()
        {
            this.Dica = "";
        }

        public PerguntaPlus(string texto, string resposta, string dica) : base(texto, resposta)
        {
            this.Dica = Dica;
        }
        public string Dica { get; set; }
    }
}
