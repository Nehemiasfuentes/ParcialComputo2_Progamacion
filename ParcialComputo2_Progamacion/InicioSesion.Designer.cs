
namespace ParcialComputo2_Progamacion
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.buttonRegistrarme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(39, 124);
            this.textBoxNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombreUsuario.Multiline = true;
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(289, 28);
            this.textBoxNombreUsuario.TabIndex = 3;
            // 
            // textBoxContraseñaUsuario
            // 
            this.textBoxContraseñaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseñaUsuario.Location = new System.Drawing.Point(39, 234);
            this.textBoxContraseñaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContraseñaUsuario.Multiline = true;
            this.textBoxContraseñaUsuario.Name = "textBoxContraseñaUsuario";
            this.textBoxContraseñaUsuario.Size = new System.Drawing.Size(289, 28);
            this.textBoxContraseñaUsuario.TabIndex = 4;
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarSesion.Location = new System.Drawing.Point(84, 301);
            this.buttonIniciarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(212, 46);
            this.buttonIniciarSesion.TabIndex = 5;
            this.buttonIniciarSesion.Text = "Iniciar Sesion";
            this.buttonIniciarSesion.UseVisualStyleBackColor = false;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // buttonRegistrarme
            // 
            this.buttonRegistrarme.AutoSize = true;
            this.buttonRegistrarme.BackColor = System.Drawing.Color.Plum;
            this.buttonRegistrarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarme.Location = new System.Drawing.Point(132, 376);
            this.buttonRegistrarme.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegistrarme.Name = "buttonRegistrarme";
            this.buttonRegistrarme.Size = new System.Drawing.Size(106, 32);
            this.buttonRegistrarme.TabIndex = 6;
            this.buttonRegistrarme.Text = "Registrarme";
            this.buttonRegistrarme.UseVisualStyleBackColor = false;
            this.buttonRegistrarme.Click += new System.EventHandler(this.buttonRegistrarme_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 447);
            this.Controls.Add(this.buttonRegistrarme);
            this.Controls.Add(this.buttonIniciarSesion);
            this.Controls.Add(this.textBoxContraseñaUsuario);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InicioSesion";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Inicio Sesion";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.TextBox textBoxContraseñaUsuario;
        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.Button buttonRegistrarme;
    }
}