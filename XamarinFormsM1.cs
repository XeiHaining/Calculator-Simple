using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinFormsM1
{

	public class Program
	{
		public static void Main()
		{
			Ui.RunOnUiThread(() =>
			{
				Ui.LoadApplication(new App());
			});
		}
	}
}