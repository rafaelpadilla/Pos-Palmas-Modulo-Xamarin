using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Code_08
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void OnButtonCorClicked(object sender, EventArgs e)
        {
            /*You cannot access the x: Name property of a xaml element as this is 
            just a hint for the compiler to name the variable*/
            //Ou seja, não é possível fazer isso: button.Name;

            //Se soubéssemos o nome do botão, mas o sender não traz o nome
            //Button botao = this.FindByName<Button>(nome do botão);
            //Por isso fazemos via ClassId

            //Escolheu botão de capturar foto
            var button = (Button)sender;
            var classId = button.ClassId;
            //Defino uma cor
            Color cor;
            //Verifico se foi o botão black
            if (classId == "btnBotaoBlack")
                cor = Color.FromHex("#303030");
            else
                cor = Color.FromHex("#2D39A8");

            //Passo a cor para os componentes que devem ter cores mudadas
            this.FindByName<AbsoluteLayout>("lytPrincipal").BackgroundColor = cor;
            this.FindByName<Entry>("entryEspecialidade").BackgroundColor = cor;
            this.FindByName<Entry>("entryInteresse").BackgroundColor = cor;
            this.FindByName<Entry>("entryIdade").BackgroundColor = cor;
            this.FindByName<Entry>("entryBio").BackgroundColor = cor;
            this.FindByName<Button>("btnBorderImage").BackgroundColor = cor;
            //ou... Como tudo é View
            //this.FindByName<View>("lytPrincipal").BackgroundColor = cor;
            //this.FindByName<View>("entryEspecialidade").BackgroundColor = cor;
            //this.FindByName<View>("entryInteresse").BackgroundColor = cor;
            //this.FindByName<View>("entryIdade").BackgroundColor = cor;
            //this.FindByName<View>("entryBio").BackgroundColor = cor;
            //this.FindByName<View>("btnBorderImage").BackgroundColor = cor;
            //ou... Direto
            //lytPrincipal.BackgroundColor = cor;
            //entryEspecialidade.BackgroundColor = cor;
            //entryInteresse.BackgroundColor = cor;
            //entryIdade.BackgroundColor = cor;
            //entryBio.BackgroundColor = cor;
            //btnBorderImage.BackgroundColor = cor;
        }
    }
}
