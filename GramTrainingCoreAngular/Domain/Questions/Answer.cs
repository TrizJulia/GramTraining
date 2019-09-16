using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GramTrainingCoreAngular.Domain.Questions
{
    public class Answer
    {
        public int Id  { get; set; }
        [Required]
        [StringLength(3000)]
        public string Text { get; set; }
        public ICollection<QuestionAnswer> QuestionAnswers { get; set; }
    }
}
