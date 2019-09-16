using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GramTrainingCoreAngular.Domain.Questions
{
    public class QuestionAnswer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
