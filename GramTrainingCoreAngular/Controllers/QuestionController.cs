using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GramTrainingCoreAngular.Data;
using GramTrainingCoreAngular.Domain.Questions;
using GramTrainingCoreAngular.Models.Questions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GramTrainingCoreAngular.Controllers
{
    [Produces("application/json")]
    [Route("api/Question")]
    public class QuestionController : Controller
    {
        private readonly GrDbContext _db;

        public IMapper Mapper { get; }

        public QuestionController(GrDbContext db, IMapper mapper)
        {
            _db = db;
            Mapper = mapper;
        }
        // GET: api/Question
        [HttpGet("List")]
        public async Task<IEnumerable<QuestionViewModel>> Index()
        {
            var AnswersIdArray = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            var questions = await _db.Question.Include(x => x.QuestionAnswers)
                .ThenInclude(qa=>qa.Answer)
                .Include(x => x.Rule).ToListAsync();
            var questModels = Mapper.Map<List<Question>, List<QuestionViewModel>>(questions);
            //.SelectMany(x => x.Answers.Where(y => AnswersIdArray.Contains(y.Id))).ToList();
            return questModels;
        }

        // GET: api/Question/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Question
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Question/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
