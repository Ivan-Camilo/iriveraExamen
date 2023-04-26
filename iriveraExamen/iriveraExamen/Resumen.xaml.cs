using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace iriveraExamen
{	
	public partial class Resumen : ContentPage
	{	
		public Resumen (string usuario, string ordenante, double MontoInicial, double Cuota)
		{
			InitializeComponent ();
            lblusuario.Text = usuario;
			lblOrdenante1.Text = ordenante;
			lblMontoInicial1.Text = MontoInicial.ToString();
			lblCuota1.Text = Cuota.ToString("N2");
            lblCuota2.Text = Cuota.ToString("N2");
            lblCuota3.Text = Cuota.ToString("N2");
			var total = MontoInicial + Cuota * 3;
            lblTotal1.Text = total.ToString("N2");
        }
	}
}

