# C# Quick Recap README

A practical refresher for common C# syntax and patterns, especially useful before coding interviews, LeetCode, class work, or small console apps.

---

# 1. Basic Program Structure

```csharp
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, world!");
    }
}
```

## Key points

* `using System;` lets you use `Console`, `Math`, etc.
* `Main` is the entry point
* `string[] args` stores command-line arguments
* `public static void Main(...)` is the standard main method

---

# 2. Variables and Basic Types

```csharp
int age = 21;
double price = 19.99;
float ratio = 3.14f;
char grade = 'A';
bool isPassed = true;
string name = "Hudson";
long bigNumber = 1234567890L;
decimal money = 10.50m;
```

## Common primitive types

* `int` → whole numbers
* `double` → decimals, most common for math
* `float` → decimals, less precise than double
* `decimal` → money/financial calculations
* `char` → single character
* `bool` → true/false
* `string` → text
* `long` → larger integers

---

# 3. Printing Output

```csharp
Console.WriteLine("Hello");
Console.Write("Hi ");
Console.WriteLine("there");
```

## String concatenation

```csharp
int x = 5;
Console.WriteLine("Value: " + x);
```

## String interpolation

```csharp
int x = 5;
Console.WriteLine($"Value: {x}");
```

## Formatting numbers

```csharp
double pi = 3.1415926535;
Console.WriteLine($"{pi:F2}");   // 3.14
Console.WriteLine($"{pi:F4}");   // 3.1416
```

---

# 4. Reading Input

```csharp
string input = Console.ReadLine();
Console.WriteLine("You entered: " + input);
```

## Convert input to int

```csharp
int n = int.Parse(Console.ReadLine());
```

## Safer version

```csharp
string input = Console.ReadLine();
int n;

if (int.TryParse(input, out n))
{
    Console.WriteLine("Valid number: " + n);
}
else
{
    Console.WriteLine("Invalid input");
}
```

---

# 5. If / Else

```csharp
int x = 10;

if (x > 0)
{
    Console.WriteLine("Positive");
}
else if (x < 0)
{
    Console.WriteLine("Negative");
}
else
{
    Console.WriteLine("Zero");
}
```

## Ternary operator

```csharp
int age = 20;
string result = age >= 18 ? "Adult" : "Minor";
Console.WriteLine(result);
```

---

# 6. Switch

```csharp
int day = 2;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    default:
        Console.WriteLine("Other");
        break;
}
```

---

# 7. Loops

## for loop

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

## while loop

```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
```

## do-while loop

```csharp
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 5);
```

## foreach loop

```csharp
int[] nums = { 1, 2, 3, 4 };

foreach (int num in nums)
{
    Console.WriteLine(num);
}
```

---

# 8. Arrays

## Declare and initialize

```csharp
int[] nums = { 10, 20, 30 };
string[] names = { "Alice", "Bob", "Charlie" };
```

## Access elements

```csharp
Console.WriteLine(nums[0]);   // 10
nums[1] = 99;
```

## Array length

```csharp
Console.WriteLine(nums.Length);
```

## Loop through array

```csharp
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}
```

## Common array utilities

```csharp
Array.Sort(nums);
Array.Reverse(nums);
int index = Array.IndexOf(nums, 30);
bool exists = Array.Exists(nums, x => x == 20);
```

---

# 9. Lists

Use `List<T>` when you need dynamic size.

```csharp
using System.Collections.Generic;

List<int> numbers = new List<int>();
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);

Console.WriteLine(numbers[0]);
Console.WriteLine(numbers.Count);
```

## Common list methods

```csharp
numbers.Remove(20);
numbers.RemoveAt(0);
numbers.Contains(30);
numbers.Sort();
numbers.Reverse();
numbers.Insert(0, 100);
numbers.Clear();
```

## Loop through a list

```csharp
foreach (int n in numbers)
{
    Console.WriteLine(n);
}
```

---

# 10. Strings

## Declare

```csharp
string text = "Hello";
```

## Common string methods

```csharp
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
```

## Split

