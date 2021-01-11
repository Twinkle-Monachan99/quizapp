

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace QuizBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        readonly QuizDbContext context;
        public QuestionsController(QuizDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IEnumerable<Models.Question> Get()
        {
            return context.Questions;
        }
        [HttpGet("{quizId}")]
        public IEnumerable<Models.Question> Get([FromRoute] int quizId)
        {
            return context.Questions.Where(q => q.QId == quizId);
        }

        [HttpPost] 
        public async Task<IActionResult> Post([FromBody]Models.Question question)
        {
            var quiz = context.Quiz.SingleOrDefault(q => q.QuizId == question.QId);
            if (quiz == null)
                return NotFound();
            

            context.Questions.Add(question);
            await context.SaveChangesAsync();
            return Ok(question);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]Models.Question question) //id passed to explicity modify and check
        {

            if (id != question.QuestId)
                return BadRequest();

            context.Entry(question).State = EntityState.Modified;

            await context.SaveChangesAsync();
              
            return Ok(question);
        }
    }
}
