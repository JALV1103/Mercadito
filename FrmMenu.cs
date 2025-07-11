using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadito
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\IMG\FrmMenu.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario FrmInventario = new FrmInventario();
            this.Hide();
            FrmInventario.ShowDialog();
            this.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedores FrmProveedores = new FrmProveedores();
            this.Hide();
            FrmProveedores.ShowDialog();
            this.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVenta FrmVenta = new FrmVenta();
            this.Hide();
            FrmVenta.ShowDialog();
            this.Show();
        }
    }

}
