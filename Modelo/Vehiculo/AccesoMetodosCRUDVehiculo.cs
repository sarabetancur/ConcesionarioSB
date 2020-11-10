using Modelo.Compartido;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Vehiculo
{
    public class AccesoMetodosCRUDVehiculo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vehiculoid"></param>
        /// <param name="typemarca"></param>
        /// <param name="typemodelo"></param>
        /// <param name="typeplaca"></param>
        /// <param name="anio"></param>
        /// <param name="cartypeid"></param>
        /// <returns></returns>
        public int InsertarVehiculo(int vehiculoid, string typemarca, string typemodelo, string typeplaca, int anio, int id_tipovehiculo)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("addVehiculo");

            _comando.Parameters.AddWithValue("@id", vehiculoid);
            _comando.Parameters.AddWithValue("@marca", typemarca);
            _comando.Parameters.AddWithValue("@modelo", typemodelo);
            _comando.Parameters.AddWithValue("@placa", typeplaca);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tipovehiculo", id_tipovehiculo);

            return MetodosCRUD.EjecutarComando(_comando);
        }

        public static object ListarVehiculos()
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoSelect();

            _comando.CommandText = "select * from dbo.vehiculo";

            return MetodosCRUD.EjecutarComandoSelect(_comando);
        }

        public int EliminarVehiculo(int vehiculoId)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("deleteVehiculo");

            _comando.Parameters.AddWithValue("@id", vehiculoId);

            return MetodosCRUD.EjecutarComando(_comando);
        }

        public int ActualizarVehiculo(int vehiculoid, string typemarca, string typemodelo, string typeplaca, int anio, int id_tipovehiculo)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("updateVehiculo");

            _comando.Parameters.AddWithValue("@id", vehiculoid);
            _comando.Parameters.AddWithValue("@marca", typemarca);
            _comando.Parameters.AddWithValue("@modelo", typemodelo);
            _comando.Parameters.AddWithValue("@placa", typeplaca);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tipovehiculo", id_tipovehiculo);

            return MetodosCRUD.EjecutarComando(_comando);
        }
    }
    
}
