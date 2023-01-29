using Assessment_Project.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_Project.Helpers
{
    public class Utility
    {
        private static IAccounts serviceProvider;
        public static IAccounts AccountServiceProvider
        {
            get
            {
                if (serviceProvider == null)
                {
                    serviceProvider = new Accounts();
                }
                return serviceProvider;
            }
        }
    }
}
