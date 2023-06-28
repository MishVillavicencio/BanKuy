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
    public partial class ComprobanteServicio : ContentPage
    {
        public ComprobanteServicio()
        {
            InitializeComponent();
        }

        private async void btnInicio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaPrincipal());
        }
    }
}