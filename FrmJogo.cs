using Projeto_Alg2.Bots;
using Projeto_Alg2.RegrasDoJogo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Alg2
{
    public partial class FrmJogo : Form
    {
        public Jogadores _jogadores { get; set; }
        public RegrasJogo _regras { get; set; }

        public FrmJogo(RegrasJogo regras, Jogadores jogadores)
        {
            InitializeComponent();
            _regras = regras;
            _jogadores = jogadores;

            txtSuaSoma.Text = regras.ImprimeCartaJogador();
            txtValor1Adv.Text = regras.ImprimeCartaBot();
        }

        private void btnPedirCarta_Click(object sender, EventArgs e)
        {
            txtSuaSoma.Text = _jogadores.PedirCartaJogador().ToString();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            _jogadores.PararJogador();
        }

        private void btnAumentarAposta_Click(object sender, EventArgs e)
        {
            _jogadores.AumentarApostaJogador();
        }

        private void FrmJogo_Load(object sender, EventArgs e)
        {

        }
        //Fazer o limite para qnd passar de 21 pontos
        //Fazer a logica do bot
        //Fazer a pontuacao jogador x bot
    }
}
