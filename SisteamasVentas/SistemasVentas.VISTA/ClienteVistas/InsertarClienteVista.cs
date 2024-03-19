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

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class InsertarClienteVista : Form
    {
        public InsertarClienteVista()
        {
            InitializeComponent();
        }
        ClienteBSS bss = new ClienteBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente C = new Cliente();
            C.TipoCliente = textBox1.Text;
            C.CodigoCliente = textBox2.Text;
            C.IdCliente = Convert.ToInt32(textBox3.Text);
            bss.InsertarCliente(C);
            MessageBox.Show("El cliente se guardo correctamente");
        }
    }
}
