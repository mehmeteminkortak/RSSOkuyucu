namespace RSSOkuyucu
{
    partial class Form1
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
            this.cmbBaslik = new System.Windows.Forms.ComboBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.txtKanal = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.llHaber = new System.Windows.Forms.LinkLabel();
            this.pbHaberFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHaberFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBaslik
            // 
            this.cmbBaslik.FormattingEnabled = true;
            this.cmbBaslik.Location = new System.Drawing.Point(12, 38);
            this.cmbBaslik.Name = "cmbBaslik";
            this.cmbBaslik.Size = new System.Drawing.Size(432, 21);
            this.cmbBaslik.TabIndex = 10;
            this.cmbBaslik.SelectedIndexChanged += new System.EventHandler(this.cmbBaslik_SelectedIndexChanged);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(369, 9);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 9;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // txtKanal
            // 
            this.txtKanal.Location = new System.Drawing.Point(12, 12);
            this.txtKanal.Name = "txtKanal";
            this.txtKanal.Size = new System.Drawing.Size(351, 20);
            this.txtKanal.TabIndex = 8;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(12, 239);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(432, 163);
            this.txtAciklama.TabIndex = 11;
            this.txtAciklama.Text = "";
            // 
            // llHaber
            // 
            this.llHaber.AutoSize = true;
            this.llHaber.Location = new System.Drawing.Point(12, 405);
            this.llHaber.Name = "llHaber";
            this.llHaber.Size = new System.Drawing.Size(61, 13);
            this.llHaber.TabIndex = 12;
            this.llHaber.TabStop = true;
            this.llHaber.Text = "Haber Linki";
            this.llHaber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llHaber_LinkClicked);
            // 
            // pbHaberFoto
            // 
            this.pbHaberFoto.Location = new System.Drawing.Point(12, 66);
            this.pbHaberFoto.Name = "pbHaberFoto";
            this.pbHaberFoto.Size = new System.Drawing.Size(432, 167);
            this.pbHaberFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHaberFoto.TabIndex = 13;
            this.pbHaberFoto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 427);
            this.Controls.Add(this.pbHaberFoto);
            this.Controls.Add(this.llHaber);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.cmbBaslik);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.txtKanal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbHaberFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBaslik;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.TextBox txtKanal;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.LinkLabel llHaber;
        private System.Windows.Forms.PictureBox pbHaberFoto;
    }
}

