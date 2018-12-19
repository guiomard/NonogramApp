using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //Buttons to send user to other pages
        private void OnButtonEasyClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Easy());
        }
        private void OnButtonMediumClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Medium());
        }
        private void OnButtonHardClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Hard());
        }
        private void OnButtonHelpClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Help());
        }
    }
}
