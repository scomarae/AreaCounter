namespace ClassLibraryAreaCounter
{
    public class Circle
    {
        double rad;
        public Circle(double rad)
        {
            this.rad = rad;
        }
        public void Print() => Console.WriteLine($"Площадь круга: {Math.Pow(rad, 2)*Math.PI}");
    }
}