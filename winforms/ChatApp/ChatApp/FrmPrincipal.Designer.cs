namespace ChatApp
{
    partial class FrmPrincipal
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
            this.wbMensagens = new System.Windows.Forms.WebBrowser();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.ckbMsgPrivada = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtNovaMsg = new System.Windows.Forms.TextBox();
            this.lbUsuarios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wbMensagens
            // 
            this.wbMensagens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbMensagens.Location = new System.Drawing.Point(161, 56);
            this.wbMensagens.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMensagens.Name = "wbMensagens";
            this.wbMensagens.Size = new System.Drawing.Size(611, 357);
            this.wbMensagens.TabIndex = 4;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Location = new System.Drawing.Point(691, 430);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(81, 52);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // ckbMsgPrivada
            // 
            this.ckbMsgPrivada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbMsgPrivada.AutoSize = true;
            this.ckbMsgPrivada.Checked = true;
            this.ckbMsgPrivada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMsgPrivada.Location = new System.Drawing.Point(5, 461);
            this.ckbMsgPrivada.Name = "ckbMsgPrivada";
            this.ckbMsgPrivada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbMsgPrivada.Size = new System.Drawing.Size(150, 21);
            this.ckbMsgPrivada.TabIndex = 7;
            this.ckbMsgPrivada.Text = "Mensagem privada";
            this.ckbMsgPrivada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbMsgPrivada.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(675, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(97, 17);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "desconectado";
            // 
            // btnConectar
            // 
            this.btnConectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConectar.Location = new System.Drawing.Point(580, 9);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(89, 30);
            this.btnConectar.TabIndex = 10;
            this.btnConectar.Text = "Entrar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtNovaMsg
            // 
            this.txtNovaMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNovaMsg.Location = new System.Drawing.Point(161, 430);
            this.txtNovaMsg.Multiline = true;
            this.txtNovaMsg.Name = "txtNovaMsg";
            this.txtNovaMsg.Size = new System.Drawing.Size(524, 52);
            this.txtNovaMsg.TabIndex = 12;
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.FormattingEnabled = true;
            this.lbUsuarios.ItemHeight = 16;
            this.lbUsuarios.Location = new System.Drawing.Point(19, 57);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(120, 356);
            this.lbUsuarios.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Apelido";
            // 
            // txtApelido
            // 
            this.txtApelido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApelido.Location = new System.Drawing.Point(161, 13);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(413, 22);
            this.txtApelido.TabIndex = 14;
            // 
            // FrmPrincipal
            // 
            this.AcceptButton = this.btnEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.lbUsuarios);
            this.Controls.Add(this.txtNovaMsg);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.ckbMsgPrivada);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.wbMensagens);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincipal";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser wbMensagens;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox ckbMsgPrivada;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtNovaMsg;
        private System.Windows.Forms.ListBox lbUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApelido;
    }
}

