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
    public partial class InicioSesion : MetroFramework.Forms.MetroForm
    {
        public static string nombredeusuarioactivo;
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarme_Click(object sender, EventArgs e)
        {
            new Registro_usuarios().Show();
            this.Hide();
        }
    }
}
