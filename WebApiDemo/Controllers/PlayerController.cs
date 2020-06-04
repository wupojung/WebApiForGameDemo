using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {

        // api/Player/{id}
        [Route("{id}")]
        public Player Index(int id)
        {
            return PlayerFake.Instance.GetPlayerById(id);
        }
    }
}
