using GramTrainingCoreAngular.Domain.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GramTrainingCoreAngular.Data.Questions
{
    public class QuestionAnswerConfig : IEntityTypeConfiguration<QuestionAnswer>
    {
        public void Configure(EntityTypeBuilder<QuestionAnswer> builder)
        {
            builder
              .HasKey(bc => new { bc.QuestionId, bc.AnswerId });
            builder
                .HasOne(bc => bc.Question)
                .WithMany(b => b.QuestionAnswers)
                .HasForeignKey(bc => bc.QuestionId);
            builder
                .HasOne(bc => bc.Answer)
                .WithMany(c => c.QuestionAnswers)
                .HasForeignKey(bc => bc.AnswerId);
        }
    }
}
