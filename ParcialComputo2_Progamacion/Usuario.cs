using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ParcialComputo2_Progamacion
{
    class Usuario
    {
        public int IDusuarios { get; set; }
        public string Nombresusuario { get; set; }
        public string Apellidosusuario { get; set; }
        public string Correoelectronico { get; set; }
        public string Fechaderegistro { get; set; }
        public string Nombreusuariosistema { get; set; }
        public string Contraseniausuariosistema { get; set; }

        Operaciones_base_de_datos operaciones_Base_De_Datos = new Operaciones_base_de_datos();

        public bool Iniciar_sesion_usuarios()
        {
            string consultasql = "SELECT username, password FROM account WHERE username='" + Nombreusuariosistema + "' AND password='" + Contraseniausuariosistema + "'";

            if (operaciones_Base_De_Datos.Obtenerinformacion_solicitada(consultasql).HasRows)
            {
                return true;
            }
            return false;
        }
        public MySqlDataReader Seleccionar_registros_usuarios()
        {
            string consultasql = "SELECT * FROM account";

            return operaciones_Base_De_Datos.Obtenerinformacion_solicitada(consultasql);
        }
        public MySqlDataReader Buscar_datos_usuario_en_base_de_datos()
        {
            string query = "SELECT * FROM account WHERE username='" + Nombreusuariosistema + "'";

            return operaciones_Base_De_Datos.Obtenerinformacion_solicitada(query);
        }
        public void Capturar_inicio_sesion_usuario()
        {
            string consultasql = "INSERT INTO userlog(codLog, username, timeloggedln) VALUES('','" + Nombreusuariosistema + "','" + DateTime.Now.ToString() + "')";
            operaciones_Base_De_Datos.Ejecutar_consultas_a_base_de_datos(consultasql);
        }
        public MySqlDataReader Seleccionar_registros_logs_usuarios()
        {
            string consultasql = "SELECT * FROM userlog";

            return operaciones_Base_De_Datos.Obtenerinformacion_solicitada(consultasql);
        }
        public void Nuevo_usuario_sistema()
        {
            string consultasql = "INSERT INTO account(codUser, firstname, lastname, email, registerDate, username, password)" +
                   "VALUES ('" + IDusuarios + "', '" + Nombresusuario + "','" + Apellidosusuario + "','" + Correoelectronico + "','" + Fechaderegistro + "','" + Nombreusuariosistema + "','" + Contraseniausuariosistema + "')";
            operaciones_Base_De_Datos.Ejecutar_consultas_a_base_de_datos(consultasql);
        }
    }
}
