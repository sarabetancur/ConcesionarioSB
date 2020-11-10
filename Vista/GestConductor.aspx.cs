using Controlador.Conductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class GestConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(TxtId.Text);
            string nombre = TxtNombre.Text;
            string tipo_licencia =TxtTipoLicencia.Text;
            int id_vehiculo = Int32.Parse(TxtIdVehiculo.Text);
            int id_tipo_conductor = Int32.Parse(TxtIdTipoConductor.Text);

            LogicaControladorConductor conductor = new LogicaControladorConductor();
            int resultadoAddConductor = conductor.Agregar(id, nombre, tipo_licencia, id_vehiculo, id_tipo_conductor);

            if (resultadoAddConductor> 0)
                lblMensaje.Text = "Registro Ok";
            else
                lblMensaje.Text = "No se pudo registrar";

            conductor = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            LogicaControladorConductor conductor = new LogicaControladorConductor();
            GridView.DataSource = conductor.Listar();
            GridView.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(TxtId.Text);
            string nombre = TxtNombre.Text;
            int tipo_licencia = Int32.Parse(TxtTipoLicencia.Text);
            int id_vehiculo = Int32.Parse(TxtIdVehiculo.Text);
            int id_tipo_conductor = Int32.Parse(TxtIdTipoConductor.Text);

            LogicaControladorConductor conductor = new LogicaControladorConductor();
            int resultadoAddVehiculo = conductor.Actualizar(id, nombre, tipo_licencia, id_vehiculo, id_tipo_conductor);

            if (resultadoAddVehiculo > 0)
                lblMensaje.Text = "Datos actualizados";
            else
                lblMensaje.Text = "No se pudo Actualizar";

            conductor = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(TxtId.Text);

            LogicaControladorConductor conductor = new LogicaControladorConductor();
            int resultadoDeleteVehiculo = conductor.Eliminar(id);
            if (resultadoDeleteVehiculo > 0)
                lblMensaje.Text = "Dato eliminado con éxito";
            else
                lblMensaje.Text = "No se pudo eliminar";

            conductor = null;
        }
    }
}