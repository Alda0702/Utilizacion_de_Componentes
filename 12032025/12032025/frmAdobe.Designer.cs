namespace _12032025
{
    partial class frmAdobe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdobe));
            this.PDF = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.PDF)).BeginInit();
            this.SuspendLayout();
            // 
            // PDF
            // 
            this.PDF.Enabled = true;
            this.PDF.Location = new System.Drawing.Point(204, 35);
            this.PDF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PDF.Name = "PDF";
            this.PDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDF.OcxState")));
            this.PDF.Size = new System.Drawing.Size(560, 384);
            this.PDF.TabIndex = 0;
            this.PDF.Enter += new System.EventHandler(this.PDF_Enter);
            // 
            // frmAdobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.PDF);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdobe";
            this.Text = "frmAdobe";
            this.Load += new System.EventHandler(this.frmAdobe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF PDF;
    }
}