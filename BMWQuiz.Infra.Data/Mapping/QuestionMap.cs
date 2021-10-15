using BMWQuiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace BMWQuiz.Infra.Data.Mapping
{
    public class QuestionMap : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            // EF não está gerando nomes corretamente ao usar duas extensões em conjunto
            // HasColumnName e HasColumnType/HasKey estão separadas por isso

            builder.ToTable("question");

            builder.Property(q => q.Id)
                .HasColumnName("id");

            builder.Property(q => q.Description)
                .HasColumnName("description");

            builder.HasKey(q => q.Id);

            builder.Property(q => q.Description)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.HasData(GetInitialQuestions());
        }

        private List<Question> GetInitialQuestions()
        {
            return new List<Question>()
            {
                new Question(1, "BMW"),
                new Question(2, "Toyota"),
                new Question(3, "Mini"),
                new Question(4, "General Motors"),
                new Question(5, "Rolls-Royce"),
            };
        }
    }
}