```csharp
string line = "apple,banana,orange";
string[] parts = line.Split(',');

foreach (string part in parts)
{
    Console.WriteLine(part);
}
```

## Join

```csharp
string[] words = { "I", "love", "C#" };
string sentence = string.Join(" ", words);
Console.WriteLine(sentence);
```

## Compare strings

```csharp
string a = "hello";
string b = "HELLO";

Console.WriteLine(a == b);                           // false
Console.WriteLine(a.Equals(b));                      // false
Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase)); // true
```

---

# 11. StringBuilder

Better for repeated string modification.

```csharp
using System.Text;

StringBuilder sb = new StringBuilder();
sb.Append("Hello");
sb.Append(" ");
sb.Append("World");

Console.WriteLine(sb.ToString());
```

Useful when building large strings in loops.

---

# 12. Methods

## Basic method

```csharp
public static void Greet()
{
    Console.WriteLine("Hello");
}
```

## Method with parameters

```csharp
public static void GreetUser(string name)
{
    Console.WriteLine("Hello, " + name);
}
```

## Method with return value

```csharp
public static int Add(int a, int b)
{
    return a + b;
}
```

## Calling methods

```csharp
Greet();
GreetUser("Hudson");
int result = Add(3, 5);
Console.WriteLine(result);
```

---

# 13. Method Overloading

Same method name, different parameter lists.

```csharp
public static int Add(int a, int b)
{
    return a + b;
}

public static double Add(double a, double b)
{
    return a + b;
}
```

---

# 14. Pass by Value vs Reference

## Normal parameter

```csharp
public static void ChangeValue(int x)
{
    x = 100;
}
```

`x` does not change outside the method.

## ref

```csharp
public static void ChangeValue(ref int x)
{
    x = 100;
}

int a = 5;
ChangeValue(ref a);
Console.WriteLine(a);   // 100
```

## out

```csharp
public static void GetValues(out int x, out int y)
{
    x = 10;
    y = 20;
}
```

---

# 15. Classes and Objects

```csharp
public class Person
{
    public string Name;
    public int Age;

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
    }
}
```

## Create object

```csharp
Person p = new Person();
p.Name = "Hudson";
p.Age = 22;
p.Introduce();
```

---

# 16. Constructors

```csharp
public class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
```

## Use constructor

```csharp
Person p = new Person("Hudson", 22);
```

---

# 17. Properties

Preferred over public fields.

```csharp
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
```

## Read-only or private set

```csharp
public class Person
{
    public string Name { get; private set; }

    public Person(string name)
    {
        Name = name;
    }
}
```

---

# 18. Access Modifiers

* `public` → accessible anywhere
* `private` → only inside the class
* `protected` → inside class and derived classes
* `internal` → same assembly/project

Example:

```csharp
public class Example
{
    private int secret = 5;
    public int visible = 10;
}
```

---

# 19. Static

Belongs to the class, not an object.

```csharp
public class MathHelper
{
    public static int Square(int x)
    {
        return x * x;
    }
}
```

Call:

```csharp
int result = MathHelper.Square(4);
```

---

# 20. Exception Handling

```csharp
try
{
    int x = int.Parse("abc");
}
catch (FormatException)
{
    Console.WriteLine("Invalid number format");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Done");
}
```

---

# 21. Common Collections

## Dictionary

Key-value pairs.

```csharp
using System.Collections.Generic;

Dictionary<string, int> scores = new Dictionary<string, int>();
scores["Alice"] = 90;
scores["Bob"] = 85;

Console.WriteLine(scores["Alice"]);
```

### Common methods

```csharp
scores.ContainsKey("Alice");
scores.ContainsValue(90);
scores.Remove("Bob");
```

### Iterate

```csharp
foreach (KeyValuePair<string, int> pair in scores)
{
    Console.WriteLine(pair.Key + " -> " + pair.Value);
}
```

---

## HashSet

Stores unique values.

```csharp
HashSet<int> set = new HashSet<int>();
set.Add(1);
set.Add(2);
set.Add(2);   // ignored

Console.WriteLine(set.Contains(2));
```

Useful for duplicate checks.

