using DotNetDecoration.Interface;

namespace DotNetDecoration.Concrete
{
    public sealed class Animal : IAnimal
    {
        public string Eat()
        {
            return "Eat";
        }
    }
}
