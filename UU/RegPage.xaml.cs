using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UU
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegPage : ContentPage
	{
		public RegPage()
		{
			InitializeComponent();
			Reg.BackgroundImageSource = ImageSource.FromFile("/Resources/drawable/MainBG.png");
			HaveAnAcc.GestureRecognizers.Add(new TapGestureRecognizer
			{
				Command = new Command(async () =>
				{
					await Navigation.PopAsync();
					await Navigation.PushAsync(new MainPage());
				})
			});
		}

		private async void ButtonReg_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
			await Navigation.PushAsync(new MainPage());
		}
	}
}