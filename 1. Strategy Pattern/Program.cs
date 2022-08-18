RubberDuck rd = new RubberDuck(new FlyNoWay());
rd.Fly();

abstract class Duck
{
    IFly flyBehavior;

    public void Quack() { Console.WriteLine("Quack"); }

    public void Swim() { Console.WriteLine("Swim"); }

    public void Fly() { flyBehavior.Fly(); }

    public abstract void Display();

    public Duck(IFly flyBehavior)
    {
        this.flyBehavior = flyBehavior;
    }
}

class MallardDuck : Duck
{
    public MallardDuck(IFly flyBehavior) : base(flyBehavior)
    {
    }

    public override void Display()
    {
        throw new NotImplementedException();
    }
}

class RedheadDuck : Duck
{
    public RedheadDuck(IFly flyBehavior) : base(flyBehavior)
    {
    }

    public override void Display()
    {
        throw new NotImplementedException();
    }
}

class RubberDuck : Duck
{
    public RubberDuck(IFly flyBehavior) : base(flyBehavior)
    {
    }

    public override void Display()
    {
        throw new NotImplementedException();
    }
}

interface IFly
{
    void Fly()
    {
        Console.WriteLine("Default fly");
    }
}

class FlyNoWay : IFly
{
}