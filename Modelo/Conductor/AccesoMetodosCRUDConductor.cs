using Modelo.Compartido;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
    public class AccesoMetodosCRUDConductor
    {

        public int InsertarConductor (int id, string nombre, string tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("addConductor");

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tipo_licencia", tipo_licencia);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", id_tipo_conductor);
   

            return MetodosCRUD.EjecutarComando(_comando);
        }

        public static object ListarConductores()
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoSelect();

            _comando.CommandText = "select * from dbo.conductor";

            return MetodosCRUD.EjecutarComandoSelect(_comando);
        }

        public int ActualizarConductor(int id, string nombre, int tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("updateConductor");

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("tipo_licencia", tipo_licencia);
            _comando.Parameters.AddWithValue("@id_vehiculo",id_vehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", id_tipo_conductor);

            return MetodosCRUD.EjecutarComando(_comando);
        }

        public int EliminarConductor(int id)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("deleteConductor");

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUD.EjecutarComando(_comando);
        }
    }
}
