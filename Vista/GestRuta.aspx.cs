using Controlador.Ruta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class GestRuta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string estacion = TxtEstacion.Text;
            int idVehiculo = Int32.Parse(TxtIdVehiculo.Text);

            LogicaControladorRuta ruta = new LogicaControladorRuta();
            int resultadoAddRuta = ruta.Agregar(id, estacion, idVehiculo);

            if (resultadoAddRuta > 0)
                lblMensaje.Text = "Registro Ok";
            else
                lblMensaje.Text = "No se pudo registrar";

            ruta = null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            LogicaControladorRuta ruta = new LogicaControladorRuta();
            GridView.DataSource = ruta.Listar();
            GridView.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            string estacion = TxtEstacion.Text;
            int idVehiculo = Int32.Parse(TxtIdVehiculo.Text);

            LogicaControladorRuta ruta = new LogicaControladorRuta();
            int resultadoUpdateRuta= ruta.Actualizar(id, estacion, idVehiculo);
            if (resultadoUpdateRuta > 0)
                lblMensaje.Text = "Actualización Ok";
            else
                lblMensaje.Text = "No se pudo actualizar";

            ruta= null;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);

            LogicaControladorRuta ruta = new LogicaControladorRuta();
            int resultadoDeleteRuta = ruta.Eliminar(id);
            if (resultadoDeleteRuta > 0)
                lblMensaje.Text = "Dato eliminado con éxito";
            else
                lblMensaje.Text = "No se pudo eliminar";

            ruta = null;
        }
    }
}