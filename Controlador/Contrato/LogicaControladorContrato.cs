using Modelo.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Contrato
{
    public class LogicaControladorContrato
    {
        public int Agregar(int id, int idConductor, int idVehiculo)
        {
            AccesoMetodosCRUDContrato negociarAcceso = new AccesoMetodosCRUDContrato();
            return negociarAcceso.InsertarContrato(id, idConductor, idVehiculo);
        }

        public object Listar()
        {
            return AccesoMetodosCRUDContrato.ListarContrato();
        }

        public int Actualizar(int id, int idConductor, int idVehiculo)
        {
            AccesoMetodosCRUDContrato negociarAcceso = new AccesoMetodosCRUDContrato();
            return negociarAcceso.ActualizarContrato(id, idConductor, idVehiculo);
        }

        public int Eliminar(int id)
        {
            AccesoMetodosCRUDContrato negociarAcceso = new AccesoMetodosCRUDContrato();
            return negociarAcceso.EliminarContrato(id);
        }
    }
}
