using System;
using ITBees.RestClient.Interfaces.RestModelMarkup;

namespace ITBees.FAS.ApiInterfaces.MyAccounts
{
    public class MyAccountIm : Im
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid LastUsedCompanyGuid { get; set; }
        public string Language { get; set; }
    }
}