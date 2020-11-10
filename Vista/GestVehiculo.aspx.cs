using Controlador.Vehiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class GestVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int vehiculoid = Int32.Parse(txtId.Text);
            string typemarca = TxtMarca.Text;
            string typemodelo = TxtModelo.Text;
            string typeplaca = TxtPlaca.Text;
            int anio = Int32.Parse(txtAnio.Text);
            int id_tipovehiculo = Int32.Parse(txtIdTipoVehiculo.Text);

            LogicaControladorVehiculo vehiculo = new LogicaControladorVehiculo();
            int resultadoAddVehiculo = vehiculo.Agregar(vehiculoid, typemarca, typemodelo, typeplaca, anio, id_tipovehiculo);            

            if (resultadoAddVehiculo > 0)
                lblMensaje.Text = "Registro Ok";
            else
                lblMensaje.Text = "No se pudo registrar";

            vehiculo = null;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int vehiculoid = Int32.Parse(txtId.Text);
            string typemarca = TxtMarca.Text;
            string typemodelo = TxtModelo.Text;
            string typeplaca = TxtPlaca.Text;
            int anio = Int32.Parse(txtAnio.Text);
            int id_tipovehiculo = Int32.Parse(txtIdTipoVehiculo.Text);

            LogicaControladorVehiculo vehiculo = new LogicaControladorVehiculo();
            int resultadoUpdateVehiculo = vehiculo.Actualizar(vehiculoid, typemarca, typemodelo, typeplaca, anio, id_tipovehiculo);
            if (resultadoUpdateVehiculo > 0)
                lblMensaje.Text = "Actualización Ok";
            else
                lblMensaje.Text = "No se pudo actualizar";

            vehiculo= null;
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            LogicaControladorVehiculo vehiculo = new LogicaControladorVehiculo();
            GridView.DataSource = vehiculo.Listar();
            GridView.DataBind();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int vehiculoId = Int32.Parse(txtId.Text);

            LogicaControladorVehiculo vehiculo = new LogicaControladorVehiculo();
            int resultadoDeleteVehiculo = vehiculo.Eliminar(vehiculoId);
            if (resultadoDeleteVehiculo > 0)
                lblMensaje.Text = "Dato eliminado con éxito";
            else
                lblMensaje.Text = "No se pudo eliminar";

            vehiculo = null;
        }
    }
}