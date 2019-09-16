using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GramTrainingCoreAngular.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GramTrainingCoreAngular.Controllers
{
    [Produces("application/json")]
    [Route("api/Question")]
    public class QuestionController : Controller
    {
        private readonly GrDbContext _db;

        public QuestionController(GrDbContext db)
        {
            _db = db;
        }
        // GET: api/Question
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var AnswersIdArray = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
          // _db.Question.Include(x => x.Answers).Include(x => x.Rule)
                 // .SelectMany(x => x.Answers.Where(y => AnswersIdArray.Contains(y.Id))).ToList();
            return new string[] { "value1", "value2" };
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
