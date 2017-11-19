using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Code_16
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void CarregarImg1_Clicked(object sender, EventArgs e)
        {
            img1.Source = ImageSource.FromFile("juju.png");
        }
        
        //Da web
        void CarregarImg2_Clicked(object sender, EventArgs e)
        {
            string urlImage = "http://vilamulher.uol.com.br/imagens/thumbs/2011/04/08/caozinho-boo-tem-milhares-de-fas-no-facebook-1-69-351-thumb-570.jpg";
            img1.Source = ImageSource.FromUri(new Uri(urlImage));
        }
    }
}
