using Modelo.Compartido;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Ruta
{
    public class AccesoMetodosCRUDRuta
    {
        public int InsertarRuta(int id, string estacion, int idVehiculo)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("addRuta");

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@id_vehiculo", idVehiculo);

            return MetodosCRUD.EjecutarComando(_comando);
        }

        public static object ListarRuta()
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoSelect();

            _comando.CommandText = "select * from dbo.ruta";

            return MetodosCRUD.EjecutarComandoSelect(_comando);
        }

        public int ActualizarRuta(int id, string estacion, int idVehiculo)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("updateRuta");

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@id_vehiculo", idVehiculo);

            return MetodosCRUD.EjecutarComando(_comando);
        }

        public int EliminarRuta(int id)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("deleteRuta");

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUD.EjecutarComando(_comando);
        }
    }
}
