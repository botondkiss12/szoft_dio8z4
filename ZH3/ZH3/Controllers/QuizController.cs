using Microsoft.AspNetCore.Mvc;
using System;
using ZH3.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZH3.Controllers
{
    [Route("api/quiz")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        // GET: api/<QuizController>
        [HttpGet]
        public IActionResult Get()
        {
            QuizDatabaseContext context = new QuizDatabaseContext();
            
            /*var kerdesek = (from r in context.Riddles
                            join c in context.Categories on r.CategoryId equals c.CategoryId
                            select new
                            {
                                Riddleid = r.RiddleId,
                                Question = r.QuestionText,
                                Correct = r.CorrectAnswer,
                                Wrong1 = r.WrongAnswer1,
                                Wrong2 = r.WrongAnswer2,
                                Wrong3 = r.WrongAnswer3,
                                Category = c.CategoryName
                            }).ToList();
            */

            var kerdesek = context.Riddles.ToList();
            return Ok(kerdesek);
        }

        // GET api/<QuizController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            QuizDatabaseContext context = new QuizDatabaseContext();
            /*
            var kerdes = (from r in context.Riddles
                            join c in context.Categories on r.CategoryId equals c.CategoryId
                            where r.RiddleId == id
                            select new
                            {
                                Question = r.QuestionText,
                                Correct = r.CorrectAnswer,
                                Wrong1 = r.WrongAnswer1,
                                Wrong2 = r.WrongAnswer2,
                                Wrong3 = r.WrongAnswer3,
                                Category = c.CategoryName
                            }).FirstOrDefault();
            */
            var kerdes = context.Riddles.ToList();
            return Ok(kerdes);
        }

        [HttpGet("category/{id}")]
        public IActionResult GetCategory(int id)
        {
            QuizDatabaseContext context = new QuizDatabaseContext();
            var kerdes = (from r in context.Categories
                          where r.CategoryId == id
                          select r).FirstOrDefault();

            return Ok(kerdes);
        }

        // POST api/<QuizController>
        [HttpPost]
        public void Post([FromBody] Riddle newQuestion)
        {
            QuizDatabaseContext context = new QuizDatabaseContext();
            context.Riddles.Add(newQuestion);
            context.SaveChanges();
        }

        // PUT api/author/5
        [HttpPut("{id}")]
        public IActionResult PutRiddle(int id, [FromBody] Riddle value)
        {
            QuizDatabaseContext context = new QuizDatabaseContext();
            var quizmod = (from a in context.Riddles
                             where a.RiddleId == id
                             select a).FirstOrDefault();

            if (quizmod == null)
            {
                return NotFound();
            }

            quizmod.QuestionText = value.QuestionText;
            quizmod.CorrectAnswer = value.CorrectAnswer;
            quizmod.WrongAnswer1 = value.WrongAnswer1;
            quizmod.WrongAnswer2 = value.WrongAnswer2;
            quizmod.WrongAnswer3 = value.WrongAnswer3;

            context.SaveChanges();

            return Ok("Sikeres módosítás");
        }

        // PUT api/author/5
        [HttpPut("category/{id}")]
        public IActionResult PutCategory(int id, [FromBody] Category value)
        {
            QuizDatabaseContext context = new QuizDatabaseContext();
            var quizmod = (from a in context.Categories
                           where a.CategoryId == id
                           select a).FirstOrDefault();

            if (quizmod == null)
            {
                return NotFound();
            }

            quizmod.CategoryName = value.CategoryName;

            context.SaveChanges();

            return Ok("Sikeres módosítás");
        }

        // DELETE api/<QuizController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            QuizDatabaseContext context = new QuizDatabaseContext();
            var törlendőVicc = (from x in context.Riddles
                                 where x.RiddleId == id
                                 select x).FirstOrDefault();
            context.Remove(törlendőVicc);
            context.SaveChanges();
        }
    }
}
