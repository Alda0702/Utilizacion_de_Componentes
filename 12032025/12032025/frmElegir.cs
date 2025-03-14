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
    public partial class frmElegir : Form
    {
        public frmElegir()
        {
            InitializeComponent();
        }

        private void btnMediaP_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
    
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            frmAdobe adobe = new frmAdobe();
            adobe.Show();
        }

        private void btnNavegador_Click(object sender, EventArgs e)
        {
            frmNavegador navegador = new frmNavegador();
            navegador.Show();
        }
    }
}
