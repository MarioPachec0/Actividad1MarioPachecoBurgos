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

namespace SistemasVentas.VISTA.ProveedorVistas
{
    public partial class InsertarProveedorVistas : Form
    {
        public InsertarProveedorVistas()
        {
            InitializeComponent();
        }
        ProveedorBSS bss = new ProveedorBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();
            p.Nombre = textBox2.Text;
            p.Telefono = textBox3.Text;
            p.Direccion = textBox4.Text;
            bss.InsertarProveedor(p);
            MessageBox.Show("El cliente se guardo correctamente");
        }
    }
}
