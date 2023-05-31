public class Square : Rectangle
{
    public Square()
    {
        Name = "Square";
    }

    public void Calculate(float side)
    {
        Calculate(side, side);
    }
}
