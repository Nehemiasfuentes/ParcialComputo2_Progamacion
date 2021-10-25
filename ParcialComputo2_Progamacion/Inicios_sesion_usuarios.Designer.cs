
namespace ParcialComputo2_Progamacion
{
    partial class Inicios_sesion_usuarios
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
            this.dataGridViewInicios_sesion_usuarios_tabla_userlogs = new System.Windows.Forms.DataGridView();
            this.buttonRegresarMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInicios_sesion_usuarios_tabla_userlogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInicios_sesion_usuarios_tabla_userlogs
            // 
            this.dataGridViewInicios_sesion_usuarios_tabla_userlogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInicios_sesion_usuarios_tabla_userlogs.Location = new System.Drawing.Point(52, 64);
            this.dataGridViewInicios_sesion_usuarios_tabla_userlogs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewInicios_sesion_usuarios_tabla_userlogs.Name = "dataGridViewInicios_sesion_usuarios_tabla_userlogs";
            this.dataGridViewInicios_sesion_usuarios_tabla_userlogs.RowHeadersWidth = 51;
            this.dataGridViewInicios_sesion_usuarios_tabla_userlogs.RowTemplate.Height = 24;
            this.dataGridViewInicios_sesion_usuarios_tabla_userlogs.Size = new System.Drawing.Size(332, 258);
            this.dataGridViewInicios_sesion_usuarios_tabla_userlogs.TabIndex = 0;
            // 
            // buttonRegresarMenu
            // 
            this.buttonRegresarMenu.AutoSize = true;
            this.buttonRegresarMenu.BackColor = System.Drawing.Color.MistyRose;
            this.buttonRegresarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresarMenu.Location = new System.Drawing.Point(32, 20);
            this.buttonRegresarMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRegresarMenu.Name = "buttonRegresarMenu";
            this.buttonRegresarMenu.Size = new System.Drawing.Size(61, 23);
            this.buttonRegresarMenu.TabIndex = 1;
            this.buttonRegresarMenu.Text = "Ir a menú";
            this.buttonRegresarMenu.UseVisualStyleBackColor = false;
            this.buttonRegresarMenu.Click += new System.EventHandler(this.buttonRegresarMenu_Click);
            // 
            // Inicios_sesion_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 366);
            this.Controls.Add(this.buttonRegresarMenu);
            this.Controls.Add(this.dataGridViewInicios_sesion_usuarios_tabla_userlogs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Inicios_sesion_usuarios";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Inicios Sesion Usuarios";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInicios_sesion_usuarios_tabla_userlogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInicios_sesion_usuarios_tabla_userlogs;
        private System.Windows.Forms.Button buttonRegresarMenu;
    }
}