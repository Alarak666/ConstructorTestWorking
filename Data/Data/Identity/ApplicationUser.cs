using Microsoft.AspNetCore.Identity;

namespace Data.Data.Identity;

public class ApplicationUser : IdentityUser<Guid>
{
    public virtual ApplicationRole? ApplicationRole { get; set; }
    public Guid? ApplicationRoleId { get; set; }
    public string? ApplicationRoleName { get; set; }
}