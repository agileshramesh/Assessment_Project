using Assessment_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_Project.ViewModels
{
    public class DetailsPageViewModel
    {
        public DetailsModel modelData { get; set; }    
       public DetailsPageViewModel(DetailsModel detailsModel)
        {
            modelData = new DetailsModel();
            modelData.id = detailsModel.id;
            modelData.userId = detailsModel.userId;
            modelData.title = detailsModel.title;
            modelData.body = detailsModel.body;
        }
    }
}
