using Modelo.Compartido;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Contrato
{
    public class AccesoMetodosCRUDContrato
    {
        public int InsertarContrato(int id, int idConductor, int idVehiculo)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("addContrato");

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_conductor", idConductor);
            _comando.Parameters.AddWithValue("@id_vehiculo", idVehiculo);

            return MetodosCRUD.EjecutarComando(_comando);
        }

        public static object ListarContrato()
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoSelect();

            _comando.CommandText = "select * from dbo.contrato";

            return MetodosCRUD.EjecutarComandoSelect(_comando);
        }

        public int ActualizarContrato(int id, int idConductor, int idVehiculo)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("updateContrato");

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@id_conductor", idConductor);
            _comando.Parameters.AddWithValue("@id_vehiculo", idVehiculo);

            return MetodosCRUD.EjecutarComando(_comando);
        }

        public int EliminarContrato(int id)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("deleteContrato");

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUD.EjecutarComando(_comando);
        }
    }
}
