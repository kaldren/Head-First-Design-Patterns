namespace _4._Decorator_Pattern
{
    class Mocha : BeverageDecorator
    {
        Beverage _beverage;

        public Mocha(Beverage beverage) : base(beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return 0.99M + _beverage.Cost();
        }
    }
}
