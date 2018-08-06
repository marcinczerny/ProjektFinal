namespace ProjektFinal
{
    partial class PhoneClient
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.picturePhone = new System.Windows.Forms.PictureBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adres IP:";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIp.Location = new System.Drawing.Point(9, 156);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(52, 17);
            this.lblIp.TabIndex = 13;
            this.lblIp.Text = "1.1.1.1";
            // 
            // picturePhone
            // 
            this.picturePhone.BackColor = System.Drawing.Color.DarkRed;
            this.picturePhone.Enabled = false;
            this.picturePhone.Image = global::ProjektFinal.Properties.Resources.android;
            this.picturePhone.Location = new System.Drawing.Point(12, 12);
            this.picturePhone.Name = "picturePhone";
            this.picturePhone.Size = new System.Drawing.Size(128, 128);
            this.picturePhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturePhone.TabIndex = 11;
            this.picturePhone.TabStop = false;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(41, 176);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(70, 23);
            this.btnDisconnect.TabIndex = 14;
            this.btnDisconnect.Text = "Rozłącz";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // PhoneClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturePhone);
            this.Name = "PhoneClient";
            this.Size = new System.Drawing.Size(157, 206);
            ((System.ComponentModel.ISupportInitialize)(this.picturePhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Button btnDisconnect;
    }
}
