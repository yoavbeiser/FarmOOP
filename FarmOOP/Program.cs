using System;
using System.Collections.Generic;

namespace FarmOOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<IAnimal> animals = new IAnimal[] { new Cow(), new Pig(), new Dog(), new Horse(), new Cow() };
            Farm farm = new Farm(animals);
            Console.WriteLine(farm.ToString());
        }
    }
}