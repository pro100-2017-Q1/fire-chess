﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Fire_Emblem_Empires.Unit_Creation;


namespace Fire_Emblem_Empires_Tests.Unit_Unit_Tests
{
    [TestClass]
    public class UnitCreationUnitTests
    {
        // Some units to test
        Unit mercenaryOne = new Mercenary(Team.BLUE, 20, 16, 9, 8, 7, 6, true);
        Unit mercenaryTwo = new Mercenary(Team.RED);
        Unit mercenaryThree = new Mercenary(Team.GREEN);
        Unit fighterOne = new Fighter(Team.BLUE);
        Unit mageOne = new Mage(Team.RED);
        Unit healerOne = new Healer(Team.BLUE);
        Unit soldierOne = new Soldier(Team.GREEN);
        Unit soldierTwo = new Soldier(Team.BLUE, 20, 20, 5, 6, 5, 5, true);

        [TestMethod]
        public void OverloadedUnitHasCorrectMaxHealth()
        {
            Unit mercenaryOne = new Mercenary(Team.BLUE, 20, 16, 9, 8, 7, 6, true);
            byte expectedResult = 20;
            byte actualResult = mercenaryOne.m_MaxHealth;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OverloadedUnitHasCorrectCurrentHealth()
        {
            Unit mercenaryOne = new Mercenary(Team.BLUE, 20, 16, 9, 8, 7, 6, true);
            byte expectedResult = 16;
            byte actualResult = mercenaryOne.m_CurrentHealth;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OverloadedUnitHasCorrectAttack()
        {
            Unit mercenaryOne = new Mercenary(Team.BLUE, 20, 16, 9, 8, 7, 6, true);
            byte expectedResult = 9;
            byte actualResult = mercenaryOne.m_Attack;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OverloadedUnitHasCorrectSpeed()
        {
            Unit mercenaryOne = new Mercenary(Team.BLUE, 20, 16, 9, 8, 7, 6, true);
            byte expectedResult = 8;
            byte actualResult = mercenaryOne.m_Speed;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OverloadedUnitHasCorrectDefense()
        {
            Unit mercenaryOne = new Mercenary(Team.BLUE, 20, 16, 9, 8, 7, 6, true);
            byte expectedResult = 7;
            byte actualResult = mercenaryOne.m_Defense;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OverloadedUnitHasCorrectResistance()
        {
            Unit mercenaryOne = new Mercenary(Team.BLUE, 20, 16, 9, 8, 7, 6, true);
            byte expectedResult = 6;
            byte actualResult = mercenaryOne.m_Resistance;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OverloadedUnitHasCorrectJob()
        {
            Unit mercenaryOne = new Mercenary(Team.BLUE, 20, 16, 9, 8, 7, 6, true);
            Job expectedResult = Job.MERCENARY;
            Job actualResult = mercenaryOne.GetJob();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OverloadedUnitHasCorrectTeam()
        {
            Unit mercenaryOne = new Mercenary(Team.BLUE, 20, 16, 9, 8, 7, 6, true);
            Team expectedResult = Team.BLUE;
            Team actualResult = mercenaryOne.GetTeamColor();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OverloadedUnitHasCorrectMovementAssignment()
        {
            Unit mercenaryOne = new Mercenary(Team.BLUE, 20, 16, 9, 8, 7, 6, true);
            bool expectedResult = true;
            bool actualResult = mercenaryOne.CanTakeAction();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OverloadedUnitIsAlive()
        {
            Unit mercenaryOne = new Mercenary(Team.BLUE, 20, 16, 9, 8, 7, 6, true);
            bool expectedResult = true;
            bool actualResult = mercenaryOne.IsAlive();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void UnitCanNoLongerMove()
        {
            Unit fighterOne = new Fighter(Team.BLUE);
            // Make sure the fighter can move
            bool expectedResult = true;
            bool actualResult = fighterOne.CanTakeAction();
            Assert.AreEqual(expectedResult, actualResult);

            // Tell the fighter it is unable to move
            fighterOne.isNowUnableToTakeAction();

            // Check if the fighter is unable to move
            expectedResult = false;
            actualResult = fighterOne.CanTakeAction();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void UnitThatWasUnableToMoveCanNowMove()
        {
            Unit mageOne = new Mage(Team.RED);
            // Make sure the mage can move
            bool expectedResult = true;
            bool actualResult = mageOne.CanTakeAction();
            Assert.AreEqual(expectedResult, actualResult);

            // Tell the mage it is unable to move
            mageOne.isNowUnableToTakeAction();

            // Make sure the mage cannot move
            expectedResult = false;
            actualResult = mageOne.CanTakeAction();
            Assert.AreEqual(expectedResult, actualResult);

            // Tell the mage it is able to 
            mageOne.isNowAbleToTakeAction();

            // check if the mage is unable to move
            expectedResult = true;
            actualResult = mageOne.CanTakeAction();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void UnitCanDie()
        {
            Unit healerOne = new Healer(Team.BLUE);
            //Make sure that the healer is alive
            bool expectedResult = true;
            bool actualResult = healerOne.IsAlive();
            Assert.AreEqual(expectedResult, actualResult);

            // Tell the healer it is dead
            healerOne.isNowDead();

            expectedResult = false;
            actualResult = healerOne.IsAlive();
            Assert.AreEqual(expectedResult, actualResult);
        }

        public void HealerIsAHealer()
        {
            Unit healerOne = new Healer(Team.BLUE);
            Job expectedResult = Job.HEALER;
            Job actualResult = healerOne.GetJob();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MageIsAMage()
        {
            Unit mageOne = new Mage(Team.RED);
            Job expectedResult = Job.MAGE;
            Job actualResult = mageOne.GetJob();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SoldierIsASoldier()
        {
            Job expectedResult = Job.SOLDIER;
            Job actualResult = soldierOne.GetJob();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FighterIsAFighter()
        {
            Job expectedResult = Job.FIGHTER;
            Job actualResult = fighterOne.GetJob();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MercenaryIsAMercenary()
        {
            Job expectedResult = Job.MERCENARY;
            Job actualResult = mercenaryTwo.GetJob();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void UnitCanBeAssignedToBlueTeam()
        {
            Team expectedResult = Team.BLUE;
            Team actualResult = fighterOne.GetTeamColor();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void UnitCanBeAssignedToRedTeam()
        {
            Team expectedResult = Team.RED;
            Team actualResult = mercenaryTwo.GetTeamColor();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void UnitCanBeAssignedToGreenTeam()
        {
            Team expectedResult = Team.GREEN;
            Team actualResult = mercenaryThree.GetTeamColor();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void UnitIsHealthyOnCreation()
        {
            byte expectedResult = healerOne.m_MaxHealth;
            byte actualResult   = healerOne.m_CurrentHealth;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void UnitMovementRangeIsCorrectlyCalculated()
        {
            byte expectedResult = 6;
            byte actualResult   = soldierTwo.m_MovementRange;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
