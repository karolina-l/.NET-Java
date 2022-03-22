using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ConsoleApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PassWhenItemsCountIsZeroForOneSeed()
        {
            Problem p = new Problem(10, 3, 0);
            List<Item> items = new List<Item>();
            p.Elements();
            items = p.Solution();
            Assert.AreEqual(0, items.Count);
        }

        [TestMethod]
        public void PassWhenItemsCountLessThanCapacityForMultipleSeeds()
        {
            for (int seed = 0; seed < 100; seed++)
            {
                Problem p = new Problem(10, seed, 17);
                List<Item> items = new List<Item>();
                p.Elements();
                items = p.Solution();
                Assert.IsTrue(items.Count <= 17);
            }
        }

        [TestMethod]
        public void PassWhenGeneratesGoodAmountOfElements()
        {
            Problem p = new Problem(10, 3, 0);
            p.Elements();
            Assert.AreEqual(10, p.listOfItems.Count);
        }

        [TestMethod]
        public void PassWhenProblemNonParameterConstructorWorks()
        {
            Problem p = new Problem();
            Assert.AreEqual(0, p.seed);
            Assert.AreEqual(0, p.listOfItems.Count);
            Assert.AreEqual(0, p.numberOfElements);
            Assert.AreEqual(0, p.capacity);
        }

        [TestMethod]
        public void PassWhenProblemParameterConstructorWorks()
        {
            Problem p = new Problem(10, 2, 3);
            Assert.AreEqual(2, p.seed);
            Assert.AreEqual(0, p.listOfItems.Count);
            Assert.AreEqual(10, p.numberOfElements);
            Assert.AreEqual(3, p.capacity);
        }

        [TestMethod]
        public void PassWhenItemInOrOutIsTrue()
        {
            Problem p = new Problem(10, 3, 10);
            List<Item> items = new List<Item>();
            p.Elements();
            items = p.Solution();
            foreach(Item i in items)
            {
                Assert.IsTrue(i.inOrOut);
            }
        }

        [TestMethod]
        public void PassWhenItemNonParameterConstructorWorks()
        {
            Item i = new Item();
            Assert.AreEqual(0, i.valueToWeight);
            Assert.AreEqual(0, i.weight);
            Assert.AreEqual(0, i.value);
            Assert.AreEqual(0, i.id);
            Assert.IsFalse(i.inOrOut);
        }

        [TestMethod]
        public void PassWhenItemParameterConstructorWorks()
        {
            Item i = new Item(2, 6, 1);
            Assert.AreEqual(3, i.valueToWeight);
            Assert.AreEqual(2, i.weight);
            Assert.AreEqual(6, i.value);
            Assert.AreEqual(1, i.id);
            Assert.IsFalse(i.inOrOut);
        }

        [TestMethod]
        public void PassWhenItemToStringWorksWhenInOrOutIsTrue()
        {
            Item i = new Item(2, 6, 1);
            i.inOrOut = true;
            Assert.AreEqual("Item no " + i.id + ", weight: " + i.weight + ", value: " + i.value + " " + "is in the bag " + "\n", i.ToString());
        }
        [TestMethod]
        public void PassWhenItemToStringWorksWhenInOrOutIsFalse()
        {
            Item i = new Item(2, 6, 1);
            Assert.AreEqual("Item no " + i.id + ", weight: " + i.weight + ", value: " + i.value + " " + "is not in the bag " + "\n", i.ToString());
        }
    }
}
