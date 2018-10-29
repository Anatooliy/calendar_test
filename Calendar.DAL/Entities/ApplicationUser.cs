using Microsoft.AspNet.Identity.EntityFramework;

namespace Calendar.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ClientProfile ClientProfile { get; set; }
    }
}
