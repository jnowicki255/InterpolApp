using InterpolApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterpolApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RedNoticesPage : ContentPage
    {
        private RedNoticesViewModel viewModel;

        public RedNoticesPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new RedNoticesViewModel();
        }
    }
}