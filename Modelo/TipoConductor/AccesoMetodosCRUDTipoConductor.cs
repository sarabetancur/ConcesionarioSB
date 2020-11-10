using Modelo.Compartido;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoConductor
{
    public class AccesoMetodosCRUDTipoConductor
    {
        public int InsertarTipoConductor(int id, string tipopersona)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("addTipo_Conductor");

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@tipo_persona", tipopersona);
         
            return MetodosCRUD.EjecutarComando(_comando);
        }

        public static object ListarTipoConductor()
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoSelect();

            _comando.CommandText = "select * from dbo.tipo_conductor";

            return MetodosCRUD.EjecutarComandoSelect(_comando);
        }

        public int ActualizarTipoConductor(int id, string tipopersona)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("updateTipoConductor");

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@tipo_persona", tipopersona );
      
            return MetodosCRUD.EjecutarComando(_comando);
        }

        public int EliminarTipoConductor(int id)
        {
            SqlCommand _comando = MetodosCRUD.CrearComandoProcedimiento("deleteTipoConductor");

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUD.EjecutarComando(_comando);
        }
    }
}
