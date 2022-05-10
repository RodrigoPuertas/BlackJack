using Projeto_Alg2.Bots;
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
    public partial class FrmApresentacao : Form
        {
        
        public FrmApresentacao()
        {
            InitializeComponent();
            Jogadores jogadores = new Jogadores();
            //            RegrasJogo regras = new
        }


        private void btnDesc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  Este jogo foi desenvolvido por:\n\n  Lohan Batista Moreira" +
                "\n  Rodrigo Puertas Matioli", "Descrição", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //FrmApresentacao frmApresentacao = new FrmApresentacao();
            FrmJogo frmJogo = new FrmJogo(regras, jogadores);
            frmJogo.ShowDialog();
            //frmApresentacao.Dispose(); to tentantdo utilizar para fechar a apresentação mais nao funciona
        }

    }
}
