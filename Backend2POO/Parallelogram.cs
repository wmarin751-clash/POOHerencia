

namespace Backend2POO;

internal class Parallelogram : Rectangle    
{
    //fields
    private double _h;


    //constructors
    public Parallelogram(string name, double a) : base(name, a)
    {
      _h = a;
    }

    public Parallelogram(string name, double a, double b, double h) : this(name, a)
    {
    }

    //properties    
    public double H
    {     get => _h;
          set => _h = ValidateH(value);
    }   


    //methods
    public override double GetArea() => A * H;

    public override double GetPerimeter() => 2 * (A + B);

    private double ValidateH(double h)
    {
        if (h < 0)
        {
            throw new ArgumentException("The height of the parallelogram is incorrect.");
        }
        return h;
    }
   

}
