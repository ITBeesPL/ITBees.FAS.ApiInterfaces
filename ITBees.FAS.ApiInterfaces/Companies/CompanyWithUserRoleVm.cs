using System;

namespace ITBees.FAS.ApiInterfaces.Companies;

public class CompanyWithUserRoleVm : CompanyVm
{
    public string? IdentityRoleName { get; set; }
    public Guid? IdentityRoleGuid { get; set; }
}