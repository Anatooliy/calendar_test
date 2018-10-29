using Calendar.DAL.Entities;
using Microsoft.AspNet.Identity;

namespace Calendar.DAL.Identity
{
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store)
                : base(store)
        {
        }
    }
}