---

## Queue

FIFO.

```csharp
Queue<int> q = new Queue<int>();
q.Enqueue(10);
q.Enqueue(20);

Console.WriteLine(q.Dequeue());  // 10
Console.WriteLine(q.Peek());     // 20
```

---

## Stack

LIFO.

```csharp
Stack<int> stack = new Stack<int>();
stack.Push(10);
stack.Push(20);

Console.WriteLine(stack.Pop());   // 20
Console.WriteLine(stack.Peek());  // 10
```

---

# 22. Nullable Types

```csharp
int? x = null;

if (x.HasValue)
{
    Console.WriteLine(x.Value);
}
else
{
    Console.WriteLine("null");
}
```

Short form:

```csharp
int? x = null;
int y = x ?? 0;   // if x is null, use 0
```

---

# 23. Math

```csharp
Console.WriteLine(Math.Abs(-5));      // 5
Console.WriteLine(Math.Max(3, 7));    // 7
Console.WriteLine(Math.Min(3, 7));    // 3
Console.WriteLine(Math.Pow(2, 3));    // 8
Console.WriteLine(Math.Sqrt(16));     // 4
Console.WriteLine(Math.Ceiling(3.2)); // 4
Console.WriteLine(Math.Floor(3.9));   // 3
Console.WriteLine(Math.Round(3.6));   // 4
```

---

# 24. Parsing and Conversion

```csharp
string s = "123";
int x = int.Parse(s);
double d = double.Parse("3.14");
```

Safer:

```csharp
if (int.TryParse("123", out int value))
{
    Console.WriteLine(value);
}
```

Convert types:

```csharp
int x = 10;
string s = x.ToString();

double d = 3.14;
int n = (int)d;   // 3
```

---

# 25. LINQ Basics

LINQ is very common in C#.

```csharp
using System.Linq;
```

## Example list

```csharp
List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6 };
```

## Filter

```csharp
var evens = nums.Where(x => x % 2 == 0);
```

## Transform

```csharp
var squares = nums.Select(x => x * x);
```

## First / FirstOrDefault

```csharp
int firstEven = nums.First(x => x % 2 == 0);
int maybe = nums.FirstOrDefault(x => x > 10);   // 0 if not found for int
```

## Any / All

```csharp
bool hasEven = nums.Any(x => x % 2 == 0);
bool allPositive = nums.All(x => x > 0);
```

## Count

```csharp
int countEven = nums.Count(x => x % 2 == 0);
```

## Sum / Min / Max / Average

```csharp
int sum = nums.Sum();
int min = nums.Min();
int max = nums.Max();
double avg = nums.Average();
```

## OrderBy

```csharp
var sorted = nums.OrderBy(x => x);
var desc = nums.OrderByDescending(x => x);
```

## ToList / ToArray

```csharp
List<int> evenList = nums.Where(x => x % 2 == 0).ToList();
int[] evenArray = nums.Where(x => x % 2 == 0).ToArray();
```

---

# 26. Lambda Expressions

A lambda is a short function.

```csharp
x => x * 2
```

Examples:

```csharp
List<int> nums = new List<int> { 1, 2, 3 };

var doubled = nums.Select(x => x * 2).ToList();
var evens = nums.Where(x => x % 2 == 0).ToList();
```

---

# 27. Common Array and String Interview Patterns

## Reverse string

```csharp
string s = "hello";
char[] arr = s.ToCharArray();
Array.Reverse(arr);
string reversed = new string(arr);
Console.WriteLine(reversed);
```

## Check duplicate in array

```csharp
int[] nums = { 1, 2, 3, 1 };
HashSet<int> seen = new HashSet<int>();

bool hasDuplicate = false;

foreach (int num in nums)
{
    if (seen.Contains(num))
    {
        hasDuplicate = true;
        break;
    }

    seen.Add(num);
}
```

## Frequency count

```csharp
string s = "banana";
Dictionary<char, int> freq = new Dictionary<char, int>();

foreach (char c in s)
{
    if (freq.ContainsKey(c))
    {
        freq[c]++;
    }
    else
    {
        freq[c] = 1;
    }
}
```

