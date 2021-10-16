using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Requests;
using RIH_GameLogic.Services.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RIH_GameLogic.Models.VersionOne.Enums.Rules;

namespace Server.Controllers.VersionOne
{
    [Route("api/v1/gamesession")]
    [ApiController]
    public class GameSessionControllerV1 : Controller
    {
        private IGameSessionServiceV1 _service;

        public GameSessionControllerV1(IGameSessionServiceV1 service)
        {
            _service = service;
        }

        /// <summary>
        /// Create New Game
        /// </summary>
        /// <returns>Returns Information on the Game Session</returns>
        /// <response code="201">New Game Created</response>
        /// <response code="409">Unable to Create</response>
        /// <response code="500">Error in Creating Game</response>
        [HttpPost("newgame")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GameSession> CreateNewGame(GameSessionAddRequest createSession)
        {
            try
            {
                GameSession session = _service.CreateSession(createSession);

                if (session == null)
                {
                    return StatusCode(201, session);
                }
                else
                {
                    return StatusCode(409);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Selects Game Session by Primary Key Id
        /// </summary>
        /// <returns>Returns Information on the Game Session</returns>
        /// <response code="200">Game Session Json Body</response>
        /// <response code="404">Unable to Find Game Session</response>
        /// <response code="500">Error in Finding Game Session</response>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GameSession> SelectGame(int id)
        {
            try
            {
                GameSession session = _service.SelectGame(id);

                if (session == null)
                {
                    return StatusCode(404, "Resources Not Found");
                }
                else
                {
                    return StatusCode(200, session);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Selects Game Session by Primary Key Id and Creator Cabal Id
        /// </summary>
        /// <returns>Returns Information on the Game Session</returns>
        /// <response code="200">Game Session Json Body</response>
        /// <response code="404">Unable to Find Game Session</response>
        /// <response code="500">Error in Finding Game Session</response>
        [HttpGet("{id:int}/creatorcabal/{creatorCabalId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GameSession> SelectGame(int id, int creatorCabalId)
        {
            try
            {
                GameSession session = _service.SelectGame(id, creatorCabalId);

                if (session == null)
                {
                    return StatusCode(404, "Resources Not Found");
                }
                else
                {
                    return StatusCode(200, session);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Selects Game Session by Primary Key Id, Creator Cabal Id, and Acceptor Id
        /// </summary>
        /// <returns>Returns Information on the Game Session</returns>
        /// <response code="200">Game Session Json Body</response>
        /// <response code="404">Unable to Find Game Session</response>
        /// <response code="500">Error in Finding Game Session</response>
        [HttpGet("{id:int}/creatorcabal/{creatorCabalId:int}/acceptorcabal/{acceptorCabalId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GameSession> SelectGame(int id, int creatorCabalId, int acceptorCabalId)
        {
            try
            {
                GameSession session = _service.SelectGame(id, creatorCabalId, acceptorCabalId);

                if (session == null)
                {
                    return StatusCode(404, "Resources Not Found");
                }
                else
                {
                    return StatusCode(200, session);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Selects Open Games
        /// </summary>
        /// <returns>Returns Information on the Game Session</returns>
        /// <response code="200">Game Session Json Body</response>
        /// <response code="500">Error in Finding Open Game Session</response>
        [HttpGet("open")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GameSession> SelectAllOpenGames()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Second Player Accepts Game
        /// </summary>
        /// <returns>Returns Information on the Game Session</returns>
        /// <response code="200">Game Session Json Body</response>
        /// <response code="500">Error in Accepting Game Session</response>
        [HttpPost("acceptgame")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GameSession> AcceptGame(GameSessionAddRequest accepctSession)
        {
            try
            {
                GameSession session = _service.AcceptGame(accepctSession);

                return StatusCode(200, session);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Deletes Game
        /// </summary>
        /// <response code="204">Game Session Json Body</response>
        /// <response code="500">Error in Accepting Game Session</response>
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GameSession> DeleteGame(GameSessionDeleteRequest deleteGame)
        {
            try
            {
                _service.DeleteGame(deleteGame);

                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
