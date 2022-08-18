namespace _4._Decorator_Pattern
{
    // Beverage Wrapper
    abstract class BeverageDecorator : Beverage
    {
        Beverage _beverage;

        public BeverageDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }
    }
}
