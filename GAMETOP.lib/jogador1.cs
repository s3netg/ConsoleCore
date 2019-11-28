using System;

namespace GAMETOP.lib
{
    public class Jogador1:IJogador
    {
         public readonly String  _nome ;
        public Jogador1(string nome)
        {
            _nome=nome;
        }

       
        public string Chuta()
        {
            return $"{_nome} esta chutando \n";
        }
        public string Corre()
        {
            return $"{_nome} esta correndo \n";
        }
        public string Passe()
        {
            return $"{_nome} esta passando \n";
        }


    }
}