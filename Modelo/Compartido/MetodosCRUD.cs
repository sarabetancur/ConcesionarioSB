using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Compartido
{
    public class MetodosCRUD
    {

        /// <summary>
        /// Crea un procedimiento almacenado.
        /// </summary>
        /// <param name="procedimiento">El nombre del procedimiento.</param>
        /// <returns>El comando a ejecutar</returns>
        public static SqlCommand CrearComandoProcedimiento(string procedimiento)
        {
            SqlConnection _conexion = new SqlConnection(Configuracion.CadenaConexion);
            SqlCommand _comando = new SqlCommand(procedimiento, _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SqlCommand CrearComandoSelect()
        {
            SqlConnection _conexion = new SqlConnection(Configuracion.CadenaConexion);
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;
        }

        public static DataTable EjecutarComandoSelect(SqlCommand comando)
        {
            DataTable _table = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adpater = new SqlDataAdapter();
                adpater.SelectCommand = comando;
                adpater.Fill(_table);
            }
            catch (Exception Ex) { throw Ex; }
            finally
            {
                comando.Connection.Close();
            }

            return _table;
        }

        /// <summary>
        /// Ejecuta los comandos
        /// </summary>
        /// <param name="comando">El comando</param>
        /// <returns>El comando ejecutado</returns>
        public static int EjecutarComando(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

    }
}

