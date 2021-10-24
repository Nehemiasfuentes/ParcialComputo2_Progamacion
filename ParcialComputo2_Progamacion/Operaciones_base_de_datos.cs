using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ParcialComputo2_Progamacion
{
    class Operaciones_base_de_datos
    {
        private Conexion_base_de_datos conexion_base_de_datos = new Conexion_base_de_datos();

        public MySqlDataReader Obtenerinformacion_solicitada(string consultasql)
        {
            MySqlDataReader dataReader;

            conexion_base_de_datos.mysqlcomando = new MySqlCommand(consultasql, conexion_base_de_datos.Abrirconexion());
            dataReader = conexion_base_de_datos.mysqlcomando.ExecuteReader();
            return dataReader;
        }

        public void Ejecutar_consultas_a_base_de_datos(string consultasql)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            conexion_base_de_datos.mysqlcomando = new MySqlCommand(consultasql);
            adapter.InsertCommand = conexion_base_de_datos.mysqlcomando;
            adapter.InsertCommand.ExecuteNonQuery();
            conexion_base_de_datos.mysqlcomando.Dispose();
        }
    }
}
