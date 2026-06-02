using System;
using System.Collections.Generic;
using System.Text;

namespace Phase01_CSharpFoundation
{
    public class StructuralColumn
    {
        private string _mark;
        private double _height;
        private string _section;
        private string _concreteGrade;

        public string Mark
        {
            get {  return _mark; }
        }

        public double Height
        {
            get { return _height; }
        }

        public string Section
        {
            get { return _section; }
        }

        public string ConcreteGrade
        {
            get { return _concreteGrade; }
        }

        public StructuralColumn(string mark, double height, string section, string concreteGrade)
        {
            if (string.IsNullOrWhiteSpace(mark))
                throw new ArgumentNullException("Mark cannot be empty");

            if (height <= 0)
                throw new ArgumentOutOfRangeException("Height must be greater than zero");

            _mark = mark;
            _height = height; 
            _section = section;
            _concreteGrade = concreteGrade;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Mark          : {Mark}");
            Console.WriteLine($"Height        : {Height}mm");
            Console.WriteLine($"Section       : {Section}");
            Console.WriteLine($"Concrete Grade: {ConcreteGrade}");
        }
    }
}
