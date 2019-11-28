using System;


namespace GAMETOP
{
    class jogofoda{
        private readonly IJogador _jogador1;
         private readonly IJogador _jogador2;
         private readonly IJogador _jogador3;

        public jogofoda(IJogador jogador1,IJogador jogador2,IJogador jogador3)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
            _jogador3=jogador3;
        }
        public void iniciar_jogo(){

            Console.WriteLine(_jogador1.Corre());
            Console.WriteLine(_jogador1.Chuta());
            Console.WriteLine(_jogador1.Passe());

            Console.WriteLine(_jogador2.Corre());
            Console.WriteLine(_jogador2.Chuta());
            Console.WriteLine(_jogador2.Passe());

            Console.WriteLine(_jogador3.Corre());
            Console.WriteLine(_jogador3.Chuta());
            Console.WriteLine(_jogador3.Passe());



        }
    }
}