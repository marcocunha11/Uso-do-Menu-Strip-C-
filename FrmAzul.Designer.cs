namespace AppExemploMenu
{
    partial class FrmAzul
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibir = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmAmarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirFrmVermelho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibir
            // 
            this.exibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirFrmAmarelo,
            this.exibirFrmAzul,
            this.exibirFrmVermelho});
            this.exibir.Name = "exibir";
            this.exibir.Size = new System.Drawing.Size(47, 20);
            this.exibir.Text = "Exibir";
            // 
            // exibirFrmAmarelo
            // 
            this.exibirFrmAmarelo.Name = "exibirFrmAmarelo";
            this.exibirFrmAmarelo.Size = new System.Drawing.Size(145, 22);
            this.exibirFrmAmarelo.Text = "FrmAmarelo";
            this.exibirFrmAmarelo.Click += new System.EventHandler(this.exibirFrmAmarelo_Click);
            // 
            // exibirFrmAzul
            // 
            this.exibirFrmAzul.Name = "exibirFrmAzul";
            this.exibirFrmAzul.Size = new System.Drawing.Size(145, 22);
            this.exibirFrmAzul.Text = "FrmAzul";
            this.exibirFrmAzul.Click += new System.EventHandler(this.exibirFrmAzul_Click);
            // 
            // exibirFrmVermelho
            // 
            this.exibirFrmVermelho.Name = "exibirFrmVermelho";
            this.exibirFrmVermelho.Size = new System.Drawing.Size(145, 22);
            this.exibirFrmVermelho.Text = "FrmVermelho";
            this.exibirFrmVermelho.Click += new System.EventHandler(this.exibirFrmVermelho_Click);
            // 
            // FrmAzul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAzul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibir;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmAmarelo;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmAzul;
        private System.Windows.Forms.ToolStripMenuItem exibirFrmVermelho;
    }
}

