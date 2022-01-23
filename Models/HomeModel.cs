using Okta.Sdk;
using System.Collections.Generic;

namespace OktaDependencyInjection.Models
{
    public class HomeModel
    {
        public string ApplicationName { get; set; }

        public List<User> Users { get; set; }

        public int NumberOfHits { get; set; }

        public HomeModel() { }

        public HomeModel(string applicationName, List<User> users, int numberOfHits)
        {
            ApplicationName = applicationName;  
            Users = users;
            NumberOfHits = numberOfHits;
        }
    }
}
