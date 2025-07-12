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
        private List<Proveedor> proveedores;
        public FrmProveedores()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\IMG\FrmProveedor.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            proveedores = new List<Proveedor>();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportarExcel excel = new ExportarExcel();
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string archivoAGuardar = saveDialog.FileName;
                excel.ExportarListaAExcel(proveedores, archivoAGuardar);
                MessageBox.Show("Archivo Guardado Exitosamente");
            }
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mercaditoDataSet2.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter1.Fill(this.mercaditoDataSet2.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'mercaditoDataSet1.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.mercaditoDataSet1.Proveedor);

        }
    }
}
