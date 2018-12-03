using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyNavDraw.Views
{
    public partial class loginPage : ContentPage
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private async void Handle_Clicked(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "Pass")
                await Navigation.PushAsync(new MainPage(UserNameTxt.Text));
            else
                ErrorLbl.Text = "Incorrect Password";
        }
    }
}
