namespace _12032025
{
    partial class frmNavegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavegador));
            this.navegador = new AxSHDocVw.AxWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.navegador)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador
            // 
            this.navegador.Enabled = true;
            this.navegador.Location = new System.Drawing.Point(177, 58);
            this.navegador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.navegador.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("navegador.OcxState")));
            this.navegador.Size = new System.Drawing.Size(422, 281);
            this.navegador.TabIndex = 0;
            this.navegador.Enter += new System.EventHandler(this.navegador_Enter);
            // 
            // frmNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.navegador);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNavegador";
            this.Text = "frmNavegador";
            ((System.ComponentModel.ISupportInitialize)(this.navegador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxSHDocVw.AxWebBrowser navegador;
    }
}