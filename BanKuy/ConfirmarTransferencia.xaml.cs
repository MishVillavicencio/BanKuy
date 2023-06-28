using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BanKuy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmarTransferencia : ContentPage
    {
        public ConfirmarTransferencia()
        {
            InitializeComponent();
        }

        private async void btnConfirmarTransferencia_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ComprobanteTransferencia());
        }

        private async void btnCancelar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaPrincipal());
        }
    }
}