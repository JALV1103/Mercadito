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
    public partial class FrmLogin : Form
    {
        public class Din
        {
            public string usuario { get; set; }
            public string contrasena { get; set; }
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Din myDin = new Din();
            myDin.usuario = txtUsuario.Text;
            myDin.contrasena = txtContrasena.Text;

            // Se procede a condicionar 
            if (myDin.usuario == "Admin" && myDin.contrasena == "Admin123")
            {
                FrmMenu main = new FrmMenu();
                main.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
