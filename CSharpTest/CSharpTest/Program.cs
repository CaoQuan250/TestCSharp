namespace CSharpTest
{
    class Cylinder
    {
        public static void Process()
        {
            Console.Write("Input height: ");
            Double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input radius: ");
            Double radius = Convert.ToDouble(Console.ReadLine());

            Double Base = radius * radius * Math.PI;

            Double Lateral = 2 * Math.PI * radius * height;

            Double Total = 2 * Math.PI * radius * (height + radius);

            Double Volume = Math.PI * radius * radius * height;

            Console.WriteLine("Base: {0:F2} Lateral: {1:F2} Total: {2:F2} Volume: {3:F2}", Base, Lateral, Total, Volume);
        }

        public static void Main(string[] args)
        {
            Process();
        }
        
    }
    
}