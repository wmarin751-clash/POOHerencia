
namespace Backend2POO;

internal class Trapeze : Triangle
{

    //fields
    private double _d;



    //constructors  
    public Trapeze(string name, double a) : base(name, a)
    {
        _d = a;
    }


    //properties    
    public double D
    {     get => _d;
          set => _d = ValidateD(value);
    }   

    //methods   
   public override double GetArea() => ((A + B) * D) / 2;
    public override double GetPerimeter() => A + B + C + D;
    private double ValidateD(double d)
    {
        if (d < 0)
        {
            throw new ArgumentException("The diagonal D of the trapeze is incorrect.");
        }
        return d;
    }

}
