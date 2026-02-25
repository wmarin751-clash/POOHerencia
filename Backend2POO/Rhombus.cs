

namespace Backend2POO;

public class Rhombus : Square
{
    // fields
    private double _d1;
    private double _d2;

    //Properties    

    public double D1
    {     get => _d1;
          set => _d1 = ValidateD1(value);
    }

    public double D2
    {     get => _d2;
          set => _d2 = ValidateD2(value);
    }


    // constructors
    public Rhombus(string name, double a, double d1, double d2) : base (name, a)
    {
        D1 = d1;
        D2 = d2;
    }

    // methods

    public override double GetArea() => (D1 * D2) / 2;

    public override double GetPerimeter() => base.GetPerimeter();

    private double ValidateD1(double d1)
    {
        if (d1 < 0)
        {
            throw new ArgumentException("The diagonal D1 of the rhombus is incorrect.");
        }
        return d1;
    }
    private double ValidateD2(double d2)
    {
        if (d2 < 0)
        {
            throw new ArgumentException("The diagonal D2 of the rhombus is incorrect.");
        }
        return d2;
    }
    





}
