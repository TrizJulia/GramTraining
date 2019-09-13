using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GramTrainingCoreAngular.Domain.Question
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public int RightAnswerIndex { get; set; }
        public Rool Rool { get; set; }
    }
}
