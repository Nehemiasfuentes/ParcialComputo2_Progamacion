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
    public partial class Usuarios_registrados : MetroFramework.Forms.MetroForm
    {
        public Usuarios_registrados()
        {
            InitializeComponent();
        }

        private void buttonRegresarMenu_Click(object sender, EventArgs e)
        {
            new Menu_principal().Show();
            this.Hide();
        }

        private void LlenarData()
        {
            dgUsuarios.Rows.Clear();
            dgUsuarios.Columns.Clear();

            dgUsuarios.Columns.Add("codUser", "Codigo Usuario");
            dgUsuarios.Columns.Add("Nombresusuario", "Nombres de Usuario");
             dgUsuarios.Columns.Add("Apellidosusuario", "Apellidos del Usuario");
             dgUsuarios.Columns.Add("Correoelectronico","Correro Electronico");
             dgUsuarios.Columns.Add("Fechaderegistro", "Fecha de Registro");
             dgUsuarios.Columns.Add("Nombreusuariosistema","Usuario");
             dgUsuarios.Columns.Add("Contraseniausuariosistema", "COntraseña");

            Usuario usuario = new Usuario();

            MySqlDataReader datos = usuario.Seleccionar_registros_usuarios();

            while (datos.Read())
            {
               dgUsuarios.Rows.Add(
               datos.GetValue(0),
               datos.GetValue(1),
               datos.GetValue(2),
               datos.GetValue(3),
               datos.GetValue(4),
               datos.GetValue(5),
               datos.GetValue(6));
            }

        }

        private void Usuarios_registrados_Load(object sender, EventArgs e)
        {
            LlenarData();
        }
    }
}
