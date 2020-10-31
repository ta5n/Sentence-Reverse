## My Solution

### C#

```csharp
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

    static void Main(string[] args) {   }
}
```

### Test Cases

- Test Case #1
  - Input: [" "," "],
  - Expected: [" "," "]
- Test Case #2

  - Input: ["a"," "," ","b"],
  - Expected: ["b"," "," ","a"]

- Test Case #3

  - Input: ["h","e","l","l","o"],
  - Expected: ["h","e","l","l","o"]

- Test Case #4
  - Input: ["p","e","r","f","e","c","t"," ","m","a","k","e","s"," ","p","r","a","c","t","i","c","e"]
  - Expected: ["p","r","a","c","t","i","c","e"," ","m","a","k","e","s"," ","p","e","r","f","e","c","t"]
- Test Case #5

  - Input: ["y","o","u"," ","w","i","t","h"," ","b","e"," ","f","o","r","c","e"," ","t","h","e"," ","m","a","y"],
  - Expected: ["m","a","y"," ","t","h","e"," ","f","o","r","c","e"," ","b","e"," ","w","i","t","h"," ","y","o","u"]

- Test Case #6

  - Input: ["g","r","e","a","t","e","s","t"," ","n","a","m","e"," ","f","i","r","s","t"," ","e","v","e","r"," ","n","a","m","e"," ","l","a","s","t"],
  - Expected: ["l","a","s","t"," ","n","a","m","e"," ","e","v","e","r"," ","f","i","r","s","t"," ","n","a","m","e"," ","g","r","e","a","t","e","s","t"]
