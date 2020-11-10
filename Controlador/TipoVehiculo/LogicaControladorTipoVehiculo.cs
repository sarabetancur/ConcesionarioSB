using Modelo.TipoVehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.TipoVehiculo
{
    public class LogicaControladorTipoVehiculo
    {
        //Negociar INSERT
        public int NegociarInsertTipoVehiculo(int id, string nombre)
        {
            AccessoMetodosCRUDTipoVehiculo negociarAcceso = new AccessoMetodosCRUDTipoVehiculo();
            return negociarAcceso.InsertTipoVehiculo(id, nombre);
        }

        //Negociar Select
        public static DataTable NegociarSelectTipoVehiculo()
        {
            return AccessoMetodosCRUDTipoVehiculo.ListTipoVehiculo();
        }
        // Negociar Update
        public int NegociarUpdateTipoVehiculo(int id, string nombre)
        {
            AccessoMetodosCRUDTipoVehiculo negociarAcceso = new AccessoMetodosCRUDTipoVehiculo();
            return negociarAcceso.UpdateTipoVehiculo(id, nombre);
        }

        // Negociar Delete
        public int NegociarDeleteTipoVehiculo(int id)
        {
            AccessoMetodosCRUDTipoVehiculo negociarAcceso = new AccessoMetodosCRUDTipoVehiculo();
            return negociarAcceso.DeleteTipoVehiculo(id);
        }

    }
}
