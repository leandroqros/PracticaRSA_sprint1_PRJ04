namespace PracticaRSA
{
    partial class frmDesencriptar
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
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.tbx_decrypted = new System.Windows.Forms.TextBox();
            this.tbx_crypted = new System.Windows.Forms.TextBox();
            this.lblMsgO = new System.Windows.Forms.Label();
            this.lblMsgEncrip = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.pnl_keys = new System.Windows.Forms.Panel();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_routeXML = new System.Windows.Forms.Button();
            this.tbx_routeXML = new System.Windows.Forms.TextBox();
            this.tbx_container = new System.Windows.Forms.TextBox();
            this.lblArchivoXML = new System.Windows.Forms.Label();
            this.lblKC = new System.Windows.Forms.Label();
            this.pnl_keys.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(444, 230);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(103, 23);
            this.btn_decrypt.TabIndex = 20;
            this.btn_decrypt.Text = "Desencriptar";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            // 
            // tbx_decrypted
            // 
            this.tbx_decrypted.Location = new System.Drawing.Point(145, 268);
            this.tbx_decrypted.Name = "tbx_decrypted";
            this.tbx_decrypted.Size = new System.Drawing.Size(288, 20);
            this.tbx_decrypted.TabIndex = 24;
            // 
            // tbx_crypted
            // 
            this.tbx_crypted.Location = new System.Drawing.Point(145, 232);
            this.tbx_crypted.Name = "tbx_crypted";
            this.tbx_crypted.Size = new System.Drawing.Size(288, 20);
            this.tbx_crypted.TabIndex = 21;
            // 
            // lblMsgO
            // 
            this.lblMsgO.AutoSize = true;
            this.lblMsgO.Location = new System.Drawing.Point(56, 271);
            this.lblMsgO.Name = "lblMsgO";
            this.lblMsgO.Size = new System.Drawing.Size(83, 13);
            this.lblMsgO.TabIndex = 23;
            this.lblMsgO.Text = "Mensaje original";
            // 
            // lblMsgEncrip
            // 
            this.lblMsgEncrip.AutoSize = true;
            this.lblMsgEncrip.Location = new System.Drawing.Point(39, 235);
            this.lblMsgEncrip.Name = "lblMsgEncrip";
            this.lblMsgEncrip.Size = new System.Drawing.Size(100, 13);
            this.lblMsgEncrip.TabIndex = 22;
            this.lblMsgEncrip.Text = "Mensaje encriptado";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(62, 25);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(92, 13);
            this.lblGrupo.TabIndex = 19;
            this.lblGrupo.Text = "Gestion de claves";
            // 
            // pnl_keys
            // 
            this.pnl_keys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_keys.Controls.Add(this.btn_generate);
            this.pnl_keys.Controls.Add(this.btn_routeXML);
            this.pnl_keys.Controls.Add(this.tbx_routeXML);
            this.pnl_keys.Controls.Add(this.tbx_container);
            this.pnl_keys.Controls.Add(this.lblArchivoXML);
            this.pnl_keys.Controls.Add(this.lblKC);
            this.pnl_keys.Location = new System.Drawing.Point(45, 31);
            this.pnl_keys.Name = "pnl_keys";
            this.pnl_keys.Size = new System.Drawing.Size(502, 148);
            this.pnl_keys.TabIndex = 18;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(337, 106);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(93, 23);
            this.btn_generate.TabIndex = 7;
            this.btn_generate.Text = "Generar Claves";
            this.btn_generate.UseVisualStyleBackColor = true;
            // 
            // btn_routeXML
            // 
            this.btn_routeXML.Location = new System.Drawing.Point(436, 78);
            this.btn_routeXML.Name = "btn_routeXML";
            this.btn_routeXML.Size = new System.Drawing.Size(34, 23);
            this.btn_routeXML.TabIndex = 6;
            this.btn_routeXML.Text = "...";
            this.btn_routeXML.UseVisualStyleBackColor = true;
            // 
            // tbx_routeXML
            // 
            this.tbx_routeXML.Location = new System.Drawing.Point(142, 80);
            this.tbx_routeXML.Name = "tbx_routeXML";
            this.tbx_routeXML.Size = new System.Drawing.Size(288, 20);
            this.tbx_routeXML.TabIndex = 5;
            // 
            // tbx_container
            // 
            this.tbx_container.Location = new System.Drawing.Point(142, 36);
            this.tbx_container.Name = "tbx_container";
            this.tbx_container.Size = new System.Drawing.Size(127, 20);
            this.tbx_container.TabIndex = 4;
            // 
            // lblArchivoXML
            // 
            this.lblArchivoXML.AutoSize = true;
            this.lblArchivoXML.Location = new System.Drawing.Point(18, 83);
            this.lblArchivoXML.Name = "lblArchivoXML";
            this.lblArchivoXML.Size = new System.Drawing.Size(121, 13);
            this.lblArchivoXML.TabIndex = 3;
            this.lblArchivoXML.Text = "Archivo XML Public Key";
            // 
            // lblKC
            // 
            this.lblKC.AutoSize = true;
            this.lblKC.Location = new System.Drawing.Point(29, 39);
            this.lblKC.Name = "lblKC";
            this.lblKC.Size = new System.Drawing.Size(110, 13);
            this.lblKC.TabIndex = 2;
            this.lblKC.Text = "Nombre KeyContainer";
            // 
            // frmDesencriptar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.tbx_decrypted);
            this.Controls.Add(this.tbx_crypted);
            this.Controls.Add(this.lblMsgO);
            this.Controls.Add(this.lblMsgEncrip);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.pnl_keys);
            this.Name = "frmDesencriptar";
            this.Text = "Desencriptar";
            this.pnl_keys.ResumeLayout(false);
            this.pnl_keys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.TextBox tbx_decrypted;
        private System.Windows.Forms.TextBox tbx_crypted;
        private System.Windows.Forms.Label lblMsgO;
        private System.Windows.Forms.Label lblMsgEncrip;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Panel pnl_keys;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_routeXML;
        private System.Windows.Forms.TextBox tbx_routeXML;
        private System.Windows.Forms.TextBox tbx_container;
        private System.Windows.Forms.Label lblArchivoXML;
        private System.Windows.Forms.Label lblKC;
    }
}