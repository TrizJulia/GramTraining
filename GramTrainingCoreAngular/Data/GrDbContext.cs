using GramTrainingCoreAngular.Domain.Languages;
using GramTrainingCoreAngular.Domain.Questions;
using GramTrainingCoreAngular.Domain.Rules;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GramTrainingCoreAngular.Data
{
    public class GrDbContext : DbContext
    {
        public GrDbContext(DbContextOptions<GrDbContext> options)
        :base(options) 
        {
            Database.EnsureCreated();
        }

       public DbSet<Question> Question { get; set; }
       // public DbSet<GrRule> Rule { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //apply configs from separate classes implemented IEntityTypeConfiguration<>
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
                      
            //seed data
            modelBuilder.Entity<GrRule>().HasData(
             new
             {
                 Id = 1,
                 Link = "./assets/pitalni_slova-.jpg",
                 Tens = EnglishTens.PresentSimple,
                 IsImage = true,
                 IsYoutube = false,
                 Language = Language.English
             }
              );
            // var AnswersIdArray = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            modelBuilder.Entity<Question>().HasData(
                new  {
                    Id =1,
                    QuestionText ="Äå?",
                    RightAnswerIndex = 2,
                    OwnerId = 1
                },
                new 
                {
                    Id = 2,
                    QuestionText = "Õòî?",                   
                    RightAnswerIndex = 1,
                    OwnerId = 1
                }
                );
            modelBuilder.Entity<Answer>().HasData(
               new Answer { Id = 1, Text = "What?" },
               new Answer { Id = 2, Text = "Who?" },
               new Answer { Id = 3, Text = "Where?" },
               new Answer { Id = 4, Text = "When?" },
               new Answer { Id = 5, Text = "Why?" },
               new Answer { Id = 6, Text = "Which?" },
               new Answer { Id = 7, Text = "What time?" },
               new Answer { Id = 8, Text = "How much?" }
               );

            modelBuilder.Entity<QuestionAnswer>().HasData(
               new
               {
                   Id = 1,
                   QuestionId = 1,
                   AnswerId = 1
               },
               new
               {
                   Id = 2,
                   QuestionId = 1,
                   AnswerId = 2
               },
               new
               {
                   Id = 3,
                   QuestionId = 1,
                   AnswerId = 3
               },
               new
               {
                   Id = 4,
                   QuestionId = 1,
                   AnswerId = 4
               },
               new
               {
                   Id = 5,
                   QuestionId = 1,
                   AnswerId = 5
               },
               new
               {
                   Id = 6,
                   QuestionId = 1,
                   AnswerId = 6
               },
                new
                {
                    Id = 7,
                    QuestionId = 1,
                    AnswerId = 7
                },
                 new
                 {
                     Id = 8,
                     QuestionId = 1,
                     AnswerId = 8
                 },
               new
               {
                   Id = 9,
                   QuestionId = 2,
                   AnswerId = 1
               },
                new
                {
                    Id = 10,
                    QuestionId = 2,
                    AnswerId = 2
                },
                 new
                 {
                     Id = 11,
                     QuestionId = 2,
                     AnswerId = 3
                 },
                 new
                 {
                     Id = 12,
                     QuestionId = 2,
                     AnswerId = 4
                 },
                 new
                 {
                     Id = 13,
                     QuestionId = 2,
                     AnswerId = 5
                 },
                 new
                 {
                     Id = 14,
                     QuestionId = 2,
                     AnswerId = 6
                 },
                 new
                 {
                     Id = 15,
                     QuestionId = 2,
                     AnswerId = 7
                 },
                 new
                 {
                     Id = 16,
                     QuestionId = 2,
                     AnswerId = 8
                 }
               );
            base.OnModelCreating(modelBuilder);
        }

    }
}