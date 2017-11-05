using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Code_06
{
    public partial class MainPage : ContentPage
    {
        bool capturaNovoNumero = true;
        bool modoCapturaOperador;
        bool mostrandoResultado;


        public MainPage()
        {
            InitializeComponent();

            capturaNovoNumero = true;
            modoCapturaOperador = false;
            mostrandoResultado = true;
        }

        void OnButtonClearClicked(object sender, EventArgs e)
        {
            lblNumero.Text = "0";
            DescoloriBotoesOperacoes();

            capturaNovoNumero = true;
            modoCapturaOperador = false;
            mostrandoResultado = true;
        }

        void OnButtonMaisOuMenosClicked(object sender, EventArgs e)
        {
            //Zero não tem positivo nem negativo
            if (lblNumero.Text == "0")
                return;
            //Se for negativo
            if (lblNumero.Text.StartsWith("-"))
                lblNumero.Text = lblNumero.Text.Replace("-", ""); //Transforma em positivo
            else //Se for positivo
                lblNumero.Text = "-" + lblNumero.Text; //Transforma em negativo
        }

        void OnButtonNumberClicked(object sender, EventArgs e)
        {
            DescoloriBotoesOperacoes();

            var button = (sender as Button);
            var classId = button.ClassId;

            /*Captura o número digitado*/
            string novoNumero = "";
            switch (classId)
            {
                case "btn0": novoNumero = "0"; break;
                case "btn1": novoNumero = "1"; break;
                case "btn2": novoNumero = "2"; break;
                case "btn3": novoNumero = "3"; break;
                case "btn4": novoNumero = "4"; break;
                case "btn5": novoNumero = "5"; break;
                case "btn6": novoNumero = "6"; break;
                case "btn7": novoNumero = "7"; break;
                case "btn8": novoNumero = "8"; break;
                case "btn9": novoNumero = "9"; break;
            }
            //ou 
            //novoNumero = classId.Replace("btn", "");

            //É para iniciar novo número no visor
            if (capturaNovoNumero)
            {
                lblNumero.Text = novoNumero;
            }
            else
            {
                //Se estiver com visor "limpo"
                if (lblNumero.Text == "0")
                    lblNumero.Text = novoNumero;
                else
                    //Completa com novos dígitos
                    lblNumero.Text = lblNumero.Text + novoNumero;
            }
            capturaNovoNumero = false;
            mostrandoResultado = false;
        }

        void OnButtonOperacaoClicked(object sender, EventArgs e)
        {
            capturaNovoNumero = true;

            var button = (sender as Button);
            var classId = button.ClassId;

            /*Captura operação digitada*/
            switch (classId)
            {
                case "btnMultiplicacao":
                    ColoriBotaoPressionado(btnMultiplicacao);
                    break;
                case "btnSubtracao":
                    ColoriBotaoPressionado(btnSubtracao);
                    break;
                case "btnSoma":
                    ColoriBotaoPressionado(btnSoma);
                    break;
                case "btnDivisao":
                    ColoriBotaoPressionado(btnDivisao);
                    break;
            }
            modoCapturaOperador = true;
            mostrandoResultado = false;
        }

        void OnButtonResultadoClicked(object sender, EventArgs e)
        {
            //Flag que informa que é para capturar novo número
            capturaNovoNumero = true;

            float resultado = 0;
            lblNumero.Text = resultado.ToString();
            modoCapturaOperador = false;

            mostrandoResultado = true;
            DescoloriBotoesOperacoes();
        }

        void OnButtonVirgulaClicked(object sender, EventArgs e)
        {
            if (capturaNovoNumero)
            {
                lblNumero.Text = "0.";
            }
            else
            {
                if (!lblNumero.Text.Contains("."))
                {
                    lblNumero.Text = lblNumero.Text + ".";
                }
            }
            capturaNovoNumero = false;
        }

        void ColoriBotaoPressionado(Button buttonPressionado)
        {
            //Muda a cor dos não pressionados para cor padrão
            DescoloriBotoesOperacoes();
            //Muda a cor do botão pressionado
            if (btnMultiplicacao == buttonPressionado)
                btnMultiplicacao.BackgroundColor = Color.DarkGray;
            else if (btnSoma == buttonPressionado)
                btnSoma.BackgroundColor = Color.DarkGray;
            else if (btnDivisao == buttonPressionado)
                btnDivisao.BackgroundColor = Color.DarkGray;
            else if (btnSubtracao == buttonPressionado)
                btnSubtracao.BackgroundColor = Color.DarkGray;
        }

        private void DescoloriBotoesOperacoes()
        {
            btnMultiplicacao.BackgroundColor = Color.FromHex("E8AD00");
            btnSoma.BackgroundColor = Color.FromHex("E8AD00");
            btnDivisao.BackgroundColor = Color.FromHex("E8AD00");
            btnSubtracao.BackgroundColor = Color.FromHex("E8AD00");
        }
    }
}
