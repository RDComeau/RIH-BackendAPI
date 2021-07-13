using KellermanSoftware.CompareNetObjects;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using Server.Controllers.VersionOne;
using RIH_GameLogic.Models.VersionOne;
using RIH_GameLogic.Models.VersionOne.Devouts;
using RIH_GameLogic.Models.VersionOne.Leaders;
using RIH_GameLogic.Models.VersionOne.Minions.GreaterDemons;
using RIH_GameLogic.Models.VersionOne.Minions.LesserDemons;
using RIH_GameLogic.Models.VersionOne.Minions.SuperiorDemons;
using RIH_GameLogic.Services.VersionOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RIH_GameLogic.Services.VersionOne;

namespace Server.Test.Controllers.VersionOne
{
    [TestFixture]
    public class UnitsInformationControllerTest
    {
        UnitsInformationControllerV1 _controller;
        Mock<IUnitsInformationServiceV1> _service;

        [SetUp]
        public void SetUp()
        {
            _service = new Mock<IUnitsInformationServiceV1>();
            _controller = new UnitsInformationControllerV1(_service.Object);
        }

        #region Leaders
        [Test]
        public void GetWarriorInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            Warrior warrior = new Warrior()
            {
                combat = Faker.RandomNumber.Next(0, 10),
                cost = Faker.RandomNumber.Next(0, 10),
                life = Faker.RandomNumber.Next(0, 10),
                move = Faker.RandomNumber.Next(0, 10),
                fly = Faker.Boolean.Random()
            };

