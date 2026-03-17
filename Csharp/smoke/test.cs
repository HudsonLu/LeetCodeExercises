using System;
using System.ComponentModel;

public class Test : ILeetCodeProblem
{
    public string Name
    {
        get { return "Test"; }
    }

    public void Run()
    {
        ///////////////////// ///////////////////// ///////////////////// ///////////////////// /////////////////////
        // I/O, char, string, formatting, camelCase (Local variables / parameters → camelCase), PascalCase
        string input = Console.ReadLine();
        Console.WriteLine("You entered: " + input);
        double n = double.Parse(input);
        Console.WriteLine('a'+5); // 'a' = 97
        Console.WriteLine("Input: " + n);
        Console.WriteLine("Output: " + $"{n:F2}");

        if (int.TryParse("123", out int value))
        {
            Console.WriteLine(value);
        }

        int x = 10;
        string t = x.ToString();

        double d = 3.14;
        int e = (int)d;   // 3

        ///////////////////// ///////////////////// ///////////////////// ///////////////////// /////////////////////
        // Strings 
        string s = "  Hello World  ";

        Console.WriteLine(s.Length);                // includes spaces
        Console.WriteLine(s.ToLower());
        Console.WriteLine(s.ToUpper());
        Console.WriteLine(s.Trim());
        Console.WriteLine(s.Contains("World"));
        Console.WriteLine(s.StartsWith("  He"));
        Console.WriteLine(s.EndsWith("  "));
        Console.WriteLine(s.Substring(2, 5));
        Console.WriteLine(s.Replace("World", "C#"));


        string a = "hello";
        string b = "HELLO";

        Console.WriteLine(a == b);                           // false
        Console.WriteLine(a.Equals(b));                      // false
        Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase)); // true


        ///////////////////// ///////////////////// ///////////////////// ///////////////////// /////////////////////
        ///
        /*
         * 
         *
         *
        public class Person
        {
            public string Name;
            public int Age;

            public void Introduce()
            {
                Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
            }
        }


        Person p = new Person();
                p.Name = "Hudson";
                p.Age = 22;
                p.Introduce();



        using System.Collections.Generic;
        Dictionary<string, int> scores = new Dictionary<string, int>();
        scores["Alice"] = 90;
        scores["Bob"] = 85;

        Console.WriteLine(scores["Alice"]);

         */






        ///////////////////// ///////////////////// ///////////////////// ///////////////////// /////////////////////
        // Arrays
        int[] nums = { 10, 20, 30 };
        string[] names = { "Alice", "Bob", "Charlie" };


        Console.WriteLine(nums[0]);   // 10
        nums[1] = 99; // 20 -> 99
        Console.WriteLine(nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }

        Array.Sort(nums);
        Array.Reverse(nums);
        int index = Array.IndexOf(nums, 30);
        bool exists = Array.Exists(nums, x => x == 20);


        List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbers.Count);

        numbers.Remove(20);
        numbers.RemoveAt(0);
        numbers.Contains(30);
        numbers.Sort();
        numbers.Reverse();
        numbers.Insert(0, 100);
        numbers.Clear();

        foreach (int j in numbers)
        {
            Console.WriteLine(j);
        }



    }
}