using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Alg2.RegrasDoJogo;

namespace Projeto_Alg2.Bots
{
    public class Jogadores
    {
        public string Jogador { get; set; }
        public string Bot { get; set; }
        public int[] cartasJogador { get; set; } = new int[15];
        public int[] CartasBot { get; set; } = new int [15];
        public int auxBtnPedirCarta { get; set; } = 0;
        public RegrasJogo _regras { get; set; }

        public Jogadores(RegrasJogo regras)
        {
            _regras = regras;
        }

        public int PedirCartaJogador()
        {

            Random random = new Random();
            int aux = 0;

            do
            {
                do
                {
                    aux = random.Next(0, _regras.valoresCartas.Length - 1);
                } while (aux == 0);

                cartasJogador[auxBtnPedirCarta] = _regras.valoresCartas[aux];

            }while (cartasJogador[auxBtnPedirCarta] == 0);

            _regras.CartasDisponiveis(_regras.valoresCartas, cartasJogador[auxBtnPedirCarta]);


            var resp = _regras.SomaCartasJogador(auxBtnPedirCarta);

            auxBtnPedirCarta++;

            return resp;

        }


        public void PararJogador()
        {
            _regras.FimDeJogo = true;
            
        }

        public void AumentarApostaJogador()
        {

        }
        
        public void bot()
        {

        }
    }
}
