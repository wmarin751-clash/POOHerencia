

using Herency01;

namespace Backend2POO;

internal class Rectangle : Square
{

    // fields
    private double _b;

    //Constructors 
    public Rectangle(string name, double a) : base(name, a)
    {
        B = B;
    }

    //Properties
    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

     // Methods
    public override double GetArea() => A * B;  

    public override double GetPerimeter() => 2 * (A + B);

    private double ValidateB(double b)
    {
        if (b < 0)
        {
            throw new ArgumentException("The area of the rectangle is incorrect.");
        }
        return b;
    }


}
