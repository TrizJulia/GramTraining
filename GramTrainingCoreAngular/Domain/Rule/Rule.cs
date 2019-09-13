using GramTrainingCoreAngular.Domain.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GramTrainingCoreAngular.Domain.Rule
{
    public class Rule
    {
        public Language Language { get; set; }
        public string Link { get; set; }
        public bool IsImage { get; set; }
        public bool IsYoutube { get; set; }
        public EnglishTens Tens { get; set; }
        public string RuleText { get; set; }
    }
}
