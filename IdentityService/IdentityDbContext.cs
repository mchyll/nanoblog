using Microsoft.EntityFrameworkCore;

namespace Mchyll.IdentityService
{
	public class IdentityDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }

		public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options) { }
	}
}
