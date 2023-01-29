using Assessment_Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Project.Helpers
{
    public class ServiceHelpers
    {
        private HttpClient client = new HttpClient();
        private ResponseModel responseModel = null;
       
        public async Task<ResponseModel> GetRequest()
        {
            try
            {
                HttpResponseMessage response1 = null;
                response1 = await client.GetAsync(Constants.ServiceURL);
                if (response1.IsSuccessStatusCode)
                {
                    var response = response1.Content.ReadAsStringAsync().Result;
                    responseModel = new ResponseModel
                    {
                        IsSuccess = true,
                        Data = response
                    };
                    
                    return responseModel;
                }
               
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
            return responseModel;
        }
    }
}
