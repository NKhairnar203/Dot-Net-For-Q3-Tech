using System;

namespace Hello
{

  class Program
  {
    public static int MaxArea(int[] height)
    {
      int n = height.Length;
      int left = 0, right = n - 1;
      int maxArea = 0;

      while (left < right)
      {

        int width = right - left;
        int minHeight = Math.Min(height[left], height[right]);
        int area = width * minHeight;

        maxArea = Math.Max(maxArea, area);

        if (height[left] < height[right])
        {
          left++;

        }
        else
        {
          right--;
        }

      }
      return maxArea;
    }


    public static int SearchInsert(int[] nums, int target)
    {
      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] == target)
        {
          return i;
        }
      }
      return -1;
    }

    public static int FindMissingNumber(int[] nums)
    {
      int n = nums.Length + 1;


      for (int i = 1; i <= n; i++)
      {
        bool found = false;
        for (int j = 0; j < nums.Length; j++)
        {
          if (nums[j] == i)
          {
            found = true;
            break;
          }
        }
        if (!found)
        {
          return i;
        }
      }
      return -1;
    }


    // 4. Rotate Image
    public static void Rotate(int[][] matrix)
    {
      for (int i = 0; i < matrix.Length; i++)
      {
        for (int j = i + 1; j < matrix.Length; j++)
        {
          //Console.WriteLine(matrix[i][j]);
          int temp = matrix[i][j];
          matrix[i][j] = matrix[j][i];
          matrix[j][i] = temp;
        }
      }
      for (int i = matrix.Length - 1; i >= 0; i--)
      {
        Array.Reverse(matrix[i]);
      }

      for (int i = 0; i < matrix.Length; i++)
      {
        for (int j = 0; j < matrix.Length; j++)
        {
          Console.Write(matrix[i][j] + " ");
        }
        Console.WriteLine();
      }
    }

    // 5. Valid Parentheses
    public static bool IsValid(string s)
    {
      Stack<char> stack = new Stack<char>();

      foreach (char c in s)
      {
        if (c == '{' || c == '[' || c == '(')
        {
          stack.Push(c);
        }
        else
        {
          if (stack.Count == 0)
          {
            return false;
          }

          char top = stack.Pop();

          if ((c == ')' && top != '(') ||
              (c == '}' && top != '{') ||
              (c == ']' && top != '['))
          {
            return false;
          }
        }
      }

      return stack.Count == 0;
    }

    // 10. Jump Game

    public static bool CanJump(int[] nums)
    {
      int maxReach = 0;

      for (int i = 0; i < nums.Length; i++)
      {
        if (i > maxReach)
          return false;

        maxReach = Math.Max(maxReach, i + nums[i]);

        if (maxReach >= nums.Length - 1)
          return true;
      }

      return false;
    }


    // 3. Longest Substring Without Repeating Characters
    public static int LengthOfLongestSubstring(string s)
    {
      HashSet<char> storeChar = new HashSet<char>();

      int left = 0, maxLen = 0;
      for (int right = 0; right < s.Length; right++)
      {
        while (storeChar.Contains(s[right]))
        {
          storeChar.Remove(s[left]);
          left++;
        }

        storeChar.Add(s[right]);
        maxLen = Math.Max(maxLen, right - left + 1);
      }
      return maxLen;
    }

    public static void Main(string[] args)
    {

      int[] arr1 = [1, 8, 6, 2, 5, 4, 8, 3, 7];
      Console.WriteLine($"MaxArea: {MaxArea(arr1)}");

      int[] arr2 = [1, 3, 5, 6];
      int target = 5;
      Console.WriteLine($"SearchInsert:  {SearchInsert(arr2, target)}");

      int[] arr3 = [3, 7, 1, 2, 8, 4, 5];
      Console.WriteLine($"FindMissingNumber:  {FindMissingNumber(arr3)}");

      int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
      Rotate(matrix);

      string input = "()[]{}";
      Console.WriteLine(IsValid(input));

      int[] Input = [2, 3, 1, 1, 4];
      Console.WriteLine(CanJump(Input));

      string Input = "abcabcbb";
      Console.WriteLine(LengthOfLongestSubstring(Input));
    }
  }
}