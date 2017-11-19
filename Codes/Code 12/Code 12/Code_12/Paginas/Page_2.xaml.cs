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
	public partial class Page_2 : ContentPage
	{
		public Page_2()
		{
			InitializeComponent();
		}

        //Construtor para receber parâmetros
        public Page_2(string parametroRecebido)
        {
            InitializeComponent();
            lblParametroRecebido.Text = parametroRecebido;
        }

        async private void Button_Proximo_Clicked(object sender, EventArgs e)
        {
            //Insere a página 3 no stack
            await Navigation.PushAsync(new Paginas.Page_3());
        }

        async void Button_Anterior_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

            //Quando chamamos o PopAsync, 2 coisas acontecem:
            /*1) The page calling PopAsync has its OnDisappearing override invoked.
              2) The page being returned to has its OnAppearing override invoked.*/
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}