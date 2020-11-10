using Controlador.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class GestContrato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            int idConductor = Int32.Parse(TxtIdConductor.Text);
            int idVehiculo = Int32.Parse(TxtIdVehiculo.Text);

            LogicaControladorContrato contrato = new LogicaControladorContrato();
            int resultadoAddContrato = contrato.Agregar(id, idConductor, idVehiculo);

            if (resultadoAddContrato > 0)
                lblMensaje.Text = "Registro Ok";
            else
                lblMensaje.Text = "No se pudo registrar";

            contrato = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            LogicaControladorContrato contrato = new LogicaControladorContrato();
            GridView.DataSource = contrato.Listar();
            GridView.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            int idConductor = Int32.Parse(TxtIdConductor.Text);
            int idVehiculo = Int32.Parse(TxtIdVehiculo.Text);

            LogicaControladorContrato contrato = new LogicaControladorContrato();
            int resultadoUpdateContrato = contrato.Actualizar(id,idConductor, idVehiculo);
            if (resultadoUpdateContrato > 0)
                lblMensaje.Text = "Actualización Ok";
            else
                lblMensaje.Text = "No se pudo actualizar";

            contrato = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);

            LogicaControladorContrato contrato = new LogicaControladorContrato();
            int resultadoDeleteContrato = contrato.Eliminar(id);
            if (resultadoDeleteContrato > 0)
                lblMensaje.Text = "Dato eliminado con éxito";
            else
                lblMensaje.Text = "No se pudo eliminar";

            contrato = null;
        }
    }
}