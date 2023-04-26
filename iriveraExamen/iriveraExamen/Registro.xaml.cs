using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace iriveraExamen
{	
	public partial class Registro : ContentPage
	{
       
        public Registro (string usuario)
		{
			InitializeComponent ();
            DisplayAlert("Advertencia", "\nSolo ingresar valores entre 0 y 3000", "OK");
            lblusuario.Text =  usuario;
            
        }

        void Calcular_Clicked(System.Object sender, System.EventArgs e)
        {
            var MontoInicial = double.Parse(txtMontoInicial.Text);
            var Saldo = 3000 - MontoInicial;
            var Cuota = (Saldo / 3) + (3000 * 5 / 100);
            
            lblCuota1.Text = Cuota.ToString("N2");
            lblCuota2.Text = Cuota.ToString("N2");
            lblCuota3.Text = Cuota.ToString("N2");

        }

        void Guardar_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Informacion", "\nElemento Guardado con Exito", "OK");
            string usuario = lblusuario.Text;
            string ordenante = txtOrdenante.Text;
            var MontoInicial = double.Parse(txtMontoInicial.Text);
            var Saldo = 3000 - MontoInicial;
            var Cuota = (Saldo / 3) + (3000 * 5 / 100);
            Navigation.PushAsync(new Resumen(usuario, ordenante, MontoInicial, Cuota));
        }
    }
}

