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
    public partial class LoginUserPass : ContentPage
    {
        public LoginUserPass()
        {
            InitializeComponent();
        }

        private async void btnIngresarUser_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaPrincipal());
        }
    }
}