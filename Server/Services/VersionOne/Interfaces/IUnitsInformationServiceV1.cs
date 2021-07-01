using Server.Models.VersionOne;
using Server.Models.VersionOne.Devouts;
using Server.Models.VersionOne.Leaders;
using Server.Models.VersionOne.Minions.GreaterDemons;
using Server.Models.VersionOne.Minions.LesserDemons;
using Server.Models.VersionOne.Minions.SuperiorDemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Services.VersionOne.Interfaces
{
    public interface IUnitsInformationServiceV1
    {
        public Warrior GetWarriorInformation();
        public Schemer GetSchemerInformation();
        public Zealot GetZealotInformation();
        public List<BaseUnit> GetAllLeadersInformation();
        public LordOfThePit GetLordOfThePitInformation();
        public Executioner GetExecutionerInformation();
        public MadnessDemon GetMadnessDemonInformation();
        public Tallyman GetTallymanInformation();
        public Succubus GetSuccubusInformation();
        public VoidDemon GetVoidDemonInformation();
        public List<BaseUnit> GetAllDevoutsInformation();
        public SlaughterFiend GetSlaughterFiendInformation();
        public Mephit GetMephitInformation();
        public TentacleBeast GetTentacleBeastInformation();
        public ArmoredDemon GetArmoredDemonInformation();
        public SpinedDemon GetSpinedDemonInformation();
        public CorpulentDemon GetCorpulentDemonInformation();
        public List<BaseUnit> GetAllLesserDemonsInformation();
        public TortureMaster GetTortureMasterInformation();
        public SerpentKnight GetSerpentKnightInformation();
        public MarquessDWinter GetMarquessDWinterInformation();
        public List<BaseUnit> GetAllGreaterDemonsInformation();
        public ShadowKing GetShadowKingInformation();
        public LordOfFlame GetLordOfFlameInformation();
        public VenomQueen GetVenomQueenInformation();
        public List<BaseUnit> GetAllSuperiorDemons();
        public List<BaseUnit> GetAllUnitsInformation();
    }
}
