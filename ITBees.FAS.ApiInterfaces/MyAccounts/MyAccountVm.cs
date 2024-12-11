using System;
using System.Collections.Generic;
using System.Linq;
using ITBees.FAS.ApiInterfaces.Companies;
using ITBees.Models.MyAccount;
using ITBees.RestClient.Interfaces.RestModelMarkup;

namespace ITBees.FAS.ApiInterfaces.MyAccounts
{
    public class MyAccountVm : Vm
    {
        public MyAccountVm()
        {
            
        }
        
        public MyAccountVm(MyAccount x)
        {
            Email = x.Email;
            FirstName = x.FirstName;
            LastName = x.LastName;
            Guid = x.Guid;
            Phone = x.Phone;
            Companies = x.Companies == null ? null : x.Companies.Select(y=>new CompanyWithUserRoleVm(y)).ToList();
            LastUsedCompany = x.LastUsedCompany == null ? null : new CompanyWithUserRoleVm(x.LastUsedCompany);
            LastUsedCompanyGuid = x.LastUsedCompanyGuid;
            Language = x.Language?.Code;
            DisplayName = x.DisplayName;
        }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid Guid { get; set; }
        public List<CompanyWithUserRoleVm> Companies { get; set; }
        public CompanyWithUserRoleVm LastUsedCompany { get; set; }
        public Guid LastUsedCompanyGuid { get; set; }
        public string Language { get; set; }
        public string DisplayName { get; set; }
    }
}