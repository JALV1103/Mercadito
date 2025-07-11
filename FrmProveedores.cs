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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\IMG\FrmProveedor.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
