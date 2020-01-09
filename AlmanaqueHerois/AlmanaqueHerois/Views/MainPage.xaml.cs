using AlmanaqueHerois.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlmanaqueHerois
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonMainPageMarvelHerois_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new MarvelHeroisPage());
        }

        private void ButtonMainPageMarvelViloes_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonMainPageDCHerois_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonMainPageDCViloes_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonSair_Clicked(object sender, EventArgs e)
        {

        }
    }
}
