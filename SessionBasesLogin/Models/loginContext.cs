using Microsoft.EntityFrameworkCore;

namespace SessionBasesLogin.Models
{
    public class loginContext:DbContext
    {
        public loginContext(DbContextOptions<loginContext> options) : base(options) { }
        
        public virtual DbSet<Login> logins { get; set; }

    }
}
