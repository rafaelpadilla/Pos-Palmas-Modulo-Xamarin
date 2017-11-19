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
	public partial class Page_5 : ContentPage
	{
		public Page_5()
		{
			InitializeComponent();
		}

        async void Button_Anterior_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void Button_Primeira_Clicked(object sender, EventArgs e)
        {
            //Tira todas as páginas do stack, menos a primeira (root)
            await Navigation.PopToRootAsync();
        }
    }
}