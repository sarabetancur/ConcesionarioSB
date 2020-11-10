using Modelo.TipoConductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.TipoConductor
{
    public class LogicaControladorTipoConductor
    {
        public int Agregar(int id, string tipopersona)
        {
            AccesoMetodosCRUDTipoConductor negociarAcceso = new AccesoMetodosCRUDTipoConductor();
            return negociarAcceso.InsertarTipoConductor(id, tipopersona);

        }

        public object Listar()
        {
            return AccesoMetodosCRUDTipoConductor.ListarTipoConductor();
        }

        public int Actualizar(int id, string tipopersona)
        {
            AccesoMetodosCRUDTipoConductor negociarAcceso = new AccesoMetodosCRUDTipoConductor();
            return negociarAcceso.ActualizarTipoConductor(id, tipopersona);
        }

        public int Eliminar(int id)
        {
            AccesoMetodosCRUDTipoConductor negociarAcceso = new AccesoMetodosCRUDTipoConductor();
            return negociarAcceso.EliminarTipoConductor(id);
        }
    }
}
