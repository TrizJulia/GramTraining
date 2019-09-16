using GramTrainingCoreAngular.Domain.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GramTrainingCoreAngular.Domain.Questions;

namespace GramTrainingCoreAngular.Domain.Rules
{
    public class GrRule
    {
        public int Id { get; set; }
        public Language Language { get; set; }
        public string Link { get; set; }
        public bool IsImage { get; set; } = false;
        public bool IsYoutube { get; set; } = false;
        public EnglishTens Tens { get; set; }
        public string RuleText { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
