using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Requests;
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

        /// <summary>
        /// Create Cabal
        /// </summary>
        /// <returns>Returns Information on Cabal</returns>
        /// <response code="201">New Cabal Created</response>
        /// <response code="500">Error in Creating Cabal</response>
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Cabal> CreateCabal(CabalAddRequests cabalAddRequests)
        {
            Cabal cabal = _service.CreateCabal(cabalAddRequests);
            try
            {
                if (cabal == null)
                {
                    return StatusCode(409);
                }
                else
                {
                    return StatusCode(201, cabal);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
