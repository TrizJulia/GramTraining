using GramTrainingCoreAngular.Domain.Rules;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GramTrainingCoreAngular.Domain.Questions
{
    public class Question
    {       
        public int Id { get; set; }
        [Required]        
        public string QuestionText { get; set; }
        public int RightAnswerIndex { get; set; }
        public GrRule Rule { get; set; }
        public ICollection<QuestionAnswer> QuestionAnswers { get; set; }
    }
}
