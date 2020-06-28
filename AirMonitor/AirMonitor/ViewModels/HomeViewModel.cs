using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using System.Windows.Input;
using AirMonitor.Views;
using Xamarin.Forms;

namespace AirMonitor.ViewModels
{
    public class HomeViewModel : ContentView
    {
        private readonly INavigation _navigation;

        public HomeViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        private ICommand _goToDetailsCommand;
        public ICommand GoToDetailsCommand => _goToDetailsCommand ?? (_goToDetailsCommand = new Command(OnGoToDetails));

        private void OnGoToDetails()
        {
            _navigation.PushAsync(new DetailsPage());
        }
    }
}