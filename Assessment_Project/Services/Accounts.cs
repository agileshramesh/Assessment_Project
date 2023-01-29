using Assessment_Project.Helpers;
using Assessment_Project.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Project.Services
{
    public class Accounts:IAccounts
    {
       
        List<DetailsModel> result;
        public  ServiceHelpers serviceHelper;
        public Accounts()
        {
            serviceHelper = new ServiceHelpers();
        }
        
        public async Task<List<DetailsModel>> GetData()
        {

            try
            {
                var response = await serviceHelper.GetRequest();
               
                    var result = JsonConvert.DeserializeObject<List<DetailsModel>>(response.Data);
                    return result;
                
             
            }
           
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
               
            }
            return result;
        }
            
    }
    
}
