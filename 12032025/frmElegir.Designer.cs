namespace _12032025
{
    partial class frmElegir
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
            this.btnMediaP = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnNavegador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMediaP
            // 
            this.btnMediaP.Location = new System.Drawing.Point(105, 60);
            this.btnMediaP.Name = "btnMediaP";
            this.btnMediaP.Size = new System.Drawing.Size(173, 73);
            this.btnMediaP.TabIndex = 0;
            this.btnMediaP.Text = "Media Player";
            this.btnMediaP.UseVisualStyleBackColor = true;
            this.btnMediaP.Click += new System.EventHandler(this.btnMediaP_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(105, 149);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(173, 73);
            this.btnPdf.TabIndex = 1;
            this.btnPdf.Text = "Adobe PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnNavegador
            // 
            this.btnNavegador.Location = new System.Drawing.Point(105, 240);
            this.btnNavegador.Name = "btnNavegador";
            this.btnNavegador.Size = new System.Drawing.Size(173, 73);
            this.btnNavegador.TabIndex = 2;
            this.btnNavegador.Text = "Navegador";
            this.btnNavegador.UseVisualStyleBackColor = true;
            this.btnNavegador.Click += new System.EventHandler(this.btnNavegador_Click);
            // 
            // frmElegir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNavegador);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnMediaP);
            this.Name = "frmElegir";
            this.Text = "frmElegir";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMediaP;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnNavegador;
    }
}