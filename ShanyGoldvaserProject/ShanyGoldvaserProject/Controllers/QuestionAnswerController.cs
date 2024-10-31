using Microsoft.AspNetCore.Mvc;
using ShanyGoldvaserProject.Entities;
using ShanyGoldvaserProject.Servers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShanyGoldvaserProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionAnswerController : ControllerBase
    {
        QuestionAnswerServer questionAnswerServer = new QuestionAnswerServer();
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<QuestionAnswer>> Get()
        {
            return Ok(questionAnswerServer.GetQuestionAnswer());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var res = questionAnswerServer.GetQuestionAnswerId(id);
            if (res == null)
            {
                return NotFound(res);
            }
            return Ok(res);

        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult Post([FromBody] QuestionAnswer value)
        {
            bool res = questionAnswerServer.PostQuestionAnswer(value);

            if (res)
            {
                return Ok(res);
            }
            else
            {
                return NotFound(res);
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] QuestionAnswer value)
        {
            bool res = questionAnswerServer.PutQuestionAnswer(id, value);

            if (res)
            {
                return Ok(res);
            }
            else
            {
                return NotFound(res);
            }
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            bool res = questionAnswerServer.DeleteQuestionAnswer(id);

            if (res)
            {
                return Ok(res);
            }
            else
            {
                return NotFound(res);
            }
        }
    }
}
}
