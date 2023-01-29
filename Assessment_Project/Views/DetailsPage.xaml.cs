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
    public partial class DetailsPage : ContentPage
    {
        DetailsPageViewModel detailsPageViewModel;
        public DetailsPage(DetailsModel list)
        {
            InitializeComponent();
            detailsPageViewModel = new DetailsPageViewModel(list);
            BindingContext = detailsPageViewModel;
        }
    }
}