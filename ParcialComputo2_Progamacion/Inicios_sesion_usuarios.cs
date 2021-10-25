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
    public partial class Inicios_sesion_usuarios : MetroFramework.Forms.MetroForm
    {
        public Inicios_sesion_usuarios()
        {
            InitializeComponent();
        }

        private void buttonRegresarMenu_Click(object sender, EventArgs e)
        {
            new Menu_principal().Show();
            this.Hide();
        }
        private void Inicios_sesion_usuarios_Load(object sender, EventArgs e)
        {
            dataGridViewInicios_sesion_usuarios_tabla_userlogs.Rows.Clear();
            dataGridViewInicios_sesion_usuarios_tabla_userlogs.Columns.Clear();

            dataGridViewInicios_sesion_usuarios_tabla_userlogs.Columns.Add("codLogUser", "Codigo Log Usuario");
            dataGridViewInicios_sesion_usuarios_tabla_userlogs.Columns.Add("Nombreusuariosistema", "Usuario");
            dataGridViewInicios_sesion_usuarios_tabla_userlogs.Columns.Add("FechadeInicioSesion", "Inicio Sesion");

            Usuario usuario = new Usuario();

            MySqlDataReader datos = usuario.Seleccionar_registros_logs_usuarios();

            while (datos.Read())
            {
                dataGridViewInicios_sesion_usuarios_tabla_userlogs.Rows.Add(
                datos.GetValue(0),
                datos.GetValue(1),
                datos.GetValue(2));
            }
        }
    }
}
