
namespace ParcialComputo2_Progamacion
{

    partial class Usuarios_registrados
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
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegresarMenu
            // 
            this.buttonRegresarMenu.AutoSize = true;
            this.buttonRegresarMenu.BackColor = System.Drawing.Color.MistyRose;
            this.buttonRegresarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresarMenu.Location = new System.Drawing.Point(40, 24);
            this.buttonRegresarMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegresarMenu.Name = "buttonRegresarMenu";
            this.buttonRegresarMenu.Size = new System.Drawing.Size(61, 23);
            this.buttonRegresarMenu.TabIndex = 2;
            this.buttonRegresarMenu.Text = "Ir a menú";
            this.buttonRegresarMenu.UseVisualStyleBackColor = false;
            this.buttonRegresarMenu.Click += new System.EventHandler(this.buttonRegresarMenu_Click);
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(17, 81);
            this.dgUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.RowHeadersWidth = 51;
            this.dgUsuarios.RowTemplate.Height = 24;
            this.dgUsuarios.Size = new System.Drawing.Size(488, 248);
            this.dgUsuarios.TabIndex = 3;
            // 
            // Usuarios_registrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 366);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.buttonRegresarMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Usuarios_registrados";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Usuarios Registrados";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Usuarios_registrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegresarMenu;
        private System.Windows.Forms.DataGridView dgUsuarios;
    }
}