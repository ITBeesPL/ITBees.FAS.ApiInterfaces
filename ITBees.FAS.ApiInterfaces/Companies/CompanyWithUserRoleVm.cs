using System;
using ITBees.Models.Companies;

namespace ITBees.FAS.ApiInterfaces.Companies;

public class CompanyWithUserRoleVm : CompanyVm
{
    public CompanyWithUserRoleVm()
    {
        
    }
    
    public CompanyWithUserRoleVm(CompanyWithUserRole x)
    {
        IdentityRoleGuid = x.IdentityRoleGuid;
        IdentityRoleName = x.IdentityRoleName;
        base.CompanyName = x.CompanyName;
        base.CreatedBy = x.CreatedBy?.DisplayName;
        base.City = x.City;
        base.Guid = x.Guid;
        base.Created = x.Created;
        base.Nip = x.Nip;
        base.Owner = x.Owner?.DisplayName;
        base.Street = x.Street;
        base.IsActive = x.IsActive;
        base.OwnerGuid = x.OwnerGuid;
        base.PostCode = x.PostCode;
        base.CompanyPlatformSubscription = x.CompanyPlatformSubscription == null
            ? null
            : new CompanyPlatformSubscriptionVm(x.CompanyPlatformSubscription);
        base.CompanyShortName = x.CompanyShortName;
        base.CreatedByGuid = x.CreatedByGuid;
    }

    public CompanyWithUserRoleVm(CompanyWithUserRoleVm x)
    {
        IdentityRoleGuid = x.IdentityRoleGuid;
        IdentityRoleName = x.IdentityRoleName;
        base.CompanyName = x.CompanyName;
        base.CreatedBy = x.CreatedBy;
        base.City = x.City;
        base.Guid = x.Guid;
        base.Created = x.Created;
        base.Nip = x.Nip;
        base.Owner = x.Owner;
        base.Street = x.Street;
        base.IsActive = x.IsActive;
        base.OwnerGuid = x.OwnerGuid;
        base.PostCode = x.PostCode;
        base.CompanyPlatformSubscription = x.CompanyPlatformSubscription == null
            ? null
            : new CompanyPlatformSubscriptionVm(x.CompanyPlatformSubscription);
        base.CompanyShortName = x.CompanyShortName;
        base.CreatedByGuid = x.CreatedByGuid;
    }

    public string? IdentityRoleName { get; set; }
    public Guid? IdentityRoleGuid { get; set; }
}