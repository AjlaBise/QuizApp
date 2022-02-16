using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace QuizApp.DL.Database
{
    public partial class QuizAppDbContext : DbContext
    {
        private IConfiguration Configuration;
        public QuizAppDbContext(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public QuizAppDbContext(DbContextOptions<QuizAppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("QuizAppDb"));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
