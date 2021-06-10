using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "teste Chuta \n";
        }

        public string Corre()
        {
            return "teste Corre \n";
        }

        public string Passe()
        {
            return "teste Passa \n";
        }
    }
}