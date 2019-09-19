using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GramTrainingCoreAngular.Domain.Questions;
using GramTrainingCoreAngular.Domain.Rules;
using GramTrainingCoreAngular.Domain.Languages;
using GramTrainingCoreAngular.Models.Questions;
using GramTrainingCoreAngular.Models.Enums;
using GramTrainingCoreAngular.Models.Rules;

namespace GramTrainingCoreAngular.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Question, QuestionViewModel>()
                .ForMember(dest=>dest.Answers, opt=>opt.MapFrom(src=>src.QuestionAnswers.Select(y=>y.Answer)));
            CreateMap<Answer, AnswerViewModel>();
            CreateMap<GrRule, GrRuleViewModel>();
            CreateMap<EnglishTens, EnglishTensResource>();
            CreateMap<Language, LanguageResource>();
        }
    }
}
