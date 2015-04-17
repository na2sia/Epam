using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test3
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public bool CheckSide()
        {
            if ((A < B + C) & (A > B - C) & (B < A + C) & (B > A - C) & (C < A + B) & (C > A - B))
            {
                return true;
            }
            else return false;
        }
        enum TypeTriangle { Obtuse, Acute, Rectang, NotTriangle }
        string s = Enum.GetName(typeof(TypeTriangle), 1);
        public string GetCheckTriangle()
        {
            if (CheckSide())
            {
                if ((A * A + B * B) < C * C)
                {
                    return Enum.GetName(typeof(TypeTriangle), 0);
                }
                else
                {
                    if ((A * A + B * B) > C * C)
                    {
                        return Enum.GetName(typeof(TypeTriangle), 1);
                    }
                    else { return Enum.GetName(typeof(TypeTriangle), 2); }
                }
            }
            else { return Enum.GetName(typeof(TypeTriangle), 3); }
            
        }
    }
}
