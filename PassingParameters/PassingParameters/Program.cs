using System;

namespace PassingParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // With Ref
            // int i = 100;
            // int y = IncrementWithRef(ref i);

            // With Out
            int i = 100;
            int y = IncrementWithOut(i, out i);
            Console.WriteLine(i);
            Console.WriteLine(y);

            // With Ref
            // Person pers = new Person
            // {
            //     FirstName = "John",
            //     LastName = "Doe"
            // };
            // pers.Print();
            // ChangePersonNameWithRef(ref pers);
            // pers.Print();

            // With out
            Person pers;
            ChangePersonNameWithOut(out pers);
            pers.Print();

            Point p = new Point();
            p.X = 100;
            p.Y = 100;
            p.Print();
            ChangePointCoords(ref p);
            p.Print();
        }

        private static int IncrementWithRef(ref int i)
        {
            i = i + 1;
            return i;
        }

        private static int IncrementWithOut(int i, out int incremented)
        {
            incremented = i + 1;
            return incremented;
        }

        private static void ChangePersonNameWithRef(ref Person p)
        {
            p.FirstName = "Other";
            p.LastName = "Name";
        }

        private static void ChangePersonNameWithOut(out Person modifiedPerson)
        {
            modifiedPerson = new Person
            {
                FirstName = "Other",
                LastName = "Name"
            };
        }

        private static void ChangePersonName2(ref Person p)
        {
            p = new Person
            {
                FirstName = "Other",
                LastName = "Name"
            };
        }

        private static void ChangePointCoords(ref Point p)
        {
            p.X = 500;
            p.Y = 600;
        }
    }
}
