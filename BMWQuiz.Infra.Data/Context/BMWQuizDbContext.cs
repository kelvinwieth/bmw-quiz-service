using BMWQuiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BMWQuiz.Infra.Data.Context
{
    public class BMWQuizDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\SQLiteStudio\\BMWQuiz.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
    }
}
