using GramTrainingCoreAngular.Models.Enums;
using GramTrainingCoreAngular.Models.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GramTrainingCoreAngular.Models.Rules
{
    public class GrRuleViewModel
    {
        public int Id { get; set; }
        public LanguageResource Language { get; set; }
        public string Link { get; set; }
        public bool IsImage { get; set; } = false;
        public bool IsYoutube { get; set; } = false;
        public EnglishTensResource Tens { get; set; }
        public string RuleText { get; set; }
        public ICollection<QuestionViewModel> Questions { get; set; }
    }
}
