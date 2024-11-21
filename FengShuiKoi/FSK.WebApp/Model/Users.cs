using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FSK.WebApp.Model
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }

    
}
