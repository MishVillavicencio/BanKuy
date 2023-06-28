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
    public partial class PaginaPrincipal : ContentPage
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private async void btnPerfil_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BanKuy.Perfil());
        }

        private async void btnTransferencia_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BanKuy.Transferencia());
        }

        private async void btnServicios_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BanKuy.Servicios());
        }

        private async void btnMovimientos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BanKuy.Movimientos());
        }

        private async void btnCuenta_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BanKuy.Cuenta());
        }

    }
}