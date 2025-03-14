namespace _12032025
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wmpAe = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpAe)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpAe
            // 
            this.wmpAe.Enabled = true;
            this.wmpAe.Location = new System.Drawing.Point(11, 11);
            this.wmpAe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wmpAe.Name = "wmpAe";
            this.wmpAe.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpAe.OcxState")));
            this.wmpAe.Size = new System.Drawing.Size(478, 344);
            this.wmpAe.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(493, 154);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(96, 37);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "&Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.wmpAe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wmpAe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpAe;
        private System.Windows.Forms.Button btnPlay;
    }
}

