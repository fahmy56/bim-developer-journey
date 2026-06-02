namespace Session02_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StructuralColumn structuralColumn = new StructuralColumn();
            structuralColumn.Mark = "C1";
            structuralColumn.Height = 3000;
            structuralColumn.Section = "400x400";
            structuralColumn.ConcreteGrade = "C30";
            structuralColumn.PrintInfo();

            StructuralColumn column2 = new StructuralColumn();
            column2.Mark = "C2";
            column2.Height = 3500;
            column2.Section = "500x500";
            column2.ConcreteGrade = "C35";
            column2.PrintInfo();

            StructuralColumn column3 = new StructuralColumn();
            column3.Mark = "C3";
            column3.Height = 4000;
            column3.Section = "600x600";
            column3.ConcreteGrade = "C40";
            column3.PrintInfo();
        }
    }
}
