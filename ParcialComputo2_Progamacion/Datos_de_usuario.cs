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
    public partial class Datos_de_usuario : MetroFramework.Forms.MetroForm
    {
        public Datos_de_usuario()
        {
            InitializeComponent();
        }

        private void buttonRegresarMenu_Click(object sender, EventArgs e)
        {
            new Menu_principal();
            this.Hide();
        }

        private void Datos_de_usuario_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            MySqlDataReader datos = usuario.Buscar_datos_usuario_en_base_de_datos();

            while (datos.Read())
            {
                labelNombreApellido.Text = datos.GetValue(1).ToString() +" "+ datos.GetValue(2).ToString();
                labelCorreoElectronico.Text = datos.GetValue(3).ToString();
                labelFechaRegistro.Text = datos.GetValue(4).ToString();
                labelUsuario.Text = datos.GetValue(5).ToString();
                labelContrasenia.Text = datos.GetValue(6).ToString();

            }
        }
    }
}
