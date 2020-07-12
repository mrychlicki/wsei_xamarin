using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirMonitor.Models;
using AirMonitor.ViewModels;
using Xamarin.Forms;

namespace AirMonitor.Views
{
    
    [DesignTimeVisible(false)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Measurement item)
        {
            InitializeComponent();

            var vm = BindingContext as DetailsViewModel;
            vm.Item = item;
        }

        private void Help_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Co to jest CAQI?", "Lorem ipsum.", "Zamknij");
        }
    }
}
