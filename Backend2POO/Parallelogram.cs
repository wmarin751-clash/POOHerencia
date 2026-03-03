

namespace Backend2POO;

public class Parallelogram : Rectangle    
{
    //fields
    private double _h;


    //constructors
   

    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;  
    }

    //properties    
    public double H
    {     get => _h;
          set => _h = ValidateH(value);
    }   


    //methods
    public override double GetArea() => B * H;

    public override double GetPerimeter() => 2 * (A + B);

    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new ArgumentException("The height of the parallelogram is incorrect.");
        }
        return h;
    }
   

}
