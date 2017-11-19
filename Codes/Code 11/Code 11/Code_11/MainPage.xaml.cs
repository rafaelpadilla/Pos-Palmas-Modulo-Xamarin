using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Code_11
{
	public partial class MainPage : ContentPage
	{
      

        public MainPage()
		{
			InitializeComponent();

            //Como detectar quando a orientação MUDA
            //Abordagem 1:
            SizeChanged += MainPage_SizeChanged;

            //Abordagem 2:
            //Porém, se quisermos alterar a tela toda vez que o aparelho for ROTACIONADO, 
            //fazemos o override do OnSizeAllocated
		}

        #region Abordagem 1
        private void MainPage_SizeChanged(object sender, EventArgs e)
        {
            if (Height > Width) //Portrait
            {
                //Acesso os componentes pelo nome (x:name)
                lblNumero.Text = "Portrait";
                controlGrid.RowDefinitions[0].Height = 150;
                btnC.FontSize = btnMaisOuMenos.FontSize = btnPorcentagem.FontSize = 40;
                btnVirgula.FontSize = btnResultado.FontSize = btnSoma.FontSize = btnSubtracao.FontSize = btnDivisao.FontSize = btnMultiplicacao.FontSize = 40;
                btn0.FontSize = btn1.FontSize = btn2.FontSize = btn3.FontSize = btn4.FontSize = btn5.FontSize = btn6.FontSize = btn7.FontSize = btn8.FontSize = btn9.FontSize = 40;
            }
            else //Landscape
            {
                lblNumero.Text = "Landscape";
                btnC.FontSize = btnMaisOuMenos.FontSize = btnPorcentagem.FontSize = 20;
                controlGrid.RowDefinitions[0].Height = 80;
                btnVirgula.FontSize = btnResultado.FontSize = btnSoma.FontSize = btnSubtracao.FontSize = btnDivisao.FontSize = btnMultiplicacao.FontSize = 20;
                btn0.FontSize = btn1.FontSize = btn2.FontSize = btn3.FontSize = btn4.FontSize = btn5.FontSize = btn6.FontSize = btn7.FontSize = btn8.FontSize = btn9.FontSize = 20;
            }
        }
        #endregion

        #region Abordagem 2
        /*private double width = 0;
        private double height = 0;

        //Note that the OnSizeAllocated method may be called many times when a device is rotated.
        //Changing your layout each time is wasteful of resources and can lead to flickering. Consider using an instance variable within your page to track whether the orientation is in landscape or portrait, 
        //and only redraw when there is a change:
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //Temos que chamar

            //Detecto se houve alguma mudança no tamanho
            if (this.width != width || this.height != height)
            {
                this.width = width;
                this.height = height;

                //Recriar layout
                if (height > width) //Portrait
                {
                    //Acesso os componentes pelo nome (x:name)
                    lblNumero.Text = "portrait";
                    controlGrid.RowDefinitions[0].Height = 150;
                    btnC.FontSize = btnMaisOuMenos.FontSize = btnPorcentagem.FontSize = 40;
                    btnVirgula.FontSize = btnResultado.FontSize = btnSoma.FontSize = btnSubtracao.FontSize = btnDivisao.FontSize = btnMultiplicacao.FontSize = 40;
                    btn0.FontSize = btn1.FontSize = btn2.FontSize = btn3.FontSize = btn4.FontSize = btn5.FontSize = btn6.FontSize = btn7.FontSize = btn8.FontSize = btn9.FontSize = 40;
                }
                else //Landscape
                {
                    lblNumero.Text = "Landscape";
                    btnC.FontSize = btnMaisOuMenos.FontSize = btnPorcentagem.FontSize = 20;
                    controlGrid.RowDefinitions[0].Height = 80;
                    btnVirgula.FontSize = btnResultado.FontSize = btnSoma.FontSize = btnSubtracao.FontSize = btnDivisao.FontSize = btnMultiplicacao.FontSize = 20;
                    btn0.FontSize = btn1.FontSize = btn2.FontSize = btn3.FontSize = btn4.FontSize = btn5.FontSize = btn6.FontSize = btn7.FontSize = btn8.FontSize = btn9.FontSize = 20;
                }
            }
        }*/
        #endregion

    }
}
