using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationPageLearning
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();

            btnSubmit3.Clicked += BtnSubmit3_Clicked;
		}

        private async void BtnSubmit3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}