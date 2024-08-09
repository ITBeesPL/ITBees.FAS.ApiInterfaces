using System;
using ITBees.RestClient.Interfaces.RestModelMarkup;

namespace ITBees.FAS.ApiInterfaces.Companies;

public class CompanyPlatformSubscriptionVm : Vm
{
    public Guid? SubscriptionPlanGuid { get; set; }
    public string? SubscriptionPlanName { get; set; }
    public DateTime? SubscriptionActiveTo { get; set; }
    public bool TrialExpired { get; set; }
}