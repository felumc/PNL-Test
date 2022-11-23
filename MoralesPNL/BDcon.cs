using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoralesPNL
{
    public class BDcon
    {
        public static NpgsqlConnection ObtenerConexion()
        {
            NpgsqlConnection conectar = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=ximena2004;Database=PNL");
            conectar.Open();
            return conectar;
        }
        public static NpgsqlConnection CerrarConexion()
        {
            NpgsqlConnection desconectar = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=ximena2004;Database=PNL");
            desconectar.Close();
            return desconectar;
        }
    }
}
