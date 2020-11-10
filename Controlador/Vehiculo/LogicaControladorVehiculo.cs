using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Vehiculo;

namespace Controlador.Vehiculo
{
    public class LogicaControladorVehiculo
    {
        public int Agregar(int vehiculoid, string typemarca, string typemodelo, string typeplaca, int anio, int id_tipovehiculo)
        {
            AccesoMetodosCRUDVehiculo negociarAcceso = new AccesoMetodosCRUDVehiculo();
            return negociarAcceso.InsertarVehiculo(vehiculoid, typemarca,  typemodelo,  typeplaca,  anio, id_tipovehiculo);

        }

        public object Listar()
        {
            return AccesoMetodosCRUDVehiculo.ListarVehiculos();
        }

        public int Eliminar(int vehiculoId)
        {
            AccesoMetodosCRUDVehiculo negociarAcceso = new AccesoMetodosCRUDVehiculo();
            return negociarAcceso.EliminarVehiculo(vehiculoId);
        }

        public int Actualizar(int vehiculoid, string typemarca, string typemodelo, string typeplaca, int anio, int id_tipovehiculo)
        {
            AccesoMetodosCRUDVehiculo negociarAcceso = new AccesoMetodosCRUDVehiculo();
            return negociarAcceso.ActualizarVehiculo(vehiculoid,  typemarca, typemodelo, typeplaca, anio, id_tipovehiculo);
        }
    }
}
