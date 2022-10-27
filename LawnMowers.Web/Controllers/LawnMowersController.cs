using LawnMowers.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawnMowers.Web.Controllers
{
    [Route("api/SLMMController")]
    [ApiController]
    public class LawnMowersController : ControllerBase
    {

        [HttpGet]
        [Route("reset")]
        public IActionResult Reset()
        {
            LawnMower lawnMower = new LawnMower(0, 0, LawnMower.Direction.N, 0, 0);
            return Ok(lawnMower.GetPosition());
        }


        [HttpGet]
        [Route("position")]
        public IActionResult GePosition()
        {
            LawnMower lawnMower = new LawnMower(0, 0, LawnMower.Direction.N, 0, 0);
            return Ok(lawnMower.GetPosition());
        }

        [HttpGet]
        [Route("Moveonestep")]
        public IActionResult Move()
        {
            LawnMower lawnMower = new LawnMower(0, 0, LawnMower.Direction.N, 0, 0);
            lawnMower.Move();
            return Ok();
        }


        [HttpGet]
        [Route("ChangeDirection")]
        public IActionResult ChangeDirection(LawnMower.Command command )
        {
            LawnMower lawnMower = new LawnMower(0, 0, LawnMower.Direction.N, 0, 0);
            lawnMower.ChangeDirection(command);
            return Ok();
        }

    }
}
