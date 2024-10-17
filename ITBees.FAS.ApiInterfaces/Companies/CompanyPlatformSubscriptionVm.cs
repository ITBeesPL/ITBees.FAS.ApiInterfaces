using System;
using ITBees.Models.Companies;
using ITBees.RestClient.Interfaces.RestModelMarkup;

namespace ITBees.FAS.ApiInterfaces.Companies;

public class CompanyPlatformSubscriptionVm : Vm
{
    public CompanyPlatformSubscriptionVm()
    {
        
    }

    public CompanyPlatformSubscriptionVm(CompanyPlatformSubscription x)
    {
        SubscriptionActiveTo = x.SubscriptionActiveTo;
        SubscriptionPlanGuid = x.SubscriptionPlanGuid;
        TrialNotAvailable = x.TrialNotAvailable;
        SubscriptionPlanName = x.SubscriptionPlanName;
    }

    public Guid? SubscriptionPlanGuid { get; set; }
    public string? SubscriptionPlanName { get; set; }
    public DateTime? SubscriptionActiveTo { get; set; }
    public bool TrialNotAvailable { get; set; }
}