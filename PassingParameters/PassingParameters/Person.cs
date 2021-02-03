using System;

namespace PassingParameters
{
    public class Person 
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FullName
        {
            get 
            {
                return $"{FirstName ?? string.Empty} {LastName ?? string.Empty}";
            }
        }

        public void Print()
        {
            Console.WriteLine($"Hello, my name is {FullName}");
        }
    }
}
