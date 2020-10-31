using System;

class Solution
{
    public static char[] ReverseWords(char[] arr)
    {
      int spacepos = Array.IndexOf(arr, ' ');

      if (spacepos == -1) return arr;
      
      Array.Reverse(arr);
      int start = 0, end = 0;
      
      do 
      {
        end = Array.IndexOf(arr, ' ', start);
        if (end == -1) end = arr.Length;
        Array.Reverse(arr, start, end-start);
        start = end + 1;
      } while (end < arr.Length);

      return arr;
    }
  
    static void Main(string[] args)
    {

    }
}

Console.WriteLine("Hello world!");
