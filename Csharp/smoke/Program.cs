using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        List<ILeetCodeProblem> problems = LoadProblems();

        if (problems.Count == 0)
        {
            Console.WriteLine("No problems found.");
            return;
        }

        Console.WriteLine("LeetCode Practice");
        Console.WriteLine("-----------------");

        for (int i = 0; i < problems.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + problems[i].Name);
        }

        Console.Write("Choose a problem: ");
        string input = Console.ReadLine();

        int choice;
        bool isValidNumber = int.TryParse(input, out choice);

        if (!isValidNumber || choice < 1 || choice > problems.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Running: " + problems[choice - 1].Name);
        Console.WriteLine("--------------------------------");

        problems[choice - 1].Run();
    }

    private static List<ILeetCodeProblem> LoadProblems()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();

        List<ILeetCodeProblem> problems = assembly
            .GetTypes()
            .Where(t =>
                typeof(ILeetCodeProblem).IsAssignableFrom(t) &&
                !t.IsInterface &&
                !t.IsAbstract)
            .Select(t => (ILeetCodeProblem)Activator.CreateInstance(t))
            .OrderBy(p => p.Name)
            .ToList();

        return problems;
    }
}