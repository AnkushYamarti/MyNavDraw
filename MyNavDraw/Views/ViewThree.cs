using System;

using Xamarin.Forms;

namespace MyNavDraw.Views
{
    public class ViewThree : ContentPage
    {
        public ViewThree()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

