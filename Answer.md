## Sentence Reverse Answer

One possible solution is doing a linear iteration on `arr` while pushing a copy of every word to a stack and then pulling them in reverse order while copying the words back into `arr`. Another approach is initializing a new array at the same length, iterating over `arr` from right to left and copying any sequence of characters to the new array from left to right. Both approaches take `O(N)` time and at least `O(N)` space.

A more elegant and efficient approach is to reverse all the characters in `arr` and then reverse the characters in each word separately. While the first reverse gives us the words in the reverse order as we wanted, it also reverses the characters of each word. To fix that, we do the second reverse, which reverses each word separately.

Reversing items in an array is done by a ‘mirror’ function, that swaps the items of every 2 indices with the same distance from the middle.

**Pseudocode:**

```pramp
function reverseWords(arr):
    # reverse all characters:
    n = arr.length
    mirrorReverse(arr, 0, n-1)

    # reverse each word:
    wordStart = null
    for i from 0 to n-1:
        if (arr[i] == ' '):
            if (wordStart != null):
                mirrorReverse(arr, wordStart, i-1)
                wordStart = null
        else if (i == n-1):
            if (wordStart != null):
                mirrorReverse(arr, wordStart, i)
        else:
            if (wordStart == null):
                wordStart = i

    return arr


# helper function - reverses the order of items in arr
# please note that this is language dependent:
# if are arrays sent by value, reversing should be done in place

function mirrorReverse(arr, start, end):
    tmp = null
    while (start < end):
        tmp = arr[start]
        arr[start] = arr[end]
        arr[end] = tmp
        start++
        end--
```

**Time Complexity:** traversing the array twice with a constant number of actions for each item is linear `O(N)`.

**Space Complexity:** using iteration indices and one temp variable takes constant `O(1)` memory.