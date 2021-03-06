using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RESTzooCD.Models;

namespace RESTzooCD.Managers.Tests
{
    [TestClass]
    public class AnimalsManagerTests
    {
        private readonly AnimalsManager _manager = new AnimalsManager();

        [TestMethod]
        public void GetAllTest()
        {
            List<Animal> allAnimals = _manager.GetAll();
            Assert.AreEqual(2, allAnimals.Count);

            Animal animal = new Animal { Name = "Rhino" };
            Animal a = _manager.Add(animal);
            Assert.AreEqual(a.Name, animal.Name);

            allAnimals = _manager.GetAll();
            Assert.AreEqual(2, allAnimals.Count);
        }

        [TestMethod()]
        public void GetByIdTest()
        {

        }

        [TestMethod()]
        public void AddTest()
        {

        }
    }
}