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
            Assert.AreEqual(3, allAnimals.Count);

            Animal non = _manager.Delete(-1);
            Assert.IsNull(non);

            Animal deletedAnimal = _manager.Delete(a.Id);
            Assert.AreEqual("RhinoKKKKKK", deletedAnimal.Name);
        }

        [TestMethod]
        public void GetByIdTest()
        {

        }

        [TestMethod]
        public void AddTest()
        {

        }
    }
}