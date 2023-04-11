using Microsoft.EntityFrameworkCore;

namespace MercadoAPI.Model
{
	public class AppDBContext :DbContext
	{
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<Signup> Users { get; set; }
      
    }
}
