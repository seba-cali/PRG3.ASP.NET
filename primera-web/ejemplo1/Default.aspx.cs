using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemplo1
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{//reemplazar por nombre

			//if(Request.QueryString["nombre"] != null)
			//{
			//string user = Request.QueryString["nombre"].ToString();
			//lblUser.Text = user +" tu ingreso fue exitoso";

			//}
			//else
			//{
			//	lblUser.Text = "No ingreso ningun usuario";
			//}

			//operador ternario
			string user = Request.QueryString["nombre"] != null ? Request.QueryString["nombre"].ToString() : "Logueate";
			lblUser.Text = user + " tu ingreso fue exitoso";

		}
	}
}