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
        private List<Venta> venta; 

        public FrmVenta()
        {
            InitializeComponent();

            Bitmap img = new Bitmap(Application.StartupPath + @"\IMG\FrmVenta.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            venta = new List<Venta>();
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
                string archivoAGuardar =saveDialog.FileName;
                excel.ExportarListaAExcel(venta, archivoAGuardar);
                MessageBox.Show("Archivo Guardado Exitosamente");
            }
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mercaditoDataSet1.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.mercaditoDataSet1.Venta);

        }
    }
}