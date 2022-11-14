namespace ClassLibraryAreaCounter
{
    public class Triangle
    {
        double a, b, c, p;


        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.p = (a + b + c) / 2; ;
        }

        public void Print() => Console.WriteLine($"Площадь тругольника: {Math.Sqrt(p*(p-a)*(p-b)*(p-c))}");
    }
}
