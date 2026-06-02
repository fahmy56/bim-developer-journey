using System;
using System.Collections.Generic;
using System.Text;

namespace Session02_Classes
{
    public class StructuralColumn
    {
        public string Mark;
        public double Height;
        public string Section;
        public string ConcreteGrade;

        public void PrintInfo()
        {
            Console.WriteLine($"Mark          : {Mark}\n" +
                              $"Height        : {Height}\n" +
                              $"Section       : {Section}\n" +
                              $"Concrete Grade: {ConcreteGrade}");
        }
    }
}
