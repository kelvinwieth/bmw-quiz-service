using BMWQuiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace BMWQuiz.Infra.Data.Mapping
{
    public class AnswerMap : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            // EF não está gerando nomes corretamente ao usar duas extensões em conjunto
            // HasColumnName e HasColumnType/HasKey estão separadas por isso

            builder.ToTable("answer");

            builder.Property(a => a.Id)
                .HasColumnName("id");

            builder.Property(a => a.Description)
                .HasColumnName("description");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Description)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.HasData(GetInitialAnswers());
        }

        private List<Answer> GetInitialAnswers()
        {
            return new List<Answer>()
            {
                new Answer(1, "Inglaterra"),
                new Answer(2, "USA"),
                new Answer(3, "Alemanha"),
                new Answer(4, "Japão"),
            };
        }
    }
}
