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
    public partial class Registro_usuarios : MetroFramework.Forms.MetroForm
    {
        public Registro_usuarios()
        {
            InitializeComponent();
        }
        private void Iniciarsesion_botton_Click(object sender, EventArgs e)
        {
            new InicioSesion().Show();
            this.Hide();
        }

        private void RegisrarseBoton_Click(object sender, EventArgs e)
        {
            string aviso = "Debe completar los campos vacios, para poder registrarse";
            if (textBoxNombres.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, aviso, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNombres.Focus();
            }
            else if (textBoxApellidos.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, aviso, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxApellidos.Focus();
            }
            else if (textBoxCorreo.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, aviso, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCorreo.Focus();
            }
            else if (textBoxNombreUsuario.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, aviso, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNombreUsuario.Focus();
            }
            else if (textBoxContrasenia.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, aviso, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxContrasenia.Focus();
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.Nombresusuario = textBoxNombres.Text;
                usuario.Apellidosusuario = textBoxApellidos.Text;
                usuario.Correoelectronico = textBoxCorreo.Text;
                usuario.Fechaderegistro = DateTime.Now.ToString();
                usuario.Nombreusuariosistema = textBoxNombreUsuario.Text;
                usuario.Contraseniausuariosistema = textBoxContrasenia.Text;

                string avisonuevo = "¿Estas seguro, que deseas registrarte?";
                if (MetroFramework.MetroMessageBox.Show(this, avisonuevo, "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usuario.Nuevo_usuario_sistema();

                        MetroFramework.MetroMessageBox.Show(this, "Bienvenido al sistema" , "AVISO", MessageBoxButtons.OK , MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Lamentamos informarte que no te has podido registrar." ,  "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            Limpiar_textbox();
        }
            public void Limpiar_textbox()
            {
                textBoxNombres.Text = "";
                textBoxApellidos.Text = "";
                textBoxCorreo.Text = "";
                textBoxNombreUsuario.Text = "";
                textBoxContrasenia.Text = "";
            }
    }
}
