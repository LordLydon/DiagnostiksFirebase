using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Xamarin.Database;
using Firebase.Xamarin.Database.Query;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiagnostiksFirebase
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormPacientes : ContentPage
	{
		private bool editar;
		private FirebaseClient firebase;

		public FormPacientes(bool editar = false)
		{
			if (editar)
			{
				Title = "Editar " + ((Paciente) BindingContext).Nombre;
			}
			else
			{
				Title = "Crear Paciente";
			}
			
			InitializeComponent();
			firebase = new FirebaseClient("https://diagnostiks-3ef4a.firebaseio.com/");
			this.editar = editar;
		}

		private async void Guardar(object sender, EventArgs e)
		{
			var item = BindingContext as Paciente;

			if (editar)
			{
				await firebase.Child("pacientes").Child(item.Uid).PutAsync(item);
			}
			else
			{
				await firebase.Child("pacientes").PostAsync(item);
			}
		}
	}
}