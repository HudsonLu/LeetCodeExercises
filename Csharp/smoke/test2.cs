using System;
using System.ComponentModel;

public class Test2 : ILeetCodeProblem
{
    public string Name
    {
        get { return "Test2"; }
    }

    public void Run()
    {
        string s = "A man, a plan, a canal: Panama";

        Console.WriteLine("Input: " + s);
        Console.WriteLine("Output: " + s);
    }











    /*
     * 
     * 
     * 
 
     Check duplicate in array

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

    Frequency count 

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


////////////////////////
///
/// 
/// public int[] TwoSum(int[] nums, int target)
{
    var dict = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];
        if (dict.ContainsKey(complement))
            return new int[] { dict[complement], i };

        dict[nums[i]] = i;
    }
    return null;
}
///



Initial:  [5, 2, 9, 1, 3]
Pass 1 -> [2, 5, 1, 3, 9]
Pass 2 -> [2, 1, 3, 5, 9]
Pass 3 -> [1, 2, 3, 5, 9]
Pass 4 -> [1, 2, 3, 5, 9]




    static void Sort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++) // Because after each pass, the largest remaining value moves to the end, so we do not need to check it again.
            {
                if (arr[j] > arr[j + 1])
                {
                    // swap
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
///////////////////////////////////////////


using System;

class Program
{
    static void Main()
    {
        string s = "banana";
        int[] freq = new int[26];

        foreach (char c in s)
        {
            freq[c - 'a']++; // c - 'a' = 'b' - 'a' = 1
        }

        for (int i = 0; i < 26; i++)
        {
            if (freq[i] > 0)
            {
                Console.WriteLine($"{(char)(i + 'a')} : {freq[i]}");
            }
        }
    }
}
    
a : 3
b : 1
n : 2

a is index 0
b is index 1
n is index 13

    freq[0] → count of 'a'
    freq[1] → count of 'b'
///////////////////////




Array has a fixed size
List can grow/shrink dynamically


int[] arr = new int[10];


List<int> list = new List<int>();
list.Add(5);
list.Add(20);

    List<int> list = new List<int>(10);
    list.Count is still 0










     */
}