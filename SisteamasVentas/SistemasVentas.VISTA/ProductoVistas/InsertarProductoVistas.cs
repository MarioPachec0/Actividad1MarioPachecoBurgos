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

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class InsertarProductoVistas : Form
    {
        public InsertarProductoVistas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        ProductoBSS bss = new ProductoBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.IdMarca = Convert.ToInt32 (textBox2.Text);
            p.Nombre = textBox3.Text;
            p.CodigoBarra = textBox4.Text;
            p.Unidad = Convert.ToInt32 (textBox5.Text);
            p.Descripcion = textBox6.Text;

            bss.InsertarProducto(p);
            MessageBox.Show("Se guardo correctamente la persona");
        }
    }
}
