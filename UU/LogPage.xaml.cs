using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;

namespace UU
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			Main.BackgroundImageSource = ImageSource.FromFile("/Resources/drawable/MainBG.png");
			CreateAcc.GestureRecognizers.Add(new TapGestureRecognizer
			{
				Command = new Command(async() =>
				{
					await Navigation.PopAsync();
					await Navigation.PushAsync(new RegPage());
				})
			});
		}

		private async void ButtonIn_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new MainContentPage());
		}
	}
}
