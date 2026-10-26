using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace Escuela
{
    public static class ConexionBD
    {
        public static OleDbConnection ObtenerConexion()
        {
            string rutaBD = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Datos",
                "Escuela.accdb"
                );
            string cadenaConexion =
                $"Provider=Microsoft.ACE.OLEDB.12.0;" +
                $"Data Source={rutaBD};";

            return new OleDbConnection(cadenaConexion);
        }
    }
}
