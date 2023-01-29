using Assessment_Project.Helpers;
using Assessment_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Project.Services
{
    public interface IAccounts
    {
        Task<List<DetailsModel>> GetData();
    }
}