## Two pointers

```csharp
int left = 0;
int right = nums.Length - 1;

while (left < right)
{
    // process
    left++;
    right--;
}
```

---

# 28. Common `string` / `char` Helpers

```csharp
char c = 'A';

Console.WriteLine(char.IsDigit(c));
Console.WriteLine(char.IsLetter(c));
Console.WriteLine(char.IsLetterOrDigit(c));
Console.WriteLine(char.ToLower(c));
Console.WriteLine(char.ToUpper(c));
Console.WriteLine(char.IsWhiteSpace(' '));
```

Useful for palindrome and parsing problems.

---

# 29. Useful `List<T>` Helpers

```csharp
List<int> nums = new List<int> { 5, 2, 8, 1 };

nums.Sort();
nums.Reverse();

int first = nums[0];
int last = nums[nums.Count - 1];
```

Convert between list and array:

```csharp
int[] arr = nums.ToArray();
List<int> list = arr.ToList();
```

---

# 30. Multidimensional and Jagged Arrays

## 2D array

```csharp
int[,] matrix = new int[2, 3];

matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[0, 2] = 3;
```

Loop:

```csharp
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
```

## Jagged array

```csharp
int[][] grid = new int[2][];
grid[0] = new int[] { 1, 2, 3 };
grid[1] = new int[] { 4, 5 };
```

---

# 31. Enums

```csharp
public enum Day
{
    Monday,
    Tuesday,
    Wednesday
}
```

Use:

```csharp
Day today = Day.Monday;
Console.WriteLine(today);
```

---

# 32. File Basics

```csharp
using System.IO;

string text = "Hello file";
File.WriteAllText("test.txt", text);

string content = File.ReadAllText("test.txt");
Console.WriteLine(content);
```

Check existence:

```csharp
if (File.Exists("test.txt"))
{
    Console.WriteLine("File exists");
}
```

---

# 33. Simple LeetCode-Style Template

```csharp
using System;

public class Solution
{
    public int ExampleMethod(int[] nums)
    {
        return nums.Length;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();

        int[] nums = { 1, 2, 3, 4 };
        int result = sol.ExampleMethod(nums);

        Console.WriteLine(result);
    }
}
```

---

# 34. Common Access to Last Item

## Array

```csharp
int last = arr[arr.Length - 1];
```

## List

```csharp
int last = list[list.Count - 1];
```

---

# 35. `var` Keyword

```csharp
var name = "Hudson";   // inferred as string
var nums = new List<int>();
```

Use `var` when the type is obvious. Avoid overusing it if it hurts readability.

---

# 36. Null Checks

```csharp
string name = null;

if (name != null)
{
    Console.WriteLine(name.Length);
}
```

Null-conditional operator:

```csharp
Console.WriteLine(name?.Length);
```

Null-coalescing:

```csharp
string output = name ?? "default";
```

---

# 37. Common Interview Helpers

## Sort array

```csharp
Array.Sort(nums);
```

## Sort list

```csharp
list.Sort();
```

## Copy array

```csharp
int[] copy = new int[nums.Length];
Array.Copy(nums, copy, nums.Length);
```

## Fill array

```csharp
int[] arr = new int[5];
Array.Fill(arr, -1);
```

---

# 38. `break`, `continue`, `return`

## break

Stops the loop.

```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break;
    }
}
```

## continue

Skip current iteration.

```csharp
for (int i = 0; i < 5; i++)
{
    if (i == 2)
    {
        continue;
    }

    Console.WriteLine(i);
}
```

## return

Exit method.

```csharp
public static int Add(int a, int b)
{
    return a + b;
}
```

---

# 39. Comments

```csharp
// Single-line comment

/*
   Multi-line comment
*/
```

---

# 40. Namespace Example

```csharp
namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }
}
```

In small practice code, you often skip custom namespaces.

---

# 41. Quick Syntax Cheatsheet

## Print

```csharp
Console.WriteLine("Hello");
Console.WriteLine($"x = {x}");
```

## Read input

