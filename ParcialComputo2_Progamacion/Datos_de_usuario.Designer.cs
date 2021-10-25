
namespace ParcialComputo2_Progamacion
{
    partial class Datos_de_usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRegresarMenu = new System.Windows.Forms.Button();
            this.labelNombreApellido = new System.Windows.Forms.Label();
            this.labelCorreoElectronico = new System.Windows.Forms.Label();
            this.labelFechaRegistro = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasenia = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // buttonRegresarMenu
            // 
            this.buttonRegresarMenu.AutoSize = true;
            this.buttonRegresarMenu.BackColor = System.Drawing.Color.MistyRose;
            this.buttonRegresarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresarMenu.Location = new System.Drawing.Point(23, 24);
            this.buttonRegresarMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegresarMenu.Name = "buttonRegresarMenu";
            this.buttonRegresarMenu.Size = new System.Drawing.Size(61, 23);
            this.buttonRegresarMenu.TabIndex = 2;
            this.buttonRegresarMenu.Text = "Ir a menú";
            this.buttonRegresarMenu.UseVisualStyleBackColor = false;
            this.buttonRegresarMenu.Click += new System.EventHandler(this.buttonRegresarMenu_Click);
            // 
            // labelNombreApellido
            // 
            this.labelNombreApellido.AutoSize = true;
            this.labelNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreApellido.Location = new System.Drawing.Point(20, 63);
            this.labelNombreApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreApellido.Name = "labelNombreApellido";
            this.labelNombreApellido.Size = new System.Drawing.Size(136, 20);
            this.labelNombreApellido.TabIndex = 3;
            this.labelNombreApellido.Text = "Nombre y Apellido";
            // 
            // labelCorreoElectronico
            // 
            this.labelCorreoElectronico.AutoSize = true;
            this.labelCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreoElectronico.Location = new System.Drawing.Point(20, 119);
            this.labelCorreoElectronico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCorreoElectronico.Name = "labelCorreoElectronico";
            this.labelCorreoElectronico.Size = new System.Drawing.Size(140, 20);
            this.labelCorreoElectronico.TabIndex = 4;
            this.labelCorreoElectronico.Text = "Correo Electronico";
            // 
            // labelFechaRegistro
            // 
            this.labelFechaRegistro.AutoSize = true;
            this.labelFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaRegistro.Location = new System.Drawing.Point(20, 172);
            this.labelFechaRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaRegistro.Name = "labelFechaRegistro";
            this.labelFechaRegistro.Size = new System.Drawing.Size(140, 20);
            this.labelFechaRegistro.TabIndex = 5;
            this.labelFechaRegistro.Text = "Fecha de Registro";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(20, 223);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(124, 20);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Nombre Usuario";
            // 
            // labelContrasenia
            // 
            this.labelContrasenia.AutoSize = true;
            this.labelContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenia.Location = new System.Drawing.Point(20, 276);
            this.labelContrasenia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContrasenia.Name = "labelContrasenia";
            this.labelContrasenia.Size = new System.Drawing.Size(92, 20);
            this.labelContrasenia.TabIndex = 7;
            this.labelContrasenia.Text = "Contraseña";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(454, 84);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(189, 180);
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "Mi Perfil";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.UseSelectable = true;
            // 
            // Datos_de_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 332);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.labelContrasenia);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelFechaRegistro);
            this.Controls.Add(this.labelCorreoElectronico);
            this.Controls.Add(this.labelNombreApellido);
            this.Controls.Add(this.buttonRegresarMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Datos_de_usuario";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Datos de Usuario";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Datos_de_usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRegresarMenu;
        private System.Windows.Forms.Label labelNombreApellido;
        private System.Windows.Forms.Label labelCorreoElectronico;
        private System.Windows.Forms.Label labelFechaRegistro;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasenia;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}