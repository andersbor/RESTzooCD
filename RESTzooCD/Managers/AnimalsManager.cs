using System.Collections.Generic;
using System.Linq;
using RESTzooCD.Models;

namespace RESTzooCD.Managers
{
    public class AnimalsManager
    {
        private static int _nextId = 1;
        private static readonly List<Animal> Data = new List<Animal>
        {
            new Animal {Id = _nextId++, Name = "Lion"},
            new Animal {Id=_nextId, Name = "Tiger"}
        };

        public List<Animal> GetAll()
        {
            return new List<Animal>(Data);
        }

        public Animal GetById(int id)
        {
            return Data.FirstOrDefault(animal => animal.Id == id);
        }

        public Animal Add(Animal animal)
        {
            animal.Id = _nextId++;
            Data.Add(animal);
            return animal;
        }
    }
}
