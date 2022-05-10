namespace Projeto_Alg2
{
    partial class FrmJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJogo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoJogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPontuacaoJogador = new System.Windows.Forms.Label();
            this.txtMostraPontuacaoJogador = new System.Windows.Forms.TextBox();
            this.txtPontuacaoAdv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPedirCarta = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.lblPlacar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSuaSoma = new System.Windows.Forms.TextBox();
            this.txtValor1Adv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAumentarAposta = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(326, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoJogarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // comoJogarToolStripMenuItem
            // 
            this.comoJogarToolStripMenuItem.Name = "comoJogarToolStripMenuItem";
            this.comoJogarToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.comoJogarToolStripMenuItem.Text = "Como Jogar";
            // 
            // lblPontuacaoJogador
            // 
            this.lblPontuacaoJogador.AutoSize = true;
            this.lblPontuacaoJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacaoJogador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPontuacaoJogador.Location = new System.Drawing.Point(11, 317);
            this.lblPontuacaoJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPontuacaoJogador.Name = "lblPontuacaoJogador";
            this.lblPontuacaoJogador.Size = new System.Drawing.Size(46, 20);
            this.lblPontuacaoJogador.TabIndex = 1;
            this.lblPontuacaoJogador.Text = "Você";
            // 
            // txtMostraPontuacaoJogador
            // 
            this.txtMostraPontuacaoJogador.Location = new System.Drawing.Point(95, 320);
            this.txtMostraPontuacaoJogador.Margin = new System.Windows.Forms.Padding(2);
            this.txtMostraPontuacaoJogador.Name = "txtMostraPontuacaoJogador";
            this.txtMostraPontuacaoJogador.Size = new System.Drawing.Size(67, 20);
            this.txtMostraPontuacaoJogador.TabIndex = 2;
            // 
            // txtPontuacaoAdv
            // 
            this.txtPontuacaoAdv.Location = new System.Drawing.Point(95, 343);
            this.txtPontuacaoAdv.Margin = new System.Windows.Forms.Padding(2);
            this.txtPontuacaoAdv.Name = "txtPontuacaoAdv";
            this.txtPontuacaoAdv.Size = new System.Drawing.Size(67, 20);
            this.txtPontuacaoAdv.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 341);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adversário";
            // 
            // btnPedirCarta
            // 
            this.btnPedirCarta.Location = new System.Drawing.Point(13, 186);
            this.btnPedirCarta.Margin = new System.Windows.Forms.Padding(2);
            this.btnPedirCarta.Name = "btnPedirCarta";
            this.btnPedirCarta.Size = new System.Drawing.Size(70, 41);
            this.btnPedirCarta.TabIndex = 5;
            this.btnPedirCarta.Text = "Pedir Carta";
            this.btnPedirCarta.UseVisualStyleBackColor = true;
            this.btnPedirCarta.Click += new System.EventHandler(this.btnPedirCarta_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(101, 186);
            this.btnParar.Margin = new System.Windows.Forms.Padding(2);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(70, 41);
            this.btnParar.TabIndex = 6;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // lblPlacar
            // 
            this.lblPlacar.AutoSize = true;
            this.lblPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlacar.Location = new System.Drawing.Point(9, 290);
            this.lblPlacar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlacar.Name = "lblPlacar";
            this.lblPlacar.Size = new System.Drawing.Size(73, 20);
            this.lblPlacar.TabIndex = 7;
            this.lblPlacar.Text = "PLACAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(11, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soma das suas cartas";
            // 
            // txtSuaSoma
            // 
            this.txtSuaSoma.Location = new System.Drawing.Point(182, 149);
            this.txtSuaSoma.Margin = new System.Windows.Forms.Padding(2);
            this.txtSuaSoma.Name = "txtSuaSoma";
            this.txtSuaSoma.Size = new System.Drawing.Size(67, 20);
            this.txtSuaSoma.TabIndex = 9;
            // 
            // txtValor1Adv
            // 
            this.txtValor1Adv.Location = new System.Drawing.Point(182, 109);
            this.txtValor1Adv.Margin = new System.Windows.Forms.Padding(2);
            this.txtValor1Adv.Name = "txtValor1Adv";
            this.txtValor1Adv.Size = new System.Drawing.Size(67, 20);
            this.txtValor1Adv.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor da Primeira Carta\r\ndo adversário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(78, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "BlackJack";
            // 
            // btnAumentarAposta
            // 
            this.btnAumentarAposta.Location = new System.Drawing.Point(182, 186);
            this.btnAumentarAposta.Name = "btnAumentarAposta";
            this.btnAumentarAposta.Size = new System.Drawing.Size(81, 41);
            this.btnAumentarAposta.TabIndex = 13;
            this.btnAumentarAposta.Text = "Apostar";
            this.btnAumentarAposta.UseVisualStyleBackColor = true;
            this.btnAumentarAposta.Click += new System.EventHandler(this.btnAumentarAposta_Click);
            // 
            // FrmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(326, 383);
            this.Controls.Add(this.btnAumentarAposta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor1Adv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSuaSoma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlacar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnPedirCarta);
            this.Controls.Add(this.txtPontuacaoAdv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMostraPontuacaoJogador);
            this.Controls.Add(this.lblPontuacaoJogador);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmJogo";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.FrmJogo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoJogarToolStripMenuItem;
        private System.Windows.Forms.Label lblPontuacaoJogador;
        private System.Windows.Forms.TextBox txtMostraPontuacaoJogador;
        private System.Windows.Forms.TextBox txtPontuacaoAdv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPedirCarta;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label lblPlacar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSuaSoma;
        private System.Windows.Forms.TextBox txtValor1Adv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAumentarAposta;
    }
}