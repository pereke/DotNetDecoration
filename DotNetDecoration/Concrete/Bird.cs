using DotNetDecoration.Interface;

namespace DotNetDecoration.Concrete
{
    public class Bird : AnimalDecoration
    {
        public Bird(IAnimal animal) : base(animal)
        {
        }

        public override string Eat()
        {
            return base.Eat() + " Alpiste";
        }
    }
}
