using Assessment_Project.Models;
using Assessment_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assessment_Project.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        HomeViewModel homeViewModel;
        List<DetailsModel> detailsModel { get; }
        public HomePage()
        {
            InitializeComponent();
            homeViewModel= new HomeViewModel();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var frame = sender as Frame;
            var model = frame.BindingContext as DetailsModel;
            homeViewModel.SelectedItem(model);
        }
    }
}