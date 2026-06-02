namespace Phase01_CSharpFoundation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StructuralColumn c1 = new StructuralColumn("C1", 3000, "300x300", "C30");
            StructuralColumn c2 = new StructuralColumn("C2", 3500, "400x300", "C35");
            StructuralColumn c3 = new StructuralColumn("C3", 2800, "500x300", "C30");

            c1.PrintInfo();
            c2.PrintInfo();
            c3.PrintInfo();

            try
            {
                StructuralColumn c4 = new StructuralColumn("C4", -500, "300x300", "C30");
                c4.PrintInfo();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Cannot create column: {ex.ParamName}");
            }
        }
    }
}
