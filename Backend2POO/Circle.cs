
namespace Backend2POO;

public class Circle: GeometricFigure
{
    //fields
    private double _r;


    //Contructor
    public Circle(string name, double r) : base(name)   
    {
        R = r;
    }
    // Properties 
    public double R
    {     get => _r;
          set => _r = ValidateR(value);

    }


    // Methods
    public override double GetArea() => Math.PI * Math.Pow(R, 2);


    public override double GetPerimeter() => 2 * Math.PI * R;


    private double ValidateR(double r)
    {
        if (r < 0)
        {
            throw new ArgumentException("Radius cannot be negative.");
        }
        return r;  
    }
      
}
