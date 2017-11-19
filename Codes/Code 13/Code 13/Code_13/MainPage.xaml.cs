using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Code_13
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void Button_SimplesDisplayAlert_Clicked(object sender, EventArgs e)
        {
            //Este DisplayAlert não obtém informações do usuário 
            DisplayAlert("Alerta", "Esta é a mensagem mostrada pelo DisplayAlert", "OK");
        }

        async void Button_OpcoesDisplayAlert_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert também pode retornar bool
            var answer = await DisplayAlert("Confirmação", "Você tem certeza em ...", "Sim", "Não");
            lblResposta.Text = answer.ToString();
        }

        async void Button_DisplayActionSheet_Clicked(object sender, EventArgs e)
        {
            //var action = await DisplayActionSheet("Título", "Botão 1", "Botão 2", "Opção 1", "Opção 2", "Opção 3", "Opção 4");
            //Sem botão Destruction
            //var action = await DisplayActionSheet("Título", "Botão 1", null, "Opção 1", "Opção 2", "Opção 3", "Opção 4");
            //lblResposta.Text = action.ToString();

            /* Se o usuário clicar fora, uma exception é chamada */
            string opcao = "";
            try
            {
                //var action = await DisplayActionSheet("Título", "Botão 1", "Botão 2", "Opção 1", "Opção 2", "Opção 3", "Opção 4");
                //ou
                var action = await DisplayActionSheet("Título", "Botão 1", null, "Opção 1", "Opção 2", "Opção 3", "Opção 4");
                opcao = action.ToString();
            }
            catch (Exception ex)
            {
                opcao = "nenhuma";
            }
            finally
            {
                lblResposta.Text = opcao;
            }

        }
    }
}
