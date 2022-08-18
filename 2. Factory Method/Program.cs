PizzaStore pz = new NYStylePizzaStore();
pz.OrderPizza("veggie");

public abstract class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza;

        pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    protected abstract Pizza CreatePizza(string type);
}

#region Product
public abstract class Pizza
{
    internal void Bake()
    {
        Console.WriteLine("Baking...");
    }

    internal void Box()
    {
        Console.WriteLine("Boxing...");
    }

    internal virtual void Cut()
    {
        Console.WriteLine("Cutting...");
    }

    internal void Prepare()
    {
        Console.WriteLine("Preparing...");
    }
}
#endregion


#region New York
class NYStylePizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        if (type.Equals("cheese"))
        {
            return new NYStyleCheesePizza();
        }
        else if (type.Equals("veggie"))
        {
            return new NYStyleVeggiePizza();
        }
        else
        {
            return null;
        }
    }
}

internal class NYStyleVeggiePizza : Pizza
{
    internal override void Cut()
    {
        Console.WriteLine("Cut in squares");
    }
}

internal class NYStyleCheesePizza : Pizza
{
}
#endregion New York


#region Chicago
class ChicagoStylePizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        if (type.Equals("cheese"))
        {
            return new ChicagoStyleCheesePizza();
        }
        else if (type.Equals("veggie"))
        {
            return new ChicagoStyleVeggiePizza();
        }
        else
        {
            return null;
        }
    }
}

internal class ChicagoStyleVeggiePizza : Pizza
{
}

internal class ChicagoStyleCheesePizza : Pizza
{
}
#endregion Chicago