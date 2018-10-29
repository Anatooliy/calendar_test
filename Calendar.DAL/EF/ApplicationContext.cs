using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Calendar.DAL.Entities;

namespace Calendar.DAL.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string conectionString) : base(conectionString) { }
        public DbSet<ClientProfile> ClientProfiles { get; set; }
    }
}
