using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace DiagnostiksFirebase
{
	public class Paciente
	{
		private string uid = "";
		private string nombre = "";
		private ObservableCollection<string> diagnosticos = new ObservableCollection<string>() {};

		public string Uid
		{
			get => uid;
			set
			{
				if (value == null) return;
				uid = value;
			}
		}

		public string Nombre
		{
			get => nombre;
			set
			{
				if (value == null) return;
				nombre = value;
			}
		}
		
		public ObservableCollection<string> Diagnosticos
		{
			get => diagnosticos;
			set
			{
				if (value == null) return;
				diagnosticos = value;
			}
		}

		public string UltimoDiagnostico => string.IsNullOrEmpty(Diagnosticos.LastOrDefault())
			? "El paciente no tiene diagnosticos"
			: Diagnosticos.LastOrDefault();

	}
}