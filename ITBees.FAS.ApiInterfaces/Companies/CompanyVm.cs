using System;
using ITBees.Models.Companies;
using ITBees.RestClient.Interfaces.RestModelMarkup;

namespace ITBees.FAS.ApiInterfaces.Companies
{
    public class CompanyVm : Vm
    {
        public CompanyVm()
        {

        }

        public CompanyVm(Company x)
        {
            Guid = x.Guid;
            CompanyName = x.CompanyName;
            CreatedBy = x.CreatedBy?.DisplayName;
            Created = x.Created;
            CreatedByGuid = x.CreatedByGuid;
            Owner = x.Owner?.DisplayName;
            OwnerGuid = x.OwnerGuid;
            IsActive = x.IsActive;
            CompanyShortName = x.CompanyShortName;
            Street = x.Street;
            PostCode = x.PostCode;
            City = x.City;
            Nip = x.Nip;
            CompanyPlatformSubscription = x.CompanyPlatformSubscription == null ? null : new CompanyPlatformSubscriptionVm(x.CompanyPlatformSubscription);
        }
        public Guid Guid { get; set; }
        public string CompanyName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public Guid? CreatedByGuid { get; set; }
        public string Owner { get; set; }
        public Guid? OwnerGuid { get; set; }
        public bool IsActive { get; set; }
        public string CompanyShortName { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Nip { get; set; }
        public CompanyPlatformSubscriptionVm CompanyPlatformSubscription { get; set; }
    }
}