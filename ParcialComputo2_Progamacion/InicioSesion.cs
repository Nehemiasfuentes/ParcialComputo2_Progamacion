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

        private void buttonRegistrarme_Click(object sender, EventArgs e)
        {
            new Registro_usuarios().Show();
            this.Hide();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombreusuariosistema = textBoxNombreUsuario.Text;
            usuario.Contraseniausuariosistema = textBoxContraseñaUsuario.Text;
            usuario.Fechaderegistro = DateTime.Now;
            nombredeusuarioactivo = textBoxNombreUsuario.Text;

            if (usuario.Iniciar_sesion_usuarios() == true)
            {
                usuario.Capturar_inicio_sesion_usuario();
                new Menu_principal().Show();
                this.Hide();
            }
            else
            {
                string mensaje = "No estas registrado, porfavor hazlo en el registro de usuarios";
                MetroFramework.MetroMessageBox.Show(this, mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
