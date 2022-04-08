using InterpolApp.ViewModels;
using InterpolApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace InterpolApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RedNoticesPage), typeof(RedNoticesPage));
            Routing.RegisterRoute(nameof(YellowNoticesPage), typeof(YellowNoticesPage));
            Routing.RegisterRoute(nameof(UnNoticesPage), typeof(UnNoticesPage));

            this.Navigating += AppShell_Navigating;
            this.Navigated += AppShell_Navigated;
        }

        private void AppShell_Navigated(object sender, ShellNavigatedEventArgs e)
        {
            var bindingContext = Shell.Current.CurrentPage.BindingContext;
            var currentViewModel = bindingContext != null ? bindingContext as BaseViewModel : null;
            currentViewModel?.OnNavigatedTo();
        }

        private void AppShell_Navigating(object sender, ShellNavigatingEventArgs e)
        {
            var bindingContext = Shell.Current.CurrentPage.BindingContext;
            var currentViewModel = bindingContext != null ? bindingContext as BaseViewModel : null;
            currentViewModel?.OnNavigatedFrom();
        }
    }
}
