namespace ProjektFinal
{
    partial class LedLight
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
            this.components = new System.ComponentModel.Container();
            this.pictureDiode1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiode1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureDiode1
            // 
            this.pictureDiode1.Image = global::ProjektFinal.Properties.Resources.diodeOff;
            this.pictureDiode1.Location = new System.Drawing.Point(3, 3);
            this.pictureDiode1.Name = "pictureDiode1";
            this.pictureDiode1.Size = new System.Drawing.Size(64, 64);
            this.pictureDiode1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureDiode1.TabIndex = 9;
            this.pictureDiode1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LedLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureDiode1);
            this.Name = "LedLight";
            this.Size = new System.Drawing.Size(69, 70);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiode1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureDiode1;
        private System.Windows.Forms.Timer timer1;
    }
}
