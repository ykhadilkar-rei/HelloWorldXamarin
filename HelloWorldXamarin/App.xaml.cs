using System;

using Xamarin.Forms;

namespace HelloWorldXamarin
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";
        public static string SamBackendUrl = "https://api.sam.gov/prod";
        public static string SamApiToken = "O4kzViWGVYNumPqhAzUhYGiZZZwW3RKUEYJOI6ii";

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<CloudDataStore>();

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new MainPage();
            else
                MainPage = new NavigationPage(new MainPage());
        }
    }
}
