using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Jost-Medium.ttf", Alias = "JostM")]
[assembly: ExportFont("Jost-SemiBold.ttf", Alias = "JostS")]
[assembly: ExportFont("Jost-Bold.ttf", Alias = "JostB")]
namespace UU
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
