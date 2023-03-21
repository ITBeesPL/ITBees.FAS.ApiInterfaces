using System;
using System.Collections.Generic;
using ITBees.FAS.ApiInterfaces.Companies;
using ITBees.RestClient.Interfaces.RestModelMarkup;

namespace ITBees.FAS.ApiInterfaces.MyAccounts
{
    public class MyAccountVm : Vm
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid Guid { get; set; }
        public List<CompanyVm> Companies { get; set; }
        public CompanyVm LastUsedCompany { get; set; }
        public Guid LastUsedCompanyGuid { get; set; }
        public string Language { get; set; }
    }
}