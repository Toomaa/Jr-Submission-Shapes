public class Rectangle : Shape
{
    private float _sideA;
    private float _sideB;

    public Rectangle()
    {
        Name = "Rectangle";
    }
    
    public void Calculate(float sideA, float sideB)
    {
        _sideA = sideA;
        _sideB = sideB;

        Calculate();
    }

    protected override void CalculateCircumference()
    {
        Circumference = 2 * _sideA + 2 * _sideB;
    }

    protected override void CalculateSurfaceArea()
    {
        SurfaceArea = _sideA * _sideB;
    }
}
