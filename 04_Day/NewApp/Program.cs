


using System;
using System.Collections.Generic;

namespace Hello
{
  class Program
  {

    // Sum of Array Elements
    public static int ArraySum(int[] arr)
    {
      int sum = 0;
      foreach (int i in arr)
      {
        sum = sum + i;
      }
      return sum;
    }


    // Find the Missing Number
    public static int FindMissNumber(int[] arr, int n)
    {
      int sumArr = n * (n + 1) / 2;

      int arrSum = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        arrSum += arr[i];

      }
      int missingValue = sumArr - arrSum;
      return missingValue;
    }

    // Reverse an Array in Place
    public static void ReverseArray(int[] arr)
    {
      for (int i = arr.Length - 1; i >= 0; i--)
      {
        Console.Write($"{arr[i]} ");
      }
      Console.WriteLine();

    }




    // Find the Majority Element


    public static int MajorityElement(int[] arr)
    {

      Dictionary<int, int> NewArray = new Dictionary<int, int>();
      foreach (int i in arr)
      {
        if (NewArray.ContainsKey(i))
        {
          NewArray[i]++;
        }
        else
        {
          NewArray.Add(i, 1);
        }
        if (NewArray[i] > (arr.Length / 2))
        {
          return i;
        }
      }

      return -1;
    }

    // Rotate an Array by K Positions
    // Rotate an array to the right by k steps.
    // Signature: public static void RotateArray(int[] arr, int k)
    // Example Input: [1, 2, 3, 4, 5, 6, 7], k = 3
    // Output: [5, 6, 7, 1, 2, 3, 4]

    public static void Reverse(int[] arr, int left, int right)
    {
      while (left < right)
      {
        int temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
        left++;
        right--;
      }
    }
    public static void RotateArray(int[] arr, int k)
    {
      int n = arr.Length;
      k = k % n;

      Reverse(arr, 0, n - 1);
      Reverse(arr, 0, k - 1);
      Reverse(arr, k, n - 1);

    }


    // Find Pair with Given Sum in a Sorted Array
    // Return indices of two numbers that sum to a target(Two - Pointer approach).
    // Signature: public static int[] TwoSumSorted(int[] arr, int target)
    // Example Input: [1, 2, 3, 4, 6], target = 6
    // Output: [1, 3]
    public static int[] TwoSumSorted(int[] arr, int target)
    {
      int n = arr.Length;
      int sum = 0;
      int left = 0, right = n - 1;
      while (left < right)
      {
        sum = arr[left] + arr[right];
        if (sum == target)
        {
          return [left, right];
        }
        else if (sum < target)
        {
          left++;
        }
        else
        {
          right--;
        }
      }
      return [left, right];
    }


    // Find the Peak Element in an Array
    // Find an element that is greater than its neighbors.
    // Signature: public static int FindPeakElement(int[] arr)
    // Example Input: [1, 2, 3, 1]
    // Output: 3

    public static int FindPeakElement(int[] arr)
    {
      return arr.Max();
    }


    public static void Main()
    {
      int[] arr1 = [1, 2, 3, 4, 10, 11];
      Console.WriteLine($"Sum of Array Elements: {ArraySum(arr1)}");

      int[] arr2 = [1, 2, 4, 5, 6];
      int n = 6;
      Console.WriteLine($"Missing Number is: {FindMissNumber(arr2, n)}");

      int[] arr3 = [1, 2, 3, 4];
      ReverseArray(arr3);

      // string name = "swiss";
      // FirstUniqueChar(name);
      // System.Console.WriteLine("Hello");

      int[] arr5 = [3, 3, 4, 2, 3, 3, 3, 1];
      Console.WriteLine(MajorityElement(arr5));


      int[] arr6 = [1, 2, 3, 4, 5, 6, 7];
      int k = 3;
      RotateArray(arr6, k);
      Console.WriteLine("Rotated Array: " + string.Join(", ", arr6));


      int[] arr7 = [1, 2, 3, 4, 6];
      int target = 6;
      TwoSumSorted(arr7, target);
      Console.WriteLine($"Two SUm Sorted : {string.Join(", ", TwoSumSorted(arr7, target))}");

      int[] arr8 = [1, 2, 3, 1];
      Console.WriteLine(FindPeakElement(arr8));


      

    }
  }

}