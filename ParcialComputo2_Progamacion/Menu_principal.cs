using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParcialComputo2_Progamacion
{
    public partial class Menu_principal :MetroFramework.Forms.MetroForm
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {
            if (InicioSesion.nombredeusuarioactivo.ToString() != "Admin")
            {
                metroTile1.Visible = false;
                metroTile2.Visible = false;
            }
            else
            {
                
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            new Inicios_sesion_usuarios().Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            new Datos_de_usuario().Show();
            this.Hide();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            new Usuarios_registrados().Show();
            this.Hide();
        }
    }
}
