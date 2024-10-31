using Microsoft.AspNetCore.Mvc;
using ShanyGoldvaserProject.Entities;
using ShanyGoldvaserProject.Servers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShanyGoldvaserProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErovController : ControllerBase
    {
        ErovServer erovServer = new ErovServer();
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<Erov>> Get()
        {
            return Ok(erovServer.GetErov());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var res = erovServer.GetErovId(id);
            if (res == null)
            {
                return NotFound(res);
            }
            return Ok(res);

        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult Post([FromBody] Erov value)
        {
            bool res = erovServer.PostErov(value);

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
        public ActionResult<bool> Put(int id, [FromBody] Erov value)
        {
            bool res = erovServer.PutErov(id, value);

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
            bool res = erovServer.DeleteErov(id);

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
