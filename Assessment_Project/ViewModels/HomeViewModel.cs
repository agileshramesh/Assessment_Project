using Assessment_Project.Helpers;
using Assessment_Project.Models;
using Assessment_Project.Services;
using Assessment_Project.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Assessment_Project.ViewModels
{
    public class HomeViewModel:BaseViewModel
    {
       
        public ICommand command { get; }
        DetailsModel detailsModel { get;set; }
       
        List<DetailsModel> list;
        public List<DetailsModel> List
        {
            get { return list; }
            set { SetProperty(ref list, value); }
        }
        public HomeViewModel()
        {
           
            GetData();
            command = new Command(() => ItemClicked());
            detailsModel= new DetailsModel();   
        }

        private void ItemClicked()
        {
        
        }
        private async void GetData()
        {
            List<DetailsModel> Dm = await Utility.AccountServiceProvider.GetData();
            List = Dm;
            
        }

        internal async void SelectedItem(DetailsModel list)
        {
            
            await App.Current.MainPage.Navigation.PushAsync(new DetailsPage(list));
        }
    }
   
}
