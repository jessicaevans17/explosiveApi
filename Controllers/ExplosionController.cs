using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace explosiveapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExplosionController : ControllerBase
  {
    [HttpGet("{numbers}")]
    public ActionResult<string> Get(string numbers)
    {
      var x = String.Join("", numbers.Select((number, i) => String.Join("", Enumerable.Repeat(number, (int)Char.GetNumericValue(number)))));

      return x;
    }
  }
}