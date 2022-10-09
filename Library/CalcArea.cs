using System.Collections.Generic;
using System;

namespace CalcAreaFiguresLib
{
    public class CalcArea
    {
        Exception exceptionMoreVariables = new Exception(message: "Invalid number of items in the transferred collection");

        private string name;
        public string Name {
            get { return name; }
            private set
            {
                name = value;
                string result = name.Replace(" ", "").ToLower();
                result = string.Concat(result[0].ToString().ToUpper(), result.AsSpan(1));
                name = result;
            }
        }
        private List<double> list = new List<double>();

        public CalcArea(string name, List<double> list) {
            Name = name;
            if (list.Count > 3) Console.WriteLine(exceptionMoreVariables.Message);
            else this.list = list;
        }

        public float CalculateArea() {
            switch ((name, list.Count)) {
                case ("Circle", 1):
                    return (float)Math.Round((Math.PI * Math.Pow(list[0], 2)), 2, MidpointRounding.AwayFromZero);
                case ("Triangle", 2):
                    if (isRightTriangle()) return (float)(0.5 * list[0] * list[1]); else return 0;
                case ("Triangle", 3):
                    double p = (list[0] + list[1] + list[2]) / 2;
                    return (float)Math.Round((Math.Sqrt(p * (p - list[0]) * (p - list[1]) * (p - list[2]))), 3, MidpointRounding.AwayFromZero);
                case ("Square", 1):
                    return (float)Math.Round((list[0] * list[0]), 3, MidpointRounding.AwayFromZero);
                case ("Rhomb", 2):
                    return (float)Math.Round((Math.Pow(list[0], 2) * Math.Sin(list[1])), 3, MidpointRounding.AwayFromZero);
                case ("Rectangle", 2):
                    return (float)Math.Round((list[0] * list[1]), 3, MidpointRounding.AwayFromZero);
                case ("Oval", 2):
                    return (float)Math.Round((Math.PI * list[0] * list[1]), 3, MidpointRounding.AwayFromZero);
                case ("Trapezoid", 3):
                    return (float)Math.Round((0.5 * list[0] * (list[1] + list[2])), 3, MidpointRounding.AwayFromZero);
                case ("Parallelogram", 2):
                    return (float)Math.Round((list[0] * list[1]), 3, MidpointRounding.AwayFromZero);
                case ("Hexagon", 1):
                    return (float)Math.Round(((3 * Math.Sqrt(3) * Math.Pow(list[0], 2)) / 2), 3, MidpointRounding.AwayFromZero);
                default:
                    throw new Exception(message: $"There is no such flat figure - {name}\n\tOR\nYou have passed the wrong number of variables needed to calculate the area of the figure");
            }
        }

        public bool isRightTriangle() {
            if (name == "Triangle" && list.Count == 3)
            {
                if (Math.Pow(list[2], 2) == Math.Pow(list[0], 2) + Math.Pow(list[1], 2)) return true;
                else return false;
            }
            else return false;
        }
    }
}