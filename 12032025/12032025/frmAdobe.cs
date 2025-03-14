using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12032025
{
    public partial class frmAdobe : Form
    {
        public frmAdobe()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void PDF_Enter(object sender, EventArgs e)
        {
            PDF.src = "http://www.facmed.unam.mx/publicaciones/libros/pdfs/histologica17-21.pdf";

        }

        private void frmAdobe_Load(object sender, EventArgs e)
        {
            int pdfWidth = (int)(this.Width * 0.95);   
            int pdfHeight = (int)(this.Height * 0.95); 

            PDF.Size = new Size(pdfWidth, pdfHeight);

            int posX = (this.Width - PDF.Width) / 2;
            int posY = (this.Height - PDF.Height) / 2;

            PDF.Location = new Point(posX, posY);

        }
    }
}
