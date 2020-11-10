using Controlador.TipoConductor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class GestTipoConductor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(TxtId.Text);
            string tipopersona = TxtTipoPersona.Text;
          

            LogicaControladorTipoConductor tipoConductor = new LogicaControladorTipoConductor();
            int resultadoAddTipoConductor = tipoConductor.Agregar(id, tipopersona);

            if (resultadoAddTipoConductor > 0)
                lblMensaje.Text = "Registro Ok";
            else
                lblMensaje.Text = "No se pudo registrar";

            tipoConductor = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            LogicaControladorTipoConductor tipoConductor = new LogicaControladorTipoConductor();
            GridView.DataSource = tipoConductor.Listar();
            GridView.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(TxtId.Text);
            string tipopersona = TxtTipoPersona.Text;

            LogicaControladorTipoConductor tipoconductor = new LogicaControladorTipoConductor();
            int resultadoUpdateVehiculo = tipoconductor.Actualizar(id, tipopersona);
            if (resultadoUpdateVehiculo > 0)
                lblMensaje.Text = "Actualización Ok";
            else
                lblMensaje.Text = "No se pudo actualizar";

            tipoconductor = null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(TxtId.Text);

            LogicaControladorTipoConductor tipoconductor = new LogicaControladorTipoConductor();
            int resultadoDeleteTipoConductor = tipoconductor.Eliminar(id);
            if (resultadoDeleteTipoConductor > 0)
                lblMensaje.Text = "Dato eliminado con éxito";
            else
                lblMensaje.Text = "No se pudo eliminar";

            tipoconductor = null;
        }
    }
}