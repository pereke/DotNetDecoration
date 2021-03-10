using DotNetDecoration.Concrete;
using DotNetDecoration.Interface;
using System;

namespace DotNetDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Animal();

            IAnimal animalDecorator = new AnimalDecoration(animal);

            Console.WriteLine(animalDecorator.Eat());

            IAnimal cachorroDecorator = new Dog(animal);

            Console.WriteLine(cachorroDecorator.Eat());

            IAnimal birdDecorator = new Bird(animal);

            Console.WriteLine(birdDecorator.Eat());

            IAnimal strangeDogBirdDecorator = new Bird(cachorroDecorator);

            Console.WriteLine(strangeDogBirdDecorator.Eat());

            Console.ReadKey();
        }
    }
}
