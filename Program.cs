using System;

namespace pooPerguntaEResposta
{
    class Program
    {
        static void Main(string[] args)
        {
            PerguntaPlus perguntaPlus = new PerguntaPlus();
            perguntaPlus.Texto = "Qual é o site que possui um ótimo conteúdo sobre programação?";
            perguntaPlus.Resposta = "https://dfilitto.com.br";
            perguntaPlus.Dica = "O mantenedor do site é o Danilo Filitto";

            Console.WriteLine("Tente adivinhar a pergunta");
            Console.WriteLine("Pergunta: " + perguntaPlus.Texto);
            Console.WriteLine("Dica: " + perguntaPlus.Dica);
            Console.Write("Resposta: ");
            string resposta = Console.ReadLine();

            if (perguntaPlus.Resposta.ToUpper() == resposta.ToUpper())
            {
                Console.WriteLine("Parabens!!!!! Você Acertou.");
            }
            else
            {
                Console.WriteLine("Que pena!!!!! Você errou.");
                Console.WriteLine("A resposta correta é: " + perguntaPlus.Resposta);
            }

        }
    }
}
