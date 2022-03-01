using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectJobs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Click_LogarAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        async void Click_RegistrarAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }

    }
}
