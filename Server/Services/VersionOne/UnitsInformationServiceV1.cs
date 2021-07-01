using Server.Models.VersionOne;
using Server.Models.VersionOne.Devouts;
using Server.Models.VersionOne.Leaders;
using Server.Models.VersionOne.Minions.GreaterDemons;
using Server.Models.VersionOne.Minions.LesserDemons;
using Server.Models.VersionOne.Minions.SuperiorDemons;
using Server.Services.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Services.VersionOne
{
    public class UnitsInformationServiceV1 : IUnitsInformationServiceV1
    {
        public UnitsInformationServiceV1()
        {

        }

        #region Leaders
        public Warrior GetWarriorInformation()
        {
            return new Warrior();
        }

        public Schemer GetSchemerInformation()
        {
            return new Schemer();
        }

        public Zealot GetZealotInformation()
        {
            return new Zealot();
        }

        public List<BaseUnit> GetAllLeadersInformation()
        {
            return new List<BaseUnit>()
            {
                GetWarriorInformation(),
                GetSchemerInformation(),
                GetZealotInformation()
            };
        }
        #endregion

        #region Devouts
        public LordOfThePit GetLordOfThePitInformation()
        {
            return new LordOfThePit();
        }

        public Executioner GetExecutionerInformation()
        {
            return new Executioner();
        }

        public MadnessDemon GetMadnessDemonInformation()
        {
            return new MadnessDemon();
        }

        public Tallyman GetTallymanInformation()
        {
            return new Tallyman();
        }

        public Succubus GetSuccubusInformation()
        {
            return new Succubus();
        }

        public VoidDemon GetVoidDemonInformation()
        {
            return new VoidDemon();
        }

        public List<BaseUnit> GetAllDevoutsInformation()
        {
            return new List<BaseUnit>()
            {
                GetLordOfThePitInformation(),
                GetExecutionerInformation(),
                GetMadnessDemonInformation(),
                GetTallymanInformation(),
                GetSuccubusInformation(),
                GetVoidDemonInformation()
            };
        }
        #endregion

        #region Minions: Lesser Demons
        public SlaughterFiend GetSlaughterFiendInformation()
        {
            return new SlaughterFiend();
        }
        
        public Mephit GetMephitInformation()
        {
            return new Mephit();
        }

        public TentacleBeast GetTentacleBeastInformation()
        {
            return new TentacleBeast();
        }

        public ArmoredDemon GetArmoredDemonInformation()
        {
            return new ArmoredDemon();
        }

        public SpinedDemon GetSpinedDemonInformation()
        {
            return new SpinedDemon();
        }

        public CorpulentDemon GetCorpulentDemonInformation()
        {
            return new CorpulentDemon();
        }

        public List<BaseUnit> GetAllLesserDemonsInformation()
        {
            return new List<BaseUnit>()
            {
                GetSlaughterFiendInformation(),
                GetMephitInformation(),
                GetTentacleBeastInformation(),
                GetArmoredDemonInformation(),
                GetSpinedDemonInformation(),
                GetCorpulentDemonInformation()
            };
        }
        #endregion

        #region Minions: Greater Demons
        public TortureMaster GetTortureMasterInformation()
        {
            return new TortureMaster();
        }

        public SerpentKnight GetSerpentKnightInformation()
        {
            return new SerpentKnight();
        }

        public MarquessDWinter GetMarquessDWinterInformation()
        {
            return new MarquessDWinter();
        }

        public List<BaseUnit> GetAllGreaterDemonsInformation()
        {
            return new List<BaseUnit> 
            {
                GetTortureMasterInformation(),
                GetSerpentKnightInformation(),
                GetMarquessDWinterInformation()
            };
        }
        #endregion

        #region Minions: Superior Demons
        public ShadowKing GetShadowKingInformation()
        {
            return new ShadowKing();
        }

        public LordOfFlame GetLordOfFlameInformation()
        {
            return new LordOfFlame();
        }

        public VenomQueen GetVenomQueenInformation()
        {
            return new VenomQueen();
        }

        public List<BaseUnit> GetAllSuperiorDemons()
        {
            return new List<BaseUnit>()
            {
                GetShadowKingInformation(),
                GetLordOfFlameInformation(),
                GetVenomQueenInformation()
            };
        }
        #endregion

        #region All Units
        public List<BaseUnit> GetAllUnitsInformation()
        {
            List<BaseUnit> allUnits = new List<BaseUnit>();
            allUnits.AddRange(GetAllLeadersInformation());
            allUnits.AddRange(GetAllDevoutsInformation());
            allUnits.AddRange(GetAllLesserDemonsInformation());
            allUnits.AddRange(GetAllGreaterDemonsInformation());
            allUnits.AddRange(GetAllSuperiorDemons());

            return allUnits;
        }
        #endregion
    }
}
