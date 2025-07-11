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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();

            Bitmap img = new Bitmap(Application.StartupPath + @"\IMG\FrmVenta.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarAExcel excel = new ExportarAExcel();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string archivoAGuardar = saveDialog.FileName;
                excel.ExportarListaAExcel(personas, archivoAGuardar);
                MessageBox.Show("Archivo Guardado Exitosamente");
            }
        }
    }
}
