struct Plot
{
    //property can only be assigned in instance initializer
    public double Length { get; init; }   

    public double Breadth { get; init; }

    public double Area()
    {
        return Length * Breadth;
    }

    public override string ToString()
    {
        //return string.Format("{0} x {1}", Length, Breadth);
        return $"{Length} x {Breadth}"; //string interpolation
    }
}