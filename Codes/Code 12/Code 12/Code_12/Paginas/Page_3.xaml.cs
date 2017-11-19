using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Code_12.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page_3 : ContentPage
	{
		public Page_3()
		{
			InitializeComponent();
		}

        async private void Button_Proximo_Clicked(object sender, EventArgs e)
        {
            //Insere a página 4 no stack
            await Navigation.PushAsync(new Paginas.Page_4());
        }

        async void Button_Anterior_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}