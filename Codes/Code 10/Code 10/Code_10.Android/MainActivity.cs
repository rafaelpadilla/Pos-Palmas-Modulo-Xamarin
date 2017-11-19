using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Code_10.Droid
{
    [Activity(Label = "Desafio_1", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        //ScreenOrientation = ScreenOrientation.Landscape //Força a aplicação ser landscape
        //ScreenOrientation = ScreenOrientation.Portrait//Força a aplicação ser portrait
        //ScreenOrientation = ScreenOrientation.User//Força a aplicação ser preferencial do usuário (Se no Settings, ele travou a tela para rotação. Aqui tb NÃO vai funcionar. 
        //ScreenOrientation = ScreenOrientation.Behind//Matém o mesmo tipo de orientação do último app aberto: Ex: teste abrindo o app "Settings" e depois teste este; Depois feche o "Settings" e volte para esse
        //ScreenOrientation = ScreenOrientation.Sensor //Faz a aplicação ter a orientação determinada pelo sensor, MESMO SE O USUÁRIO TRAVOU A TELA PARA ROTAÇÃO EM SETTINGS.
        //ScreenOrientation = ScreenOrientation.SensorLandscape //Deixa sempre em landscape
        //ScreenOrientation = ScreenOrientation.SensorPortrait //Deixa sempre em portrait
        //ScreenOrientation = ScreenOrientation.ReverseLandscape //Deixa sempre em landscape inverso
        //ScreenOrientation = ScreenOrientation.ReversePortrait //Deixa sempre em portrait inverso
        //ScreenOrientation = ScreenOrientation.FullSensor //Deixa o sensor utilizar a melhor orientação (Sempre app vai ficar melhor visualizada pelo usuário)
        ScreenOrientation = ScreenOrientation.FullUser //Faz a aplicação usar a orientação da preferência do usuário. Se a rotação automática estiver habilitada, as 4 orientações poderão ser usadas
        )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar; 

			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new Code_10.App ());
		}
	}
}

