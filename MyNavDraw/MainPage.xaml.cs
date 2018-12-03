using MyNavDraw.MenuItems;
using MyNavDraw.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyNavDraw
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage

    {
        public List<MasterPageItems> menuList { get; set; }
        public MainPage(String parameter)
        {
            InitializeComponent();



            menuList = new List<MasterPageItems>();

            var page1 = new MasterPageItems() { Title = "Fast delivery", Icon = "RandomIcon", TargetType = typeof(View1) };
            var page2 = new MasterPageItems() { Title = "Menus", Icon = "RandomIcon", TargetType = typeof(View2) };
            var page3 = new MasterPageItems() { Title = "Free Pizza", Icon = "RandomIcon", TargetType = typeof(View3) };
            var page4 = new MasterPageItems() { Title = "Dining", Icon = "RandomIcon", TargetType = typeof(View4) };

            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);

            // Setting our list to be ItemSource for ListView in MainPage.xaml
            NavigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ViewMain)));
            this.BindingContext = new
            {
                Header = "",
                Image = "http://www3.hilton.com/resources/media/hi/GSPSCHF/en_US/img/shared/full_page_image_gallery/main/HH_food_22_675x359_FitToBoxSmallDimension_Center.jpg",
                //Footer = "         -------- Welcome To HotelPlaza --------           "
                Footer = "Welcome To Hotel Plaza"
            };
            Usernamelabl.Text = parameter;
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItems)e.SelectedItem;


            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