```csharp
string s = Console.ReadLine();
int n = int.Parse(Console.ReadLine());
```

## Array

```csharp
int[] arr = { 1, 2, 3 };
arr.Length
```

## List

```csharp
List<int> list = new List<int>();
list.Add(10);
list.Count
```

## Dictionary

```csharp
Dictionary<char, int> map = new Dictionary<char, int>();
map['a'] = 1;
```

## HashSet

```csharp
HashSet<int> set = new HashSet<int>();
set.Add(1);
set.Contains(1);
```

## String

```csharp
s.Length
s.ToLower()
s.ToUpper()
s.Trim()
s.Split(',')
s.Contains("abc")
```

## LINQ

```csharp
nums.Where(x => x > 0)
nums.Select(x => x * 2)
nums.Sum()
nums.Max()
nums.Min()
nums.Count()
```

---

# 42. Most Common `using` Statements

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
```

* `System` → Console, Math, basic types
* `System.Collections.Generic` → List, Dictionary, HashSet, Queue, Stack
* `System.Linq` → Where, Select, Sum, Any, FirstOrDefault
* `System.Text` → StringBuilder
* `System.IO` → file reading/writing

---

# 43. Very Common Mistakes to Watch For

## Arrays vs Lists

* array length → `arr.Length`
* list count → `list.Count`

## Strings are immutable

This does not modify the original string:

```csharp
string s = "hello";
s.ToUpper();
Console.WriteLine(s);   // still "hello"
```

Need:

```csharp
s = s.ToUpper();
```

## Integer division

```csharp
int a = 5;
int b = 2;
Console.WriteLine(a / b);   // 2
```

Use:

```csharp
Console.WriteLine((double)a / b);   // 2.5
```

## Index out of bounds

Last valid index:

```csharp
arr.Length - 1
```

---

# 44. Good Mental Model for C#

Think of C# as:

* Java-like structure
* cleaner built-in libraries
* strong support for collections and LINQ
* very good for console apps, OOP, backend, and interview coding

For quick problem solving, the most-used parts are:

* `if`, loops
* arrays and lists
* dictionary and hashset
* strings
* helper methods
* LINQ when convenient

---

# 45. Mini Examples You Can Reuse Fast

## Sum array

```csharp
int[] nums = { 1, 2, 3, 4 };
int sum = 0;

foreach (int n in nums)
{
    sum += n;
}

Console.WriteLine(sum);
```

## Find max

```csharp
int max = nums[0];

for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] > max)
    {
        max = nums[i];
    }
}
```

## Reverse list manually

```csharp
List<int> list = new List<int> { 1, 2, 3 };
list.Reverse();
```

## Count characters

```csharp
string s = "hello";
Dictionary<char, int> map = new Dictionary<char, int>();

foreach (char c in s)
{
    if (!map.ContainsKey(c))
    {
        map[c] = 0;
    }

    map[c]++;
}
```

---

# 46. What to Review Before Coding Again

If you forget C#, review in this order:

1. `Main` method and print/input
2. `if`, loops, methods
3. arrays and lists
4. dictionary and hashset
5. string methods
6. LINQ basics
7. classes and objects
8. exception handling

That alone covers a huge amount of normal C# use.

---

# 47. Final Fast Interview/LeetCode Recap

Most frequent tools:

* `int[]`
* `List<int>`
* `Dictionary<int, int>`
* `HashSet<int>`
* `string`
* `StringBuilder`
* `for`, `foreach`, `while`
* `if`
* helper method
* `Array.Sort()`
* `string.Join()`
* `Split()`
* `Where`, `Select`, `Any`, `Count`, `Sum`

If you remember those, you can solve a lot already.

---

# 48. Tiny Ready-to-Copy Starter Template

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Numbers:");
        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }

        int sum = nums.Sum();
        Console.WriteLine($"Sum = {sum}");
    }
}
```

---

If you want, I can also turn this into a more polished **GitHub `README.md` version** with:

* table of contents
* code sections
* LeetCode examples
* OOP section
* C# console project commands (`dotnet new`, `dotnet run`)
