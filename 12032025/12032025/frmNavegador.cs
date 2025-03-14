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
    public partial class frmNavegador : Form
    {
        public frmNavegador()
        {
            InitializeComponent();
        }

        private void navegador_Enter(object sender, EventArgs e)
        {
            int pdfWidth = (int)(this.Width * 0.95);
            int pdfHeight = (int)(this.Height * 0.95);

            navegador.Size = new Size(pdfWidth, pdfHeight);

            int posX = (this.Width - navegador.Width) / 2;
            int posY = (this.Height - navegador.Height) / 2;

            navegador.Location = new Point(posX, posY);

            navegador.Navigate("https://www.google.com/?hl=es");
        }
    }
}
