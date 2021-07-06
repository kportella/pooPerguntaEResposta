namespace pooPerguntaEResposta
{
    public class Pergunta
    {
        public string testeA;
        private string testeB;
        protected string testeC;
        public Pergunta()
        {
            this.Texto = "";
            this.Resposta = "";
        }
        public Pergunta(string texto, string resposta)
        {
            this.Texto = texto;
            this.Resposta = resposta;
        }
        public string Texto { get; set; }

        public string Resposta { get; set; }

    }
}
