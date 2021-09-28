using System;
using Xamarin.Forms;
namespace XamarinFormsM1
{
	public partial class App
	{
		public void InitializeComponent()
		{
			Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(App));
		}
	}
}
