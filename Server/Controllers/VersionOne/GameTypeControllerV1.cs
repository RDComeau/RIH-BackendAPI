using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RIH_GameLogic.Models.VersionOne.GameTypes;
using RIH_GameLogic.Models.VersionOne.Requests;
using RIH_GameLogic.Services.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers.VersionOne
{
    [Route("api/v1/gametypes")]
    [ApiController]
    public class GameTypeControllerV1 : Controller
    {
        IGameTypesServiceV1 _gameTypesServices;

        public GameTypeControllerV1(IGameTypesServiceV1 gameTypesServices)
        {
            _gameTypesServices = gameTypesServices;
        }

        /// <summary>
        /// Send All Game Types
        /// </summary>
        /// <returns>Returns Information on All Game Types</returns>
        /// <response code="200">Game Types</response>
        /// <response code="500">Server Error</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<BaseGameTypes>> GetAllGameTypes()
        {
            try
            {
                return StatusCode(200, _gameTypesServices.GetAllGameTypes());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Send Campaign Game Types
        /// </summary>
        /// <returns>Returns Information on Campaign Game Types</returns>
        /// <response code="200">Campaign Information</response>
        /// <response code="500">Server Error</response>
        [HttpGet("campaign")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Campaigns> GetCampaignGameType()
        {
            try
            {
                return StatusCode(200, _gameTypesServices.GetCampaignInformation());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Send Learning Game Types
        /// </summary>
        /// <returns>Returns Information on Learning Game Types</returns>
        /// <response code="200">Learning Information</response>
        /// <response code="500">Server Error</response>
        [HttpGet("Learning")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Learnings> GetLearningGameType()
        {
            try
            {
                return StatusCode(200, _gameTypesServices.GetLearningInformation());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Send Standard Game Types
        /// </summary>
        /// <returns>Returns Information on Standard Game Types</returns>
        /// <response code="200">Standard Information</response>
        /// <response code="500">Server Error</response>
        [HttpGet("Standard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Learnings> GeStandardGameType()
        {
            try
            {
                return StatusCode(200, _gameTypesServices.GetStandardInformation());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Create Game Type
        /// </summary>
        /// <returns>Creates Game Types</returns>
        /// <response code="201">Standard Information</response>
        /// <response code="500">Server Error</response>
        [HttpPost("create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<BaseGameTypes> GeStandardGameType(GameTypeRequests request)
        {
            try
            {
                BaseGameTypes customGame = _gameTypesServices.CreateGameType(request);

                return StatusCode(200, customGame);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
