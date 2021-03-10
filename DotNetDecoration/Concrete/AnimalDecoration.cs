using DotNetDecoration.Interface;

namespace DotNetDecoration.Concrete
{
    public class AnimalDecoration : IAnimal
    {
        private readonly IAnimal _animal;

        public AnimalDecoration(IAnimal animal)
        {
            _animal = animal;
        }

        public virtual string Eat()
        {
            return _animal.Eat();
        }
    }
}
