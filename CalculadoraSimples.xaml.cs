using System;
using System.IO;
using Xamarin.Forms;

namespace XamarinFormsM1
{
	public partial class CalculadoraSimples : ContentPage
	{
		public CalculadoraSimples()
		{
			InitializeComponent();
		}
		private void BtExecutar_Clicked(object sender, EventArgs e)
		{
			Double a = 0.0, b = 0.0, t = 0.0;
			a = Convert.ToDouble(etValorA.Text);
			b = Convert.ToDouble(etValorB.Text);
			Button bt = (Button)sender;
			if(bt.Text == "Soma"){
				t = a+b;
			}else if(bt.Text == "Subtração"){
				t = a-b;
			}else if(bt.Text == "Divisão"){
				t = a/b;
			}else if(bt.Text == "Multiplicação"){
				t = a*b;
			}
			lbResp.Text = Convert.ToString(t);
		}
	}
}