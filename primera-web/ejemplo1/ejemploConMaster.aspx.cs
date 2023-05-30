using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//cambio
namespace ejemplo1
{
	public partial class ejemploConMaster : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)//entra solo si es la primera vez que se carga la pagina
				txtNombre.Text = "Ingrese su nombre..";
		}

		protected void btnAceptar_Click(object sender, EventArgs e)
		{
			string nombre = txtNombre.Text;
			string password = txtPassword.Text;
			lblsaludo.Text = "Hola " + nombre;

			Session.Add("usuario", nombre);
			Session.Add("pass", password);


			Response.Redirect("Default.aspx", false);

			//Response.Redirect("Default.aspx?nombre=" + nombre + "&pass=" +txtPassword.Text, false);

			//Response.Redirect("ejemploASPX.aspx", false);//Esta practica es para redireccionar a otra pagina, se dice que es una accion pesada para el servidor. false es para que no cancele la ejecucion de la pagina actual. entonces, si hay mas instrucciones abajo, se van a seguir ejecutando.
		}
		//evento textChanged
		protected void txtNombre_TextChanged(object sender, EventArgs e)
		{
			lblSecundario.Text = txtNombre.Text;
		}
	}
}