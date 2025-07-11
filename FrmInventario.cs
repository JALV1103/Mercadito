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
    public partial class FrmInventario : Form
    {
        private List<Inventario> inventario;
        public FrmInventario()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\IMG\FrmInventario.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            inventario = new List<Inventario>();
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel excel = new ExportarExcel();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string archivoAGuardar = saveDialog.FileName;
                excel.ExportarListaAExcel(inventario, archivoAGuardar);
                MessageBox.Show("Archivo Guardado Exitosamente");
            }
        }
    }
}
