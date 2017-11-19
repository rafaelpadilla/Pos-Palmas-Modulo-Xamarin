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
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void Button_Proximo_Clicked(object sender, EventArgs e)
        {
            //Obs: É preciso alterar a forma de chamar a MainPage (Ver App.xaml.cs Linha 16)
            //Insere a página 2 no stack
            //await Navigation.PushAsync(new Paginas.Page_2());

            //Passando parâmetros (Pelo construtor)
            //await Navigation.PushAsync(new Paginas.Page_2(DateTime.Now.ToLocalTime().ToLongTimeString()));

            //Quando chamamos o PushAsync, 2 coisas acontecem:
            /*1) The page calling PushAsync has its OnDisappearing override invoked.
              2) The page being navigated to has its OnAppearing override invoked.*/
        }

        async void Button_Anterior_Clicked(object sender, EventArgs e)
        {
            //Chamando a anterior, não interfere em nada
            //Pois não tem mais nenhuma página no stack
            await Navigation.PopAsync();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}