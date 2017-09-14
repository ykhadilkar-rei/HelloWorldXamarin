using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace HelloWorldXamarin
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://api.sam.gov/prod/sgs/v1/about?api_key=O4kzViWGVYNumPqhAzUhYGiZZZwW3RKUEYJOI6ii")));
        }

        public ICommand OpenWebCommand { get; }
    }
}
