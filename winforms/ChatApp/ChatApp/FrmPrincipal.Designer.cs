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
            this.ckbMsgReservada = new System.Windows.Forms.CheckBox();
            this.txtNovaMsg = new System.Windows.Forms.TextBox();
            this.lbUsuarios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wbMensagens
            // 
            this.wbMensagens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbMensagens.Location = new System.Drawing.Point(121, 46);
            this.wbMensagens.Margin = new System.Windows.Forms.Padding(2);
            this.wbMensagens.MinimumSize = new System.Drawing.Size(15, 16);
            this.wbMensagens.Name = "wbMensagens";
            this.wbMensagens.Size = new System.Drawing.Size(520, 352);
            this.wbMensagens.TabIndex = 4;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Location = new System.Drawing.Point(564, 412);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(72, 41);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // ckbMsgReservada
            // 
            this.ckbMsgReservada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbMsgReservada.AutoSize = true;
            this.ckbMsgReservada.BackColor = System.Drawing.Color.Transparent;
            this.ckbMsgReservada.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbMsgReservada.Checked = true;
            this.ckbMsgReservada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMsgReservada.ForeColor = System.Drawing.Color.Black;
            this.ckbMsgReservada.Location = new System.Drawing.Point(564, 457);
            this.ckbMsgReservada.Margin = new System.Windows.Forms.Padding(2);
            this.ckbMsgReservada.Name = "ckbMsgReservada";
            this.ckbMsgReservada.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbMsgReservada.Size = new System.Drawing.Size(78, 17);
            this.ckbMsgReservada.TabIndex = 7;
            this.ckbMsgReservada.Text = "Reservada";
            this.ckbMsgReservada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbMsgReservada.UseVisualStyleBackColor = false;
            // 
            // txtNovaMsg
            // 
            this.txtNovaMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNovaMsg.Location = new System.Drawing.Point(18, 412);
            this.txtNovaMsg.Margin = new System.Windows.Forms.Padding(2);
            this.txtNovaMsg.Multiline = true;
            this.txtNovaMsg.Name = "txtNovaMsg";
            this.txtNovaMsg.Size = new System.Drawing.Size(542, 66);
            this.txtNovaMsg.TabIndex = 12;
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUsuarios.FormattingEnabled = true;
            this.lbUsuarios.Location = new System.Drawing.Point(14, 46);
            this.lbUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(91, 355);
            this.lbUsuarios.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(121, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sala";
            // 
            // FrmPrincipal
            // 
            this.AcceptButton = this.btnEnviar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(647, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUsuarios);
            this.Controls.Add(this.txtNovaMsg);
            this.Controls.Add(this.ckbMsgReservada);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.wbMensagens);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPrincipal";
            this.Text = "Chat - APP";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser wbMensagens;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox ckbMsgReservada;
        private System.Windows.Forms.TextBox txtNovaMsg;
        private System.Windows.Forms.ListBox lbUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

