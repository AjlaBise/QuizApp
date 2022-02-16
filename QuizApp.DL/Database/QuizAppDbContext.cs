using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using QuizApp.DL.Domain;

namespace QuizApp.DL.Database
{
    public partial class QuizAppDbContext : DbContext
    {
        private IConfiguration Configuration;


        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserQuestion> UserQuestions { get; set; }


        //public QuizAppDbContext(IConfiguration _configuration)
        //{
        //    Configuration = _configuration;
        //}
        public QuizAppDbContext()
        {

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
