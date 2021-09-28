using System;
using System.IO;
using Xamarin.Forms;

namespace XamarinFormsM1
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			
			MainPage = new XamarinFormsM1.CalculadoraSimples();

		}
	}
}