using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiagnostiksFirebase
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IndexDiagnosticos : ContentPage
	{
		public IndexDiagnosticos ()
		{
			InitializeComponent ();
		}


		private void AñadirDiagnostico(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
		
		private void EliminarDiagnostico(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void EditarDiagnostico(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}