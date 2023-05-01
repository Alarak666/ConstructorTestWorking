using Data.CoreDefaults.Enum;
using Data.Data.Identity;
using Microsoft.AspNetCore.Identity;

namespace Data.ResponseDto
{
    public class RequestAuthentication
    {
        public string Name { get; set; }
        public string PasswordHasher { get; set; }
        public TypeRequest TypeRequest { get; set; }
    }
}
