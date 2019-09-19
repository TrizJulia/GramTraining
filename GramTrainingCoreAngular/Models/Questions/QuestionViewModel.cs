using GramTrainingCoreAngular.Models.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GramTrainingCoreAngular.Models.Questions
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public int RightAnswerIndex { get; set; }
        public GrRuleViewModel Rule { get; set; }
        public ICollection<AnswerViewModel> Answers { get; set; }
    }
}
