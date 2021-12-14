using Microsoft.AspNetCore.Mvc;
using petshop.Models;
using petshop.Services;

namespace petshop.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CatsController : ControllerBase
  {
    private readonly CatsService _cs;
    public CatsController(CatsService cs)
    {
      _cs = cs;
    }

    [HttpGet] // .get('')
    public ActionResult<IEnumerable<Cat>> Get()
    {
      try
      {
        List<Cat> cats = _cs.Get();
        return Ok(cats);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // the {} translation :
    // id is now a parameter
    // these are got in as parameters
    [HttpGet("{id}")] // .get('/:id')
    public ActionResult<Cat> Get(string id)
    {
      try
      {
        Cat cat = _cs.Get(id);
        return Ok(cat);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    [HttpDelete("{id}")]
    public ActionResult<String> Remove(string id)
    {
      try
      {
        _cs.Remove(id);
        return Ok("Adopted");
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


  }
}