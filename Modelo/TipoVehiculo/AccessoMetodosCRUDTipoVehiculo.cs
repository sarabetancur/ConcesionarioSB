using Modelo.Compartido;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoVehiculo
{
    public class AccessoMetodosCRUDTipoVehiculo
    {

        public static DataTable ListTipoVehiculo()
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoSelect();

            _comando.CommandText = "select * from dbo.tipo_vehiculo";

            return MetodosCRUD.EjecutarComandoSelect(_comando);
        }

       
        public int InsertTipoVehiculo(int id, string nombre)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("addTipoVehiculo");

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUD.EjecutarComando(_comando);
        }


        public int UpdateTipoVehiculo(int id, string nombre)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("updateTipoVehiculo");
               
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);

            return MetodosCRUD.EjecutarComando(_comando);
        }

        //Operacion Delete
        public int DeleteTipoVehiculo(int id)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("deleteTipoVehiculo");

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUD.EjecutarComando(_comando);
        }

        
    }
}
