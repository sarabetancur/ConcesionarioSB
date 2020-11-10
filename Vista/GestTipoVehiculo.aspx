<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestTipoVehiculo.aspx.cs" Inherits="Vista.GestTipoVehiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Concesionario</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
</head>
<body>

    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a class="navbar-brand" href="#">Concesionario</a>
    </nav>
     <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="navbar-collapse navbar-collapse" id="navbarNav">
         <ul class="navbar-nav">
				<li class="nav-item active">
					<a class="nav-link" href="GestTipoVehiculo.aspx">Tipo Vehiculos</a>
				</li>
				<li class="nav-item">
					<a class="nav-link" href="GestVehiculo.aspx">Vehiculos</a>
				</li>
				<li class="nav-item">
					<a class="nav-link" href="GestTipoConductor.aspx">Tipo Conductor</a>
				</li>
				<li class="nav-item">
					<a class="nav-link" href="GestConductor.aspx">Conductor</a>
				</li>
				<li class="nav-item">
					<a class="nav-link" href="GestContrato.aspx">Contrato</a>
				</li>
				<li class="nav-item">
					<a class="nav-link" href="GestRuta.aspx">Ruta</a>
				</li>
			</ul>
        </div>
    </nav>

	<div class="container">
		<br />
		<h4 class="text-secondary text-center">TIPO DE VEHÍCULO</h4>
		<br />

        <form id="form1" runat="server">
        <div class="form-group">
			<label for="txtId">Id</label>
			<asp:TextBox ID="txtId" runat="server" Class="form-control"></asp:TextBox>
        </div>

	    <div class="form-group">
			<label for="txtName">Name</label>
			<asp:TextBox ID="TxtName" runat="server" Class="form-control"></asp:TextBox>
        </div>
			
		<div class="form-row">
			<div class="col-8">
				<asp:Button ID="btnAdd" runat="server" Text="Agregar" Class="btn btn-info" OnClick="btnAdd_Click1"/>
			</div>
			<div class="col-4 text-right">
              <asp:Button ID="btnList" runat="server" Text="Listar" Class="btn btn-info" OnClick="btnList_Click1" />
			  <asp:Button ID="btnUpdate" runat="server" Text="Actualizar" Class="btn btn-info" onClick="btnUpdate_Click" />
			  <asp:Button ID="btnDelete" runat="server" Text="Eliminar" Class="btn btn-info" onclick ="btnDelete_Click" />
			</div>
		</div>

        <div class="form-row">
			<asp:Label ID="lblMensaje" runat="server" ForeColor="Blue" EnableViewState="false"></asp:Label> 
        </div>
        <br />
			<table class ="table table-bordered">
				<tr>
					<th>
						<asp:GridView ID="GridView" runat="server" AutoGenerateColumns="false">
							<columns>
								<asp:BoundField dataField ="id" HeaderText ="Id" />
								<asp:BoundField dataField ="nombre" HeaderText ="Name" />
							</columns>
						</asp:GridView>
					</th>
				</tr>
			</table>
        </form>

	</div>   
  <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</body>
</html>
