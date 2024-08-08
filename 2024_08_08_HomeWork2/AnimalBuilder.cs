using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_08_08_HomeWork2
{
    public class AnimalBuilder
    {
        public string name;
        public string type;
        public int age;
        public double weight;

        public AnimalBuilder()
        {
            this.name = " ";
            this.type = " ";
            this.age = 0;
            this.weight = 0;
        }

        public Animal Build()
        {
            Animal animal = new Animal();

            animal.name = this.name;
            animal.type = this.type;
            animal.age = this.age;
            animal.weight = this.weight;
            
            return animal;
        }

        public AnimalBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public AnimalBuilder SetType(string type)
        {
            this.type = type;
            return this;
        }

        public AnimalBuilder SetAge (int age)
        {
            this.age = age;
            return this;
        }

        public AnimalBuilder SetWeight (double weight)
        {
            this.weight = weight;
            return this;
        }
    }
}
