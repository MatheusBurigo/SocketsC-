namespace Tela
{
    partial class ClienteFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteFrm));
            this.pnlConectados = new System.Windows.Forms.Panel();
            this.lsbConectados = new System.Windows.Forms.ListBox();
            this.lsbMensagens = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConectados = new System.Windows.Forms.Label();
            this.pnlMensagensRecebidas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMensagensRecebidas = new System.Windows.Forms.Label();
            this.pnlMensagem = new System.Windows.Forms.Panel();
            this.lblClientesParaEnviar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.pnlAcoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnAcionarCliente = new System.Windows.Forms.Button();
            this.ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlConectados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMensagensRecebidas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMensagem.SuspendLayout();
            this.pnlAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConectados
            // 
            this.pnlConectados.Controls.Add(this.lsbConectados);
            this.pnlConectados.Controls.Add(this.panel1);
            this.pnlConectados.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlConectados.Location = new System.Drawing.Point(606, 0);
            this.pnlConectados.Name = "pnlConectados";
            this.pnlConectados.Size = new System.Drawing.Size(316, 583);
            this.pnlConectados.TabIndex = 0;
            // 
            // lsbConectados
            // 
            this.lsbConectados.DataSource = this.lsbMensagens.Controls;
            this.lsbConectados.Dock = System.Windows.Forms.DockStyle.Right;
            this.lsbConectados.FormattingEnabled = true;
            this.lsbConectados.ItemHeight = 15;
            this.lsbConectados.Location = new System.Drawing.Point(27, 45);
            this.lsbConectados.Name = "lsbConectados";
            this.lsbConectados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbConectados.Size = new System.Drawing.Size(289, 538);
            this.lsbConectados.TabIndex = 17;
            this.lsbConectados.MouseLeave += new System.EventHandler(this.lsbConectados_MouseLeave);
            // 
            // lsbMensagens
            // 
            this.lsbMensagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbMensagens.FormattingEnabled = true;
            this.lsbMensagens.ItemHeight = 15;
            this.lsbMensagens.Location = new System.Drawing.Point(0, 45);
            this.lsbMensagens.Name = "lsbMensagens";
            this.lsbMensagens.Size = new System.Drawing.Size(606, 342);
            this.lsbMensagens.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblConectados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 45);
            this.panel1.TabIndex = 16;
            // 
            // lblConectados
            // 
            this.lblConectados.AutoSize = true;
            this.lblConectados.Location = new System.Drawing.Point(105, 18);
            this.lblConectados.Name = "lblConectados";
            this.lblConectados.Size = new System.Drawing.Size(70, 15);
            this.lblConectados.TabIndex = 15;
            this.lblConectados.Text = "Conectados";
            // 
            // pnlMensagensRecebidas
            // 
            this.pnlMensagensRecebidas.Controls.Add(this.lsbMensagens);
            this.pnlMensagensRecebidas.Controls.Add(this.panel2);
            this.pnlMensagensRecebidas.Controls.Add(this.pnlMensagem);
            this.pnlMensagensRecebidas.Controls.Add(this.pnlAcoes);
            this.pnlMensagensRecebidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMensagensRecebidas.Location = new System.Drawing.Point(0, 0);
            this.pnlMensagensRecebidas.Name = "pnlMensagensRecebidas";
            this.pnlMensagensRecebidas.Size = new System.Drawing.Size(606, 583);
            this.pnlMensagensRecebidas.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMensagensRecebidas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 45);
            this.panel2.TabIndex = 2;
            // 
            // lblMensagensRecebidas
            // 
            this.lblMensagensRecebidas.AutoSize = true;
            this.lblMensagensRecebidas.Location = new System.Drawing.Point(232, 18);
            this.lblMensagensRecebidas.Name = "lblMensagensRecebidas";
            this.lblMensagensRecebidas.Size = new System.Drawing.Size(123, 15);
            this.lblMensagensRecebidas.TabIndex = 16;
            this.lblMensagensRecebidas.Text = "Mensagens Recebidas";
            // 
            // pnlMensagem
            // 
            this.pnlMensagem.Controls.Add(this.lblClientesParaEnviar);
            this.pnlMensagem.Controls.Add(this.label1);
            this.pnlMensagem.Controls.Add(this.label3);
            this.pnlMensagem.Controls.Add(this.txtMensagem);
            this.pnlMensagem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMensagem.Location = new System.Drawing.Point(0, 387);
            this.pnlMensagem.Name = "pnlMensagem";
            this.pnlMensagem.Size = new System.Drawing.Size(606, 73);
            this.pnlMensagem.TabIndex = 1;
            // 
            // lblClientesParaEnviar
            // 
            this.lblClientesParaEnviar.AutoSize = true;
            this.lblClientesParaEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblClientesParaEnviar.Location = new System.Drawing.Point(178, 11);
            this.lblClientesParaEnviar.Name = "lblClientesParaEnviar";
            this.lblClientesParaEnviar.Size = new System.Drawing.Size(12, 15);
            this.lblClientesParaEnviar.TabIndex = 19;
            this.lblClientesParaEnviar.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Para";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mensgem:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensagem.Location = new System.Drawing.Point(12, 39);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(565, 23);
            this.txtMensagem.TabIndex = 16;
            // 
            // pnlAcoes
            // 
            this.pnlAcoes.Controls.Add(this.btnSair);
            this.pnlAcoes.Controls.Add(this.btnArquivo);
            this.pnlAcoes.Controls.Add(this.btnEnviar);
            this.pnlAcoes.Controls.Add(this.btnAcionarCliente);
            this.pnlAcoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAcoes.Location = new System.Drawing.Point(0, 460);
            this.pnlAcoes.Name = "pnlAcoes";
            this.pnlAcoes.Size = new System.Drawing.Size(606, 123);
            this.pnlAcoes.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(427, 32);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 64);
            this.btnSair.TabIndex = 22;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnArquivo
            // 
            this.btnArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArquivo.Enabled = false;
            this.btnArquivo.Location = new System.Drawing.Point(313, 32);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(64, 64);
            this.btnArquivo.TabIndex = 21;
            this.btnArquivo.Text = "Arquivo";
            this.btnArquivo.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Location = new System.Drawing.Point(195, 32);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(64, 64);
            this.btnEnviar.TabIndex = 20;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // btnAcionarCliente
            // 
            this.btnAcionarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcionarCliente.Location = new System.Drawing.Point(74, 32);
            this.btnAcionarCliente.Name = "btnAcionarCliente";
            this.btnAcionarCliente.Size = new System.Drawing.Size(64, 64);
            this.btnAcionarCliente.TabIndex = 19;
            this.btnAcionarCliente.Text = "Conectar";
            this.btnAcionarCliente.UseVisualStyleBackColor = true;
            this.btnAcionarCliente.Click += new System.EventHandler(this.btnAcionarCliente_Click);
            // 
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataSource = this.pnlAcoes.Controls;
            this.ClientesBindingSource.Position = 0;
            // 
            // ClienteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 583);
            this.Controls.Add(this.pnlMensagensRecebidas);
            this.Controls.Add(this.pnlConectados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClienteFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.pnlConectados.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMensagensRecebidas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlMensagem.ResumeLayout(false);
            this.pnlMensagem.PerformLayout();
            this.pnlAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlConectados;
        private Panel pnlMensagensRecebidas;
        private Panel pnlMensagem;
        private Panel pnlAcoes;
        private Label lblConectados;
        private Button btnAcionarCliente;
        private Button btnEnviar;
        private Button btnArquivo;
        private Button btnSair;
        private TextBox txtMensagem;
        private ListBox lsbConectados;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private ListBox lsbMensagens;
        private Label lblMensagensRecebidas;
        private BindingSource ClientesBindingSource;
        private Label label1;
        private Label lblClientesParaEnviar;
    }
}