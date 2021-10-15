using BMWQuiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace BMWQuiz.Infra.Data.Mapping
{
    public class QuestionOptionMap : IEntityTypeConfiguration<QuestionOption>
    {
        public void Configure(EntityTypeBuilder<QuestionOption> builder)
        {
            // EF não está gerando nomes corretamente ao usar duas extensões em conjunto
            // HasColumnName e HasColumnType/HasKey estão separadas por isso

            builder.ToTable("question_option");

            builder.Property(o => o.Id)
                .HasColumnName("id");

            builder.Property(o => o.QuestionId)
                .HasColumnName("question_id");

            builder.Property(o => o.AnswerId)
                .HasColumnName("answer_id");

            builder.Property(o => o.IsCorrect)
                .HasColumnName("is_correct");

            builder.Property(o => o.IsCorrect)
                .HasColumnType("boolean")
                .IsRequired();

            builder.HasOne(o => o.Question)
                .WithMany(q => q.QuestionOptions)
                .HasForeignKey(o => o.QuestionId)
                .IsRequired();

            builder.HasOne(o => o.Answer)
                .WithMany(a => a.QuestionOptions)
                .HasForeignKey(o => o.AnswerId)
                .IsRequired();

            builder.HasData(GetInitialQuestionOptions());
        }

        private List<QuestionOption> GetInitialQuestionOptions()
        {
            return new List<QuestionOption>()
            {
                new QuestionOption(id: 1, questionId: 1, answerId: 1, isCorrect: false),
                new QuestionOption(id: 2, questionId: 1, answerId: 2, isCorrect: false),
                new QuestionOption(id: 3, questionId: 1, answerId: 3, isCorrect: true),
                new QuestionOption(id: 4, questionId: 1, answerId: 4, isCorrect: false),

                new QuestionOption(id: 5, questionId: 2, answerId: 1, isCorrect: false),
                new QuestionOption(id: 6, questionId: 2, answerId: 2, isCorrect: false),
                new QuestionOption(id: 7, questionId: 2, answerId: 3, isCorrect: false),
                new QuestionOption(id: 8, questionId: 2, answerId: 4, isCorrect: true),

                new QuestionOption(id: 9, questionId: 3, answerId: 1, isCorrect: true),
                new QuestionOption(id: 10, questionId: 3, answerId: 2, isCorrect: false),
                new QuestionOption(id: 11, questionId: 3, answerId: 3, isCorrect: false),
                new QuestionOption(id: 12, questionId: 3, answerId: 4, isCorrect: false),

                new QuestionOption(id: 13, questionId: 4, answerId: 1, isCorrect: false),
                new QuestionOption(id: 14, questionId: 4, answerId: 2, isCorrect: true),
                new QuestionOption(id: 15, questionId: 4, answerId: 3, isCorrect: false),
                new QuestionOption(id: 16, questionId: 4, answerId: 4, isCorrect: false),

                new QuestionOption(id: 17, questionId: 5, answerId: 1, isCorrect: true),
                new QuestionOption(id: 18, questionId: 5, answerId: 2, isCorrect: false),
                new QuestionOption(id: 19, questionId: 5, answerId: 3, isCorrect: false),
                new QuestionOption(id: 20, questionId: 5, answerId: 4, isCorrect: false),
            };
        }
    }
}
