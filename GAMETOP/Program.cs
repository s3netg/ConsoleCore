




using GAMETOP.lib;

namespace GAMETOP
{
    class Program
    {
        static void Main(string[] args)
        {
           var jogo = new jogofoda(new Jogador1("Neymar"),new Jogador2(),new Jogador3("Pele"));
           jogo.iniciar_jogo();
        }
        
    }
    
    
}
