using DecoratorDesignPattern.Decorators;
using DecoratorDesignPattern.Interfaces;

namespace DecoratorDesignPattern
{
    public class PlainDecorator : Decorator<string>
    {
        public PlainDecorator(IComponent<string> component) : base(component)
        {
        }

        
        public override string GetText()
        {
            string String = "Custom String: "; 
            return String + base.GetText(); 
        }
    }
}
