using Modelo.Ruta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Ruta
{
    public class LogicaControladorRuta
    {
        public int Agregar(int id, string estacion, int idVehiculo)
        { 
           AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();
           return negociarAcceso.InsertarRuta(id, estacion, idVehiculo);
        }

        public object Listar()
        {
            return AccesoMetodosCRUDRuta.ListarRuta();
        }

        public int Actualizar(int id, string estacion, int idVehiculo)
        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();
            return negociarAcceso.ActualizarRuta(id, estacion, idVehiculo);
        }

        public int Eliminar(int id)
        {
            AccesoMetodosCRUDRuta negociarAcceso = new AccesoMetodosCRUDRuta();
            return negociarAcceso.EliminarRuta(id);
        }
    }
}
