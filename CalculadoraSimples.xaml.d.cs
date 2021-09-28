using System;
using Xamarin.Forms;
namespace XamarinFormsM1
{
	public partial class CalculadoraSimples
	{
		internal Entry etValorA;
		internal Entry etValorB;
		internal Label lbResp;
		public void InitializeComponent()
		{
			Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(CalculadoraSimples));
				etValorA = this.FindByName<Entry>("etValorA");
				etValorB = this.FindByName<Entry>("etValorB");
				lbResp = this.FindByName<Label>("lbResp");
		}
	}
}
