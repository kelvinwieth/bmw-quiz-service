using BMWQuiz.Domain.Entities;
using BMWQuiz.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BMWQuiz.Infra.Data.Context
{
    public class BMWQuizDbContext : DbContext
    {
        public BMWQuizDbContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
    }
}
