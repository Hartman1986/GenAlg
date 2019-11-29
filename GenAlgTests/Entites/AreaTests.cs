using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenAlg.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenAlg.Entites.AreaObjects;
using GenAlg.Interfaces;
using GenAlg.Enums;

namespace GenAlg.Entites.Tests
{
    [TestClass()]
    public class AreaTests
    {

        [TestMethod()]
        public void AddTest()
        {
            Area area = new Area(2, 2);
            //Empty emptyobj = new Empty();
            //area.Add(emptyobj);
            Assert.AreEqual(0, area[0].Position.X);
            Assert.AreEqual(0, area[0].Position.Y);
            Assert.AreEqual(1, area[1].Position.X);
            Assert.AreEqual(0, area[1].Position.Y);
            Assert.AreEqual(0, area[2].Position.X);
            Assert.AreEqual(1, area[2].Position.Y);
            Assert.AreEqual(1, area[3].Position.X);
            Assert.AreEqual(1, area[3].Position.Y);
        }
        [TestMethod()]
        public void AddIndexOutRangeTest()
        {
            Area area = new Area(2, 2);
            Assert.ThrowsException<IndexOutOfRangeException>(() => area.Add(new Empty()));
        }

        [TestMethod()]
        public void InsertTest()
        {
            Area area = new Area(2, 2);
            for (int i = 0; i < 4; i++)
            {
                IAreaObject obj = new Empty();
                area.Add(obj);
            }

            IAreaObject wall = new Wall();

            area.Insert(wall);

            Assert.AreEqual(0, wall.Position.X);
            Assert.AreEqual(0, wall.Position.Y);
            Assert.AreEqual(0, area.IndexOf(wall));
            Assert.AreEqual(TypeOfAreaObj.Wall, wall.Type);

            IAreaObject food = new Food();
            food.Position = new Coordinates(1, 1);

            area.Insert(food);
            Assert.AreEqual(3, area.IndexOf(food));
            Assert.AreEqual(TypeOfAreaObj.Food, wall.Type);



        }

        [TestMethod()]
        public void InsertInNonEmptyTest()
        {
            Area area = new Area(2, 2);
            for (int i = 0; i < 4; i++)
            {
                IAreaObject obj = new Empty();
                area.Add(obj);
            }
            IAreaObject wall = new Wall();
            area.Insert(wall);

            IAreaObject food = new Food();
            area.Insert(food);

            Assert.AreEqual(0, wall.Position.X);
            Assert.AreEqual(0, wall.Position.Y);
            Assert.AreEqual(0, area.IndexOf(wall));
            Assert.AreEqual(TypeOfAreaObj.Wall, wall.Type);
            
        }
    }
}