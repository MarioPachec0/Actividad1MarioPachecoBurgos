using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.TipoProdVistas
{
    public partial class InsertarTipoProdVistas : Form
    {
        public InsertarTipoProdVistas()
        {
            InitializeComponent();
        }
        TipoProdBSS bss = new TipoProdBSS();
        private void button1_Click(object sender, EventArgs e)
        {

            TipoProd Tp = new TipoProd();
            Tp.Nombre = textBox1.Text;
            bss.InsertarTipoProd(Tp);
            MessageBox.Show("El cliente se guardo correctamente");
        }
    }
}
