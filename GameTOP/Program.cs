using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador("Ronaldo"));
            jogo.IniciarJogo();
        }
    }

    class Jogador
    {
        public readonly string _Nome;

        public Jogador(string nome)
        {
            _Nome = nome;
        }
        public void chuta()
        {
            Console.Write($"{_Nome} está chutando");
        }

        public void Corre()
        {
            Console.Write($"{_Nome} está correndo");
        }

        public void passe()
        {
            Console.Write($"{_Nome} está passando");
        }
    }
}
