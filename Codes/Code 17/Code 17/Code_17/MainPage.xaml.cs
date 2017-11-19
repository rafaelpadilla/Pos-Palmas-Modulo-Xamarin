using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Code_17
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            JogadorDataModel jogadorDM = new JogadorDataModel();
            JogadoresView.ItemsSource = jogadorDM.todosJogadores;

        }
    }
}
