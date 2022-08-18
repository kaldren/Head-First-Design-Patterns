abstract class Pizza
{
    protected Dough dough;
    protected Sauce sauce;
    protected Veggies[] veggies;
    protected Cheese cheese;
    protected Pepperoni pepperoni;
    protected Clams clam;

    public abstract void Prepare();
}

// Abstract factory
interface PizzaIngredientFactory
{
    public Dough CreateDough();

    public Sauce CreateSauce();

    public Cheese CreateCheese();

    public Veggies[] CreateVeggies();

    public Pepperoni CreatePepperoni();

    public Clams CreateClam();
}

class NYPizzaIngredientFactory : PizzaIngredientFactory
{
    public Cheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public Clams CreateClam()
    {
        return new FreshClams();
    }

    public Dough CreateDough()
    {
        return new ThinCrustDough();
    }

    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public Sauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public Veggies[] CreateVeggies()
    {
        Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };

        return veggies;
    }
}

class ChicagoIngredientFactory : PizzaIngredientFactory
{
    public Cheese CreateCheese()
    {
        return new MozarellaCheese();
    }

    public Clams CreateClam()
    {
        return new FrozenClams();
    }

    public Dough CreateDough()
    {
        return new ThickCrustDough();
    }

    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public Sauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public Veggies[] CreateVeggies()
    {
        Veggies[] veggies = { new BlackOlives(), new Spinach(), new EggPlant() };

        return veggies;
    }
}

class CheesePizza : Pizza
{
    PizzaIngredientFactory ingredientFactory;

    public CheesePizza(PizzaIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {
        dough = ingredientFactory.CreateDough();
        sauce = ingredientFactory.CreateSauce();
        cheese = ingredientFactory.CreateCheese();
    }
}