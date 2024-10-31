using Microsoft.AspNetCore.Mvc;
using ShanyGoldvaserProject.Entities;
using ShanyGoldvaserProject.Servers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShanyGoldvaserProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        PlaceServer placeServer = new PlaceServer();
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<Place>> Get()
        {
            return Ok(placeServer.GetPlace());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var res = placeServer.GetPlaceId(id);
            if (res == null)
            {
                return NotFound(res);
            }
            return Ok(res);

        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult Post([FromBody] Place value)
        {
            bool res = placeServer.PostPlace(value);

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
        public ActionResult<bool> Put(int id, [FromBody] Place value)
        {
            bool res = placeServer.PutPlace(id, value);

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
            bool res = placeServer.DeletePlace(id);

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
