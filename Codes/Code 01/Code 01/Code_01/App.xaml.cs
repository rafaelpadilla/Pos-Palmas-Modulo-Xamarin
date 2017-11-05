using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Code_01
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //Propriedade MainPage da classe pai Application recebe a página principal do aplicativo
			MainPage = new Code_01.Pages.Page01();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
