using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Championship.Domain.Entities;
using Championship.Domain.Models;
using System.Collections.Generic;

namespace Championship.Tests
{
    [TestClass]
    public class TableTests
    {
        private Table _table;
        public void createTable()
        {

            Table table = new Table();
            Team firstPlace = new Team();
            firstPlace.Name = "First Team";
            firstPlace.Score = 3;

            Team secondPlace = new Team();
            secondPlace.Name = "Second Team";
            secondPlace.Score = 2;

            Team tirdhPlace = new Team();
            tirdhPlace.Name = "Tirdh Team";
            tirdhPlace.Score = 1;

            Team foruthPlace = new Team();
            foruthPlace.Name = "Fourth Team";
            foruthPlace.Score = 1;

            table.keys = new List<Key>();
   
            Key key = new Key();

            key.Name = "First Key";
            key.Teams = new List<Team>();
            key.Teams.Add(firstPlace);
            key.Teams.Add(secondPlace);
            key.Teams.Add(tirdhPlace);
            key.Teams.Add(foruthPlace);

            table.keys.Add(key);

            _table = table;

        }

        public void createTableWDraw()
        {

            Table table = new Table();
            Team firstPlace = new Team();
            firstPlace.Name = "First Team";
            firstPlace.Score = 3;

            Team secondPlace = new Team();
            secondPlace.Name = "Second Team";
            secondPlace.Score = 2;

            Team tirdhPlace = new Team();
            tirdhPlace.Name = "Tirdh Team";
            tirdhPlace.Score = 2;

            Team foruthPlace = new Team();
            foruthPlace.Name = "Fourth Team";
            foruthPlace.Score = 1;

            table.keys = new List<Key>();

            Key key = new Key();

            key.Name = "First Key";
            key.Teams = new List<Team>();
            key.Teams.Add(firstPlace);
            key.Teams.Add(secondPlace);
            key.Teams.Add(tirdhPlace);
            key.Teams.Add(foruthPlace);

            table.keys.Add(key);

            _table = table;

        }

        [TestMethod]
        public void IncreaseWinnerScoreAndSecondPlaceIsTheNewFirst()
        {
            //Arange
            createTable();
            _table.keys[0].IncreaseWinnerScore(_table.keys[0].Teams[1]);

            //Assert
            Assert.AreEqual(_table.keys[0].Teams[0].Score, 5);
            Assert.AreEqual(_table.keys[0].Teams[0].Name, "Second Team");
        }

        [TestMethod]
        public void UnDrawKey()
        {
            //Arange
            createTable();
            _table.keys[0].IncreaseWinnerScore(_table.keys[0].Teams[1]);

            //Assert
            Assert.AreEqual(_table.keys[0].Teams[0].Score, 5);
            Assert.AreEqual(_table.keys[0].Teams[0].Name, "Second Team");
        }

    }
}
