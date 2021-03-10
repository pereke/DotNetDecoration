using DotNetDecoration.Interface;

namespace DotNetDecoration.Concrete
{
    public class Dog : AnimalDecoration
    {
        public Dog(IAnimal animal) : base(animal)
        {
        }

        public override string Eat()
        {
            return base.Eat() + " Ração";
        }
    }
}
