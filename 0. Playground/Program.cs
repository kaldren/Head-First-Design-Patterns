IShape shape = new BackgroundColorShapeDecorator(new Circle(), "red");
shape.Draw();
shape = new Square();
shape.Draw();

interface IShape
{
    void Draw();
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Square");
    }
}

abstract class ShapeDecorator : IShape
{
    IShape _decoratedShape;

    public ShapeDecorator(IShape decoratedShape)
    {
        _decoratedShape = decoratedShape;
    }

    public virtual void Draw()
    {
        _decoratedShape.Draw();
    }
}

class BackgroundColorShapeDecorator : IShape
{
    private string _color;
    IShape _decoratedShape;

    public BackgroundColorShapeDecorator(IShape decoratedShape, string color)
    {
        _color = color;
        _decoratedShape = decoratedShape;
    }

    public void Draw()
    {
        _decoratedShape.Draw();
        Console.WriteLine($"Filling the shape with {_color} color.");
    }
}