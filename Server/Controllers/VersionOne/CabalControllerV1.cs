using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Services.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers.VersionOne
{
    [Route("api/v1/cabal")]
    [ApiController]
    public class CabalControllerV1 : Controller
    {
        ICabalServiceV1 _service;

        public CabalControllerV1(ICabalServiceV1 service)
        {
            _service = service;
        }

        [HttpPost("gamesession/{id:int}")]
        public ActionResult<Cabal> CreateCabal(int id)
        {
            try
            {
                throw new NotImplementedException();
                //return StatusCode(201, _broker.);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
