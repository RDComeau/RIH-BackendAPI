using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RIH_GameLogic.Brokers.VersionOne.Interfaces;
using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers.VersionOne
{
    [Route("api/v1/gamesession")]
    [ApiController]
    public class GameSessionController : Controller
    {
        private IGameSessionBrokerV1 _broker;

        public GameSessionController(IGameSessionBrokerV1 broker)
        {
            _broker = broker;
        }

        [HttpPost("newgame")]
        public ActionResult<GameSession> CreateNewGame(GameSessionAddRequest createSession)
        {
            try
            {
                GameSession session = _broker.NewGameSession(createSession);

                return StatusCode(201, session);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public ActionResult<GameSession> SelectGame(int id)
        {
            try
            {
                GameSession session = _broker.SelectGameSession(id);

                if(session == null)
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

        [HttpGet("{id:int}/creatorcabal/{creatorCabalId:int}")]
        public ActionResult<GameSession> SelectGame(int id, int creatorCabalId)
        {
            try
            {
                GameSession session = _broker.SelectGameSession(id, creatorCabalId);

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

        [HttpGet("{id:int}/creatorcabal/{creatorCabalId:int}/acceptorcabal/{acceptorCabalId:int}")]
        public ActionResult<GameSession> SelectGame(int id, int creatorCabalId, int acceptorCabalId)
        {
            try
            {
                GameSession session = _broker.SelectGameSession(id, creatorCabalId, acceptorCabalId);

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

        [HttpGet("open")]
        public ActionResult<GameSession> SelectAllOpenGames()
        {
            throw new NotImplementedException();
        }

        [HttpPost("acceptgame")]
        public ActionResult<GameSession> AcceptGame(GameSessionAddCabalRequest accepctSession)
        {
            try
            {
                GameSession session = _broker.AcceptGame(accepctSession);

                return StatusCode(200, session);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        public ActionResult<GameSession> DeleteGame(GameSessionDeleteRequest deleteGame)
        {
            try
            {
                _broker.DeleteGameSession(deleteGame);

                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
