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

        /// <summary>
        /// Schemer Information
        /// </summary>
        /// <returns>Schemer Json Information</returns>
        /// <response code="200">Returns Schemer Info in Json Format</response>
        [HttpGet("leaders/schemer")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Schemer> GetSchemerInformation()
        {
            return StatusCode(200, _service.GetSchemerInformation());
        }

        /// <summary>
        /// Zealot Information
        /// </summary>
        /// <returns>Zealot Json Information</returns>
        /// <response code="200">Returns Zealot Info in Json Format</response>
        [HttpGet("leaders/zealot")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Zealot> GetZealotInformation()
        {
            return StatusCode(200, _service.GetZealotInformation());
        }

        /// <summary>
        /// Leaders Information
        /// </summary>
        /// <returns>Leaders Json Information</returns>
        /// <response code="200">Returns Leaders Info in Json Format</response>
        [HttpGet("leaders")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<BaseUnit>> GetAllLeadersInformation()
        {
            return StatusCode(200, _service.GetAllLeadersInformation());
        }
        #endregion

        #region Devouts
        /// <summary>
        /// Lord of the Pit Information
        /// </summary>
        /// <returns>Lord of the Pit Json Information</returns>
        /// <response code="200">Returns Lord of the Pit Info in Json Format</response>
        [HttpGet("devouts/lordofthepit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<LordOfThePit> GetLordOfThePitInformation()
        {
            return StatusCode(200, _service.GetLordOfThePitInformation());
        }

        /// <summary>
        /// Executioner Information
        /// </summary>
        /// <returns>Executioner Json Information</returns>
        /// <response code="200">Returns Executioner Info in Json Format</response>
        [HttpGet("devouts/executioner")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Executioner> GetExecutionerInformation()
        {
            return StatusCode(200, _service.GetExecutionerInformation());
        }

        /// <summary>
        /// Madness Demon Information
        /// </summary>
        /// <returns>Madness Demon Json Information</returns>
        /// <response code="200">Returns Madness Demon Info in Json Format</response>
        [HttpGet("devouts/madnessdemon")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<MadnessDemon> GetMadnessDemonInformation()
        {
            return StatusCode(200, _service.GetMadnessDemonInformation());
        }

        /// <summary>
        /// Tallyman Information
        /// </summary>
        /// <returns>Tallyman Json Information</returns>
        /// <response code="200">Returns Tallyman Info in Json Format</response>
        [HttpGet("devouts/tallyman")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Tallyman> GetTallymanInformation()
        {
            return StatusCode(200, _service.GetTallymanInformation());
        }

        /// <summary>
        /// Succubus Information
        /// </summary>
        /// <returns>Succubus Json Information</returns>
        /// <response code="200">Returns Succubus Info in Json Format</response>
        [HttpGet("devouts/succubus")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Succubus> GetSuccubusInformation()
        {
            return StatusCode(200, _service.GetSuccubusInformation());
        }

        /// <summary>
        /// Void Demon Information
        /// </summary>
        /// <returns>Void Demon Json Information</returns>
        /// <response code="200">Returns Void Demon Info in Json Format</response>
        [HttpGet("devouts/voiddemon")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<VoidDemon> GetVoidDemonInformation()
        {
            return StatusCode(200, _service.GetVoidDemonInformation());
        }

        /// <summary>
        /// Devouts Information
        /// </summary>
        /// <returns>Devouts Json Information</returns>
        /// <response code="200">Returns Devouts Info in Json Format</response>
        [HttpGet("devouts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<BaseUnit>> GetAllDevoutsInformation()
        {
            return StatusCode(200, _service.GetAllDevoutsInformation());
        }
        #endregion

        #region Minions: Lesser Demons
        /// <summary>
        /// Lesser Demons: Slaughter Fiend Information
        /// </summary>
        /// <returns>Lesser Demons: Slaughter Fiend Json Information</returns>
        /// <response code="200">Returns Lesser Demons: Slaughter Fiend Info in Json Format</response>
        [HttpGet("minions/lesserdemons/slaughterfiend")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<SlaughterFiend> GetSlaughterFiendInformation()
        {
            return StatusCode(200, _service.GetSlaughterFiendInformation());
        }

        /// <summary>
        /// Lesser Demons: Mephit Information
        /// </summary>
        /// <returns>Lesser Demons: Slaughter Fiend Json Information</returns>
        /// <response code="200">Returns Lesser Demons: Slaughter Fiend Info in Json Format</response>
        [HttpGet("minions/lesserdemons/mephit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Mephit> GetMephitInformation()
        {
            return StatusCode(200, _service.GetMephitInformation());
        }

        /// <summary>
        /// Lesser Demons: Tentacle Beast Information
        /// </summary>
        /// <returns>Lesser Demons: Tentacle Beast Json Information</returns>
        /// <response code="200">Returns Lesser Demons: Tentacle Beast Info in Json Format</response>
        [HttpGet("minions/lesserdemons/tentaclebeast")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<TentacleBeast> GetTentacleBeastInformation()
        {
            return StatusCode(200, _service.GetTentacleBeastInformation());
        }

        /// <summary>
        /// Lesser Demons: Armored Demon Information
        /// </summary>
        /// <returns>Lesser Demons: Armored Demon Json Information</returns>
        /// <response code="200">Returns Lesser Demons: Armored Demon Info in Json Format</response>
        [HttpGet("minions/lesserdemons/armoreddemon")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<ArmoredDemon> GetArmoredDemonInformation()
        {
            return StatusCode(200, _service.GetArmoredDemonInformation());
        }

        /// <summary>
        /// Lesser Demons: Spined Demon Information
        /// </summary>
        /// <returns>Lesser Demons: Spined Demon Json Information</returns>
        /// <response code="200">Returns Lesser Demons: Spined Demon Info in Json Format</response>
        [HttpGet("minions/lesserdemons/spineddemon")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<SpinedDemon> GetSpinedDemonInformation()
        {
            return StatusCode(200, _service.GetSpinedDemonInformation());
        }

        /// <summary>
        /// Lesser Demons: Corpulent Demon Information
        /// </summary>
        /// <returns>Lesser Demons: Corpulent Demon Json Information</returns>
        /// <response code="200">Returns Lesser Demons: Corpulent Demon Info in Json Format</response>
        [HttpGet("minions/lesserdemons/corpulentdemon")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<CorpulentDemon> GetCorpulentDemonInformation()
        {
            return StatusCode(200, _service.GetCorpulentDemonInformation());
        }

        /// <summary>
        /// Lesser Demons Information
        /// </summary>
        /// <returns>Lesser Demons Json Information</returns>
        /// <response code="200">Returns Lesser Demons Info in Json Format</response>
        [HttpGet("minions/lesserdemons")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<BaseUnit>> GetAllLesserDemonsInformation()
        {
            return StatusCode(200, _service.GetAllLesserDemonsInformation());
        }
        #endregion

        #region Minions: Greater Demons
        /// <summary>
        /// Greater Demons: Torture Master Information
        /// </summary>
        /// <returns>Greater Demons: Torture Master Json Information</returns>
        /// <response code="200">Returns Greater Demons: Torture Master Info in Json Format</response>
        [HttpGet("minions/greaterdemons/torturemaster")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<TortureMaster> GetTortureMasterInformation()
        {
            return StatusCode(200, _service.GetTortureMasterInformation());
        }

        /// <summary>
        /// Greater Demons: Serpent Knight Information
        /// </summary>
        /// <returns>Greater Demons: Serpent Knight Json Information</returns>
        /// <response code="200">Returns Greater Demons: Serpent Knight Info in Json Format</response>
        [HttpGet("minions/greaterdemons/serpentknight")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<SerpentKnight> GetSerpentKnightInformation()
        {
            return StatusCode(200, _service.GetSerpentKnightInformation());
        }

        /// <summary>
        /// Greater Demons: Marquess d'Winter Information
        /// </summary>
        /// <returns>Greater Demons: Marquess d'Winter Json Information</returns>
        /// <response code="200">Returns Greater Demons: Marquess d'Winter Info in Json Format</response>
        [HttpGet("minions/greaterdemons/marquessdwinter")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<MarquessDWinter> GetMarquessDWinterInformation()
        {
            return StatusCode(200, _service.GetMarquessDWinterInformation());
        }

        /// <summary>
        /// Greater Demons Information
        /// </summary>
        /// <returns>Greater Demons Json Information</returns>
        /// <response code="200">Returns Greater Demons Info in Json Format</response>
        [HttpGet("minions/greaterdemons")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<BaseUnit>> GetAllGreaterDemonsInformation()
        {
            return StatusCode(200, _service.GetAllGreaterDemonsInformation());
        }
        #endregion

        #region Minions: Superior Demons
        /// <summary>
        /// Superior Demons: Shadow King Information
        /// </summary>
        /// <returns>Superior Demons: Shadow King Json Information</returns>
        /// <response code="200">Returns Superior Demons: Shadow King Info in Json Format</response>
        [HttpGet("minions/superiordemons/shadowking")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<ShadowKing> GetShadowKingInformation()
        {
            return StatusCode(200, _service.GetShadowKingInformation());
        }

        /// <summary>
        /// Superior Demons: Lord of Flame Information
        /// </summary>
        /// <returns>Superior Demons: Lord of Flame Json Information</returns>
        /// <response code="200">Returns Superior Demons: Lord of Flame Info in Json Format</response>
        [HttpGet("minions/superiordemons/lordofflame")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<LordOfFlame> GetLordOfFlameInformation()
        {
            return StatusCode(200, _service.GetLordOfFlameInformation());
        }

        /// <summary>
        /// Superior Demons: Venom Queen Information
        /// </summary>
        /// <returns>Superior Demons: Venom Queen Json Information</returns>
        /// <response code="200">Returns Superior Demons: Venom Queen Info in Json Format</response>
        [HttpGet("minions/superiordemons/venomqueen")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<VenomQueen> GetVenomQueenInformation()
        {
            return StatusCode(200, _service.GetVenomQueenInformation());
        }

        /// <summary>
        /// Superior Demons Information
        /// </summary>
        /// <returns>Superior Demons Json Information</returns>
        /// <response code="200">Returns Superior Demons Info in Json Format</response>
        [HttpGet("minions/superiordemons")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<BaseUnit>> GetAllSuperiorDemons()
        {
            return StatusCode(200, _service.GetAllSuperiorDemonsInformation());
        }
        #endregion

        #region All Units
        /// <summary>
        /// All Units Information
        /// </summary>
        /// <returns>All Units Json Information</returns>
        /// <response code="200">Returns All Units Info in Json Format</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<BaseUnit>> GetAllUnitsInformation()
        {
            return StatusCode(200, _service.GetAllUnitsInformation());
        }
        #endregion
    }
}
