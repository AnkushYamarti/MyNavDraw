using System;

using Xamarin.Forms;

namespace MyNavDraw.Views
{
    public class ViewOne : ContentPage
    {
        public ViewOne()
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

