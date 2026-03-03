
namespace Backend2POO;

public class Square : GeometricFigure
{
    //Fields

    private double _a;

    
    // Properties 

    public double A
    {     get => _a;
          set => _a = ValidateA (value);
    }

    // Constructor
    public Square(string name, double a) : base (name )
    {
        A = a;
        Name = name;    
    }

    //Methods

    public override double GetArea() => Math.Pow(A, 2);

    public override double GetPerimeter() => 4 * A;


    private double ValidateA(double a)
    {
        if (a < 0)
        {
            throw new ArgumentException("The area of the square is incorrect.");
        }
        return a;
    }


}
