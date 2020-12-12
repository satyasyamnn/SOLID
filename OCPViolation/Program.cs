namespace OCPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleAreaCalculator calc1 = new SimpleAreaCalculator();
            calc1.Area(new Rectangle[]
            {
                new Rectangle {Height = 1, Width = 1},
                new Rectangle {Height = 2, Width = 2}
            });

            SimpleAreaCalculator2 calc2 = new SimpleAreaCalculator2();
            calc2.Area(new object[]
            {
                new Rectangle {Height = 1, Width = 1},
                new Circle {Radius = 1}
            });
        }
    }
}
