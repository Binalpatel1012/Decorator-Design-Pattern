using DecoratorDesignPattern.Interfaces;

namespace DecoratorDesignPattern.Components
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "This is the text of ConcreteComponent";
        }
    }
}
