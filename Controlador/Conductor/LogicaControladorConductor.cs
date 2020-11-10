using Modelo.Conductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Conductor
{
    public class LogicaControladorConductor
    {

        public int Agregar(int id, string nombre, string tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            AccesoMetodosCRUDConductor negociarAcceso = new AccesoMetodosCRUDConductor();
            return negociarAcceso.InsertarConductor(id, nombre, tipo_licencia,id_vehiculo,id_tipo_conductor);
        }

        public object Listar()
        {
            return AccesoMetodosCRUDConductor.ListarConductores();
        }

        public int Actualizar(int id, string nombre, int tipo_licencia, int id_vehiculo, int id_tipo_conductor)
        {
            AccesoMetodosCRUDConductor negociarAcceso = new AccesoMetodosCRUDConductor();
            return negociarAcceso.ActualizarConductor(id, nombre, tipo_licencia, id_vehiculo, id_tipo_conductor);
        }

        public int Eliminar(int id)
        {
            AccesoMetodosCRUDConductor negociarAcceso = new AccesoMetodosCRUDConductor();
            return negociarAcceso.EliminarConductor(id);
        }
    }
}
