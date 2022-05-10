using Projeto_Alg2.Bots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Alg2.RegrasDoJogo
{
    public class RegrasJogo
    {
        public Jogadores _jogadores { get; set; }
        public bool FimDeJogo { get; set; } = false;

        public RegrasJogo(Jogadores jogadores)
        {
            _jogadores = jogadores;
        }
        
        Random random = new Random();

        

        public int[] valoresCartas = {  11,11,11,11, //Ás
                                        10,10,10,10,
                                        10,10,10,10,
                                        10,10,10,10,
                                        10,10,10,10,
                                        9,9,9,9,
                                        8,8,8,8,
                                        7,7,7,7,
                                        6,6,6,6,
                                        5,5,5,5,
                                        4,4,4,4,
                                        3,3,3,3,
                                        2,2,2,2  };//--> Cartas do baralho



        //imprime a soma das duas primeiras cartas do jogador, conforme a regra
        public string ImprimeCartaJogador()// inicio de jogo
        {

            _jogadores.cartasJogador[0] = SorteiaCarta();
            CartasDisponiveis(valoresCartas, _jogadores.cartasJogador[0]);

            return Convert.ToString(_jogadores.cartasJogador[0]);

        }

        public string ImprimeCartaBot() //imprime apenas a primeira carta do advesario, conforme a regra
        {
            _jogadores.CartasBot[0] = SorteiaCarta();
            CartasDisponiveis(valoresCartas, _jogadores.CartasBot[0]);

            return Convert.ToString(_jogadores.CartasBot[0]);
        }


        public int SorteiaCarta()        
        {
            var num = 0;
            Random rand = new Random();
            do
            {
                num = this.valoresCartas[rand.Next(0, valoresCartas.Length - 1)];
            }while(num == 0);

            return num;
        }


        public int SomaCartasJogador(int auxBtnPedirCarta)
        {

            for (int j = 0; j <= 14; j++)
            {
                MessageBox.Show(_jogadores.cartasJogador[j].ToString());
            }
            int soma = 0;
            for (int j = 0; j <= auxBtnPedirCarta; j++)
            {
                soma += _jogadores.cartasJogador[j];
            }
            return soma;
        }


        public void CartasDisponiveis(int[] valoresCartas, int valorCarta)
        {
            for (int i = 0; i < valoresCartas.Length; i++)
            {
                if (valoresCartas[i] == valorCarta)
                {
                    valoresCartas[i] = 0;
                    break;
                }
            }
        }

        public void VerificaGanhador()
        {
           // SomaCartasJogador()
        }
    }
}
