using UnityEngine;

public class Circle : Shape
{
    private float _radius;

    public Circle()
    {
        Name = "Circle";
    }

    public void Calculate(float radius)
    {
        _radius = radius;
        Calculate();
    }

    protected override void CalculateCircumference()
    {
        Circumference = 2 * Mathf.PI * _radius;
    }

    protected override void CalculateSurfaceArea()
    {
        SurfaceArea = Mathf.PI * Mathf.Pow(_radius, 2);
    }
}
