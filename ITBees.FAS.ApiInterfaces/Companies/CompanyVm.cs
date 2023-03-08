using System;
using ITBees.RestClient.Interfaces.RestModelMarkup;

namespace ITBees.FAS.ApiInterfaces.Companies
{
    public class CompanyVm : Vm
    {
        public Guid Guid { get; set; }
        public string CompanyName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public Guid CreatedByGuid { get; set; }
        public string Owner { get; set; }
        public Guid OwnerGuid { get; set; }
        public bool IsActive { get; set; }
    }
}