﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fire_Emblem_Empires;
using Fire_Emblem_Empires.Unit_Management;

namespace Fire_Emblem_Empires_Tests
{
    [TestClass]
    public class EstebanTest
    {
        [TestMethod]
        public void BattleTest()
        {
            BattleManager bm = new BattleManager();
            Unit fb1 = new Fighter(Team.BLUE, 27, 27, 10, 5, 4, 0);
            Unit sb1 = new Soldier(Team.BLUE, 24, 24, 7, 4, 8, 1);
            Unit mb1 = new Mercenary(Team.BLUE, 21, 21, 6, 8, 4, 1);
            Unit hb1 = new Healer(Team.BLUE, 18, 18, 4, 4, 2, 5);

            Unit fr1 = new Fighter(Team.RED, 27, 27, 10, 5, 4, 0);
            Unit sr1 = new Soldier(Team.RED, 24, 24, 7, 4, 8, 1);
            Unit mr1 = new Mercenary(Team.RED, 21, 21, 6, 8, 4, 1);
            Unit hr1 = new Healer(Team.RED, 18, 18, 4, 4, 2, 5);

            var expectedDamageRed = 2;
                      
        }
    }
}
