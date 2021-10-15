using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RIH_GameLogic.Models.VersionOne.Leaders;
using RIH_GameLogic.Models.VersionOne.Minions.GreaterDemons;
using RIH_GameLogic.Models.VersionOne.Minions.LesserDemons;
using RIH_GameLogic.Models.VersionOne.Minions.SuperiorDemons;
using RIH_GameLogic.Services.VersionOne.Interfaces;
using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Devouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers.VersionOne
{
    [Produces("application/json")]
    [Route("api/v1/unitsinformation")]
    [ApiController]
    public class UnitsInformationControllerV1 : Controller
    {
        private IUnitsInformationServiceV1 _service;

        public UnitsInformationControllerV1(IUnitsInformationServiceV1 service)
        {
            _service = service;
        }

        #region Leaders
        /// <summary>
        /// Warrior Information
        /// </summary>
        /// <returns>Warrior Json Information</returns>
        /// <response code="200">Returns Warrior Info in Json Format</response>
        [HttpGet("leaders/warrior")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Warrior> GetWarriorInformation()
        {
            return StatusCode(200, _service.GetWarriorInformation());
        }

        [HttpGet("leaders/schemer")]
        public ActionResult<Schemer> GetSchemerInformation()
        {
            return StatusCode(200, _service.GetSchemerInformation());
        }

        [HttpGet("leaders/zealot")]
        public ActionResult<Zealot> GetZealotInformation()
        {
            return StatusCode(200, _service.GetZealotInformation());
        }

        [HttpGet("leaders")]
        public ActionResult<List<BaseUnit>> GetAllLeadersInformation()
        {
            return StatusCode(200, _service.GetAllLeadersInformation());
        }
        #endregion

        #region Devouts
        [HttpGet("devouts/lordofthepit")]
        public ActionResult<LordOfThePit> GetLordOfThePitInformation()
        {
            return StatusCode(200, _service.GetLordOfThePitInformation());
        }

        [HttpGet("devouts/executioner")]
        public ActionResult<Executioner> GetExecutionerInformation()
        {
            return StatusCode(200, _service.GetExecutionerInformation());
        }

        [HttpGet("devouts/madnessdemon")]
        public ActionResult<MadnessDemon> GetMadnessDemonInformation()
        {
            return StatusCode(200, _service.GetMadnessDemonInformation());
        }

        [HttpGet("devouts/tallyman")]
        public ActionResult<Tallyman> GetTallymanInformation()
        {
            return StatusCode(200, _service.GetTallymanInformation());
        }

        [HttpGet("devouts/succubus")]
        public ActionResult<Succubus> GetSuccubusInformation()
        {
            return StatusCode(200, _service.GetSuccubusInformation());
        }

        [HttpGet("devouts/voiddemon")]
        public ActionResult<VoidDemon> GetVoidDemonInformation()
        {
            return StatusCode(200, _service.GetVoidDemonInformation());
        }

        [HttpGet("devouts")]
        public ActionResult<List<BaseUnit>> GetAllDevoutsInformation()
        {
            return StatusCode(200, _service.GetAllDevoutsInformation());
        }
        #endregion

        #region Minions: Lesser Demons
        [HttpGet("minions/lesserdemons/slaughterfiend")]
        public ActionResult<SlaughterFiend> GetSlaughterFiendInformation()
        {
            return StatusCode(200, _service.GetSlaughterFiendInformation());
        }

        [HttpGet("minions/lesserdemons/mephit")]
        public ActionResult<Mephit> GetMephitInformation()
        {
            return StatusCode(200, _service.GetMephitInformation());
        }

        [HttpGet("minions/lesserdemons/tentaclebeast")]
        public ActionResult<TentacleBeast> GetTentacleBeastInformation()
        {
            return StatusCode(200, _service.GetTentacleBeastInformation());
        }

        [HttpGet("minions/lesserdemons/armoreddemon")]
        public ActionResult<ArmoredDemon> GetArmoredDemonInformation()
        {
            return StatusCode(200, _service.GetArmoredDemonInformation());
        }

        [HttpGet("minions/lesserdemons/spineddemon")]
        public ActionResult<SpinedDemon> GetSpinedDemonInformation()
        {
            return StatusCode(200, _service.GetSpinedDemonInformation());
        }

        [HttpGet("minions/lesserdemons/corpulentdemon")]
        public ActionResult<CorpulentDemon> GetCorpulentDemonInformation()
        {
            return StatusCode(200, _service.GetCorpulentDemonInformation());
        }

        [HttpGet("minions/lesserdemons")]
        public ActionResult<List<BaseUnit>> GetAllLesserDemonsInformation()
        {
            return StatusCode(200, _service.GetAllLesserDemonsInformation());
        }
        #endregion

        #region Minions: Greater Demons
        [HttpGet("minions/greaterdemons/torturemaster")]
        public ActionResult<TortureMaster> GetTortureMasterInformation()
        {
            return StatusCode(200, _service.GetTortureMasterInformation());
        }

        [HttpGet("minions/greaterdemons/serpentknight")]
        public ActionResult<SerpentKnight> GetSerpentKnightInformation()
        {
            return StatusCode(200, _service.GetSerpentKnightInformation());
        }

        [HttpGet("minions/greaterdemons/marquessdwinter")]
        public ActionResult<MarquessDWinter> GetMarquessDWinterInformation()
        {
            return StatusCode(200, _service.GetMarquessDWinterInformation());
        }

        [HttpGet("minions/greaterdemons")]
        public ActionResult<List<BaseUnit>> GetAllGreaterDemonsInformation()
        {
            return StatusCode(200, _service.GetAllGreaterDemonsInformation());
        }
        #endregion

        #region Minions: Superior Demons
        [HttpGet("minions/superiordemons/shadowking")]
        public ActionResult<ShadowKing> GetShadowKingInformation()
        {
            return StatusCode(200, _service.GetShadowKingInformation());
        }

        [HttpGet("minions/superiordemons/lordofflame")]
        public ActionResult<LordOfFlame> GetLordOfFlameInformation()
        {
            return StatusCode(200, _service.GetLordOfFlameInformation());
        }

        [HttpGet("minions/superiordemons/venomqueen")]
        public ActionResult<VenomQueen> GetVenomQueenInformation()
        {
            return StatusCode(200, _service.GetVenomQueenInformation());
        }

        [HttpGet("minions/superiordemons")]
        public ActionResult<List<BaseUnit>> GetAllSuperiorDemons()
        {
            return StatusCode(200, _service.GetAllSuperiorDemonsInformation());
        }
        #endregion

        #region All Units
        [HttpGet]
        public ActionResult<List<BaseUnit>> GetAllUnitsInformation()
        {
            return StatusCode(200, _service.GetAllUnitsInformation());
        }
        #endregion
    }
}
