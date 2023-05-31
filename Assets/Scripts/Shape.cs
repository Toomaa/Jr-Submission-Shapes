public abstract class Shape
{
    public string Name { get; protected set; }
    public float Circumference { get; protected set; }
    public float SurfaceArea { get; protected set; }

    protected void Calculate()
    {
        CalculateCircumference();
        CalculateSurfaceArea();
    }

    protected abstract void CalculateCircumference();
    protected abstract void CalculateSurfaceArea();
}
