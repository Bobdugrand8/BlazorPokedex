using Microsoft.Maui.Controls;

namespace BlazorPokedex.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}