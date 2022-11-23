using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoralesPNL
{
    public class UsuarioDAO
    {
        public static int Agregar_Usuario(Usuario Usuario)
        {
            int retorno = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("Insert into respuestas (nombre, fechanac, correo, celular, fecha, hora, visual, auditivo, cinestesico, resultado) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
            Usuario.Nombre,Usuario.FechaNa,Usuario.Correo,Usuario.Celular, Usuario.Fecha, Usuario.Hora, Usuario.Visual, Usuario.Auditivo, Usuario.Cinestesico, Usuario.Resultado), BDcon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            BDcon.CerrarConexion();
            return retorno;
        }
    }
}
