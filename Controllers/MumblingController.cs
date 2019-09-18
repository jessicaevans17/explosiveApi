using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace explosiveapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MumblingController : ControllerBase
  {
    [HttpGet("{letters}")]
    public ActionResult<string> Get(string letters)
    {
      return string.Join("-", letters.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
    }
  }
}