using _4._Decorator_Pattern;

Beverage hb = new Mocha(new Mocha(new HouseBlend("The best House Blend")));
Console.WriteLine($"{hb.Description} {hb.Cost()}");

abstract class Beverage
{
    public string? Description { get; set; } = "Base";

    public abstract decimal Cost();
}

class HouseBlend : Beverage
{
    public HouseBlend(string description)
    {
        Description = description;
    }

    public override decimal Cost()
    {
        return 2.99M;
    }
}

class DarkRoast : Beverage
{
    public DarkRoast(string description)
    {
        Description = description;
    }

    public override decimal Cost()
    {
        return 3.99M;
    }
}