            _service.Setup(x => x.GetWarriorInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetWarriorInformation(), Times.Once);
                })
                .Returns(warrior);

            ObjectResult expectedHttpResponse = new ObjectResult(warrior);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<Warrior> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<Warrior> actualResult = _controller.GetWarriorInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetSchemerInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            Schemer schemer = new Schemer();

            _service.Setup(x => x.GetSchemerInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetSchemerInformation(), Times.Once);
                })
                .Returns(schemer);

            ObjectResult expectedHttpResponse = new ObjectResult(schemer);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<Schemer> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<Schemer> actualResult = _controller.GetSchemerInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetZealotInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            Zealot zealot = new Zealot();

            _service.Setup(x => x.GetZealotInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetZealotInformation(), Times.Once);
                })
                .Returns(zealot);

            ObjectResult expectedHttpResponse = new ObjectResult(zealot);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<Zealot> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<Zealot> actualResult = _controller.GetZealotInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetAllLeadersInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            List<BaseUnit> allLeadersList = new List<BaseUnit>()
            {
                new Warrior(),
                new Schemer(),
                new Zealot()
            };

            _service.Setup(x => x.GetAllLeadersInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetAllLeadersInformation(), Times.Once);
                })
                .Returns(allLeadersList);

            ObjectResult expectedHttpResponse = new ObjectResult(allLeadersList);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<List<BaseUnit>> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<List<BaseUnit>> actualResult = _controller.GetAllLeadersInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }
        #endregion

        #region Devouts
        [Test]
        public void GetLordOfThePitInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            LordOfThePit lordOfThePit = new LordOfThePit();

            _service.Setup(x => x.GetLordOfThePitInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetLordOfThePitInformation(), Times.Once);
                })
                .Returns(lordOfThePit);

            ObjectResult expectedHttpResponse = new ObjectResult(lordOfThePit);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<LordOfThePit> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<LordOfThePit> actualResult = _controller.GetLordOfThePitInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetExecutionerInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            Executioner executioner = new Executioner();

            _service.Setup(x => x.GetExecutionerInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetExecutionerInformation(), Times.Once);
                })
                .Returns(executioner);

            ObjectResult expectedHttpResponse = new ObjectResult(executioner);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<Executioner> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<Executioner> actualResult = _controller.GetExecutionerInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetMadnessDemonInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            MadnessDemon madnessDemon = new MadnessDemon();

            _service.Setup(x => x.GetMadnessDemonInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetMadnessDemonInformation(), Times.Once);
                })
                .Returns(madnessDemon);

            ObjectResult expectedHttpResponse = new ObjectResult(madnessDemon);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<MadnessDemon> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<MadnessDemon> actualResult = _controller.GetMadnessDemonInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetTallymanInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            Tallyman tallyman = new Tallyman();

            _service.Setup(x => x.GetTallymanInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetTallymanInformation(), Times.Once);
                })
                .Returns(tallyman);

            ObjectResult expectedHttpResponse = new ObjectResult(tallyman);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<Tallyman> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<Tallyman> actualResult = _controller.GetTallymanInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetSuccubusInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            Succubus succubus = new Succubus();

            _service.Setup(x => x.GetSuccubusInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetSuccubusInformation(), Times.Once);
                })
                .Returns(succubus);

            ObjectResult expectedHttpResponse = new ObjectResult(succubus);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<Succubus> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<Succubus> actualResult = _controller.GetSuccubusInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetVoidDemonInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            VoidDemon voidDemon = new VoidDemon();

            _service.Setup(x => x.GetVoidDemonInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetVoidDemonInformation(), Times.Once);
                })
                .Returns(voidDemon);

            ObjectResult expectedHttpResponse = new ObjectResult(voidDemon);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<VoidDemon> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<VoidDemon> actualResult = _controller.GetVoidDemonInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetAllDevoutsInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            List<BaseUnit> allDevoutsInformation = new List<BaseUnit>()
            {
                new LordOfThePit(),
                new Executioner(),
                new MadnessDemon(),
                new Tallyman(),
                new Succubus(),
                new VoidDemon()
            };

            _service.Setup(x => x.GetAllDevoutsInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetAllDevoutsInformation(), Times.Once);
                })
                .Returns(allDevoutsInformation);

            ObjectResult expectedHttpResponse = new ObjectResult(allDevoutsInformation);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<List<BaseUnit>> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<List<BaseUnit>> actualResult = _controller.GetAllDevoutsInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }
        #endregion

        #region Minions: Lesser Demons
        [Test]
        public void GetSlaughterFiendInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            SlaughterFiend slaughterFiend = new SlaughterFiend();

            _service.Setup(x => x.GetSlaughterFiendInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetSlaughterFiendInformation(), Times.Once);
                })
                .Returns(slaughterFiend);

            ObjectResult expectedHttpResponse = new ObjectResult(slaughterFiend);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<SlaughterFiend> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<SlaughterFiend> actualResult = _controller.GetSlaughterFiendInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetMephitInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            Mephit mephit = new Mephit();

            _service.Setup(x => x.GetMephitInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetMephitInformation(), Times.Once);
                })
                .Returns(mephit);

            ObjectResult expectedHttpResponse = new ObjectResult(mephit);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<Mephit> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<Mephit> actualResult = _controller.GetMephitInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetTentacleBeastInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            TentacleBeast tentacleBeast = new TentacleBeast();

            _service.Setup(x => x.GetTentacleBeastInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetTentacleBeastInformation(), Times.Once);
                })
                .Returns(tentacleBeast);

            ObjectResult expectedHttpResponse = new ObjectResult(tentacleBeast);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<TentacleBeast> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<TentacleBeast> actualResult = _controller.GetTentacleBeastInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetArmoredDemonInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            ArmoredDemon armoredDemon = new ArmoredDemon();

            _service.Setup(x => x.GetArmoredDemonInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetArmoredDemonInformation(), Times.Once);
                })
                .Returns(armoredDemon);

            ObjectResult expectedHttpResponse = new ObjectResult(armoredDemon);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<ArmoredDemon> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<ArmoredDemon> actualResult = _controller.GetArmoredDemonInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetSpinedDemonInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            SpinedDemon spinedDemon = new SpinedDemon();

            _service.Setup(x => x.GetSpinedDemonInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetSpinedDemonInformation(), Times.Once);
                })
                .Returns(spinedDemon);

            ObjectResult expectedHttpResponse = new ObjectResult(spinedDemon);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<SpinedDemon> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<SpinedDemon> actualResult = _controller.GetSpinedDemonInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetCorpulentDemonInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            CorpulentDemon corpulentDemon = new CorpulentDemon();

            _service.Setup(x => x.GetCorpulentDemonInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetCorpulentDemonInformation(), Times.Once);
                })
                .Returns(corpulentDemon);

            ObjectResult expectedHttpResponse = new ObjectResult(corpulentDemon);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<CorpulentDemon> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<CorpulentDemon> actualResult = _controller.GetCorpulentDemonInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetAllLesserDemonsInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            List<BaseUnit> allLesserDemonsInformation = new List<BaseUnit>()
            {
                new SlaughterFiend(),
                new Mephit(),
                new TentacleBeast(),
                new SpinedDemon(),
                new CorpulentDemon()
            };

            _service.Setup(x => x.GetAllLesserDemonsInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetAllLesserDemonsInformation(), Times.Once);
                })
                .Returns(allLesserDemonsInformation);

            ObjectResult expectedHttpResponse = new ObjectResult(allLesserDemonsInformation);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<List<BaseUnit>> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<List<BaseUnit>> actualResult = _controller.GetAllLesserDemonsInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }
        #endregion

        #region Minions: Greater Demons
        [Test]
        public void GetTortureMasterInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            TortureMaster tortureMaster = new TortureMaster();

            _service.Setup(x => x.GetTortureMasterInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetTortureMasterInformation(), Times.Once);
                })
                .Returns(tortureMaster);

            ObjectResult expectedHttpResponse = new ObjectResult(tortureMaster);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<TortureMaster> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<TortureMaster> actualResult = _controller.GetTortureMasterInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetSerpentKnightInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            SerpentKnight serpentKnight = new SerpentKnight();

            _service.Setup(x => x.GetSerpentKnightInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetSerpentKnightInformation(), Times.Once);
                })
                .Returns(serpentKnight);

            ObjectResult expectedHttpResponse = new ObjectResult(serpentKnight);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<SerpentKnight> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<SerpentKnight> actualResult = _controller.GetSerpentKnightInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetMarquessDWinterInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            MarquessDWinter marquessDWinter = new MarquessDWinter();

            _service.Setup(x => x.GetMarquessDWinterInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetMarquessDWinterInformation(), Times.Once);
                })
                .Returns(marquessDWinter);

            ObjectResult expectedHttpResponse = new ObjectResult(marquessDWinter);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<MarquessDWinter> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<MarquessDWinter> actualResult = _controller.GetMarquessDWinterInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetAllGreaterDemonsInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            List<BaseUnit> allGreaterDemonsInformation = new List<BaseUnit>()
            {
                new TortureMaster(),
                new SerpentKnight(),
                new MarquessDWinter()
            };

            _service.Setup(x => x.GetAllGreaterDemonsInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetAllGreaterDemonsInformation(), Times.Once);
                })
                .Returns(allGreaterDemonsInformation);

            ObjectResult expectedHttpResponse = new ObjectResult(allGreaterDemonsInformation);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<List<BaseUnit>> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<List<BaseUnit>> actualResult = _controller.GetAllGreaterDemonsInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }
        #endregion

        #region Minions: Superior Demons
        [Test]
        public void GetShadowKingInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            ShadowKing shadowKing = new ShadowKing();

            _service.Setup(x => x.GetShadowKingInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetShadowKingInformation(), Times.Once);
                })
                .Returns(shadowKing);

            ObjectResult expectedHttpResponse = new ObjectResult(shadowKing);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<ShadowKing> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<ShadowKing> actualResult = _controller.GetShadowKingInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetLordOfFlameInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            LordOfFlame lordOfFlame = new LordOfFlame();

            _service.Setup(x => x.GetLordOfFlameInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetLordOfFlameInformation(), Times.Once);
                })
                .Returns(lordOfFlame);

            ObjectResult expectedHttpResponse = new ObjectResult(lordOfFlame);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<LordOfFlame> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<LordOfFlame> actualResult = _controller.GetLordOfFlameInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetVenomQueenInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            VenomQueen venomQueen = new VenomQueen();

            _service.Setup(x => x.GetVenomQueenInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetVenomQueenInformation(), Times.Once);
                })
                .Returns(venomQueen);

            ObjectResult expectedHttpResponse = new ObjectResult(venomQueen);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<VenomQueen> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<VenomQueen> actualResult = _controller.GetVenomQueenInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }

        [Test]
        public void GetAllSuperiorDemonsInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            List<BaseUnit> allSuperiorDemonsInformation = new List<BaseUnit>()
            {
                new ShadowKing(),
                new LordOfFlame(),
                new VenomQueen()
            };

            _service.Setup(x => x.GetAllSuperiorDemonsInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetAllSuperiorDemonsInformation(), Times.Once);
                })
                .Returns(allSuperiorDemonsInformation);

            ObjectResult expectedHttpResponse = new ObjectResult(allSuperiorDemonsInformation);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<List<BaseUnit>> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<List<BaseUnit>> actualResult = _controller.GetAllSuperiorDemons();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }
        #endregion

        #region All Units
        [Test]
        public void GetAllUnitsInformation_ShouldReturn200StatusCode_WhenInvoked()
        {
            //Arrange
            List<BaseUnit> allUnitsInformation = new List<BaseUnit>()
            {
                //Leaders
                new Warrior(),
                new Schemer(),
                new Zealot(),
                //Devouts
                new LordOfThePit(),
                new Executioner(),
                new MadnessDemon(),
                new Tallyman(),
                new Succubus(),
                new VoidDemon(),
                //Minions: Lesser Demons
                new SlaughterFiend(),
                new Mephit(),
                new TentacleBeast(),
                new ArmoredDemon(),
                new SpinedDemon(),
                new CorpulentDemon(),
                //Minions: Greater Demons
                new TortureMaster(),
                new SerpentKnight(),
                new MarquessDWinter(),
                //Minions: Superior Demons
                new ShadowKing(),
                new LordOfFlame(),
                new VenomQueen()
            };

            _service.Setup(x => x.GetAllUnitsInformation())
                .Callback(() =>
                {
                    _service.Verify(x => x.GetAllUnitsInformation(), Times.Once);
                })
                .Returns(allUnitsInformation);

            ObjectResult expectedHttpResponse = new ObjectResult(allUnitsInformation);
            expectedHttpResponse.StatusCode = 200;
            ActionResult<List<BaseUnit>> expectedResult = expectedHttpResponse;

            //Act
            ActionResult<List<BaseUnit>> actualResult = _controller.GetAllUnitsInformation();

            //Assert
            CompareLogic compareLogic = new CompareLogic();
            ComparisonResult compareResult = compareLogic.Compare(expectedResult, actualResult);
            Assert.True(compareResult.AreEqual, compareResult.DifferencesString);
        }
        #endregion
    }
}
