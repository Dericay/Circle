namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(3.141f, 5); //this will calculate the circle of 5
            circle1.getArea();

            Circle circle2 = new Circle(3.141f, 6); //this will calculate the circle of 6
            circle2.getArea();
        }
    }
}