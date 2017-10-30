using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Xamarin.Database;
using Xamarin.Forms;

namespace DiagnostiksFirebase
{
	public partial class MainPage : ContentPage
	{
		private ObservableCollection<Paciente> pacientes = new ObservableCollection<Paciente>();
		private FirebaseClient firebase;
		
		public MainPage()
		{
			Title = "Pacientes";
			firebase = new FirebaseClient("https://diagnostiks-3ef4a.firebaseio.com/");
			InitializeComponent();
			BindingContext = pacientes;
		}

		private async void AñadirPaciente(object sender, EventArgs e)
		{
			Paciente p = new Paciente();
			FormPacientes form = new FormPacientes();
			form.BindingContext = p;
			await Navigation.PushAsync(form, true);
		}

		private void VerPaciente(object sender, SelectedItemChangedEventArgs e)
		{
			throw new NotImplementedException();
		}

		private async Task GetList()
		{
			var list = await firebase.Child("pacientes").OnceAsync<Paciente>();

			pacientes.Clear();
			foreach (var item in list)
			{
				Paciente p = item.Object;
				p.Uid = item.Key;
				pacientes.Add(p);
			}
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			await GetList();
		}

		private void EditarPaciente(object sender, EventArgs e)
		{
			MenuItem item = sender as MenuItem;
			
		}
	}
}
