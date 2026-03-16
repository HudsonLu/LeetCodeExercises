using System;

public class ValidPalindromeProblem : ILeetCodeProblem
{
    public string Name
    {
        get { return "Valid Palindrome"; }
    }

    public void Run()
    {
        string s = "A man, a plan, a canal: Panama";

        bool result = IsPalindrome(s);

        Console.WriteLine("Input: " + s);
        Console.WriteLine("Output: " + result);
    }

    private bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !Char.IsLetterOrDigit(s[left]))
            {
                left++;
            }

            while (left < right && !Char.IsLetterOrDigit(s[right]))
            {
                right--;
            }

            if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}