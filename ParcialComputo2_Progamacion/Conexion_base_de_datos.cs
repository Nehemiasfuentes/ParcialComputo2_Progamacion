using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ParcialComputo2_Progamacion
{
    class Conexion_base_de_datos
    {
        private MySqlConnection conexion_bas_de_datos_clase =

           new MySqlConnection("Server=localhost;Database=usuarios;Uid=root;Pwd=usbw; SSL MODE= None");

        public MySqlCommand mysqlcomando;

        public MySqlConnection Abrirconexion()
        {
            if (conexion_bas_de_datos_clase.State == ConnectionState.Closed)
            {
                conexion_bas_de_datos_clase.Open();
            }
            return conexion_bas_de_datos_clase;
        }

        public MySqlConnection Cerrarconexion()
        {
            if (conexion_bas_de_datos_clase.State == ConnectionState.Open)
            {
                conexion_bas_de_datos_clase.Close();
            }
            return conexion_bas_de_datos_clase;
        }
    }
}
