using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmOOP
{
    public class Farm
    {
        #region Prop
        private readonly IEnumerable<IAnimal> _animals;
        #endregion

        #region Ctor
        public Farm(IEnumerable<IAnimal> animals)
        {
            _animals = animals;
        }
        #endregion

        #region Get
        public IEnumerable<IAnimal> GetAnimals()
        {
            return _animals;
        }
        #endregion

        #region Methods
        public void PrintStatus()
        {
            Console.WriteLine("Animal \t Count");
            Console.WriteLine("------ \t -----");
            IList<Tuple<string, int>> array = new List<Tuple<string, int>>();
            array.Add(new Tuple<string, int>("chick", _animals.Count(_ => _.GetName() == "chick")));
            array.Add(new Tuple<string, int>("cow", _animals.Count(_ => _.GetName() == "cow")));
            array.Add(new Tuple<string, int>("dog", _animals.Count(_ => _.GetName() == "Dog")));
            array.Add(new Tuple<string, int>("pig", _animals.Count(_ => _.GetName() == "Pig")));
            array.Add(new Tuple<string, int>("horse", _animals.Count(_ => _.GetName() == "horse")));
            foreach (Tuple<string, int> animalAndHerCount in array)
            {
                if (animalAndHerCount.Item2 > 0)
                {
                    Console.WriteLine($"{animalAndHerCount.Item1}   {animalAndHerCount.Item2}");
                }
            }
        }
        private static void GetSongForAnimal(IAnimal animal)
        {
            string animalsound = animal.GetSound();
            Console.WriteLine($"Old MacDonald had a farm, E-I-E-I-O" +
                              $"And on his farm he had some {animal.GetName()}s, E-I-E-I-O " +
                              $"With a {animalsound}-{animalsound} here and a {animalsound}-{animalsound} there" +
                              $"Here a {animalsound} there a {animalsound}" +
                              $"Everywhere a {animalsound}-{animalsound} " +
                              "Old MacDonald had a farm, E-I-E-I-O");
        }
        public void PrintSong()
        {
            IEnumerable<IAnimal> animals = _animals.Distinct();
            foreach (IAnimal animal in animals)
            {
                GetSongForAnimal(animal);
            }
        }
        #endregion

        #region OverrideMethods
        public override string ToString()
        {
            string allAnimals = "";
            foreach (IAnimal animal in _animals)
            {
                allAnimals += animal.ToString();
                allAnimals += "\t";
            }
            return allAnimals;
        }

        public override bool Equals(object obj)
        {
            Farm newObj = (Farm)obj;
            return newObj != null
                   && newObj.GetAnimals().SequenceEqual(this.GetAnimals());
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_animals);
        }
        #endregion
    }
}