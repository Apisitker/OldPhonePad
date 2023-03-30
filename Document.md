# OldPhonePad function documentation
The OldPhonePad function is a static method that takes a string input and returns a string output. The function converts input from an old-style phone keypad (with only numbers and special characters such as # and *) to a modern-style phone keypad (with letters and numbers).

## Parameters
input: The input string to be converted. It can contain numbers from 2 to 9, the special characters # and *, and spaces.

## Return Value
The function returns a string containing the modern-style phone keypad equivalent of the input string.

## Algorithm
1. The function first initializes a dictionary keypad that maps each number from 2 to 9 to its corresponding letters.
2. Then, it creates a StringBuilder called output to store the converted output.
3. The function iterates through each character in the input string.
4. If the character is a number from 2 to 9, the function checks the subsequent characters in the string to see how many times the same number appears consecutively.
5. If the subsequent character is a space, the function appends the corresponding letter to the output string and moves the iterator to the character immediately after the space.
6. If the subsequent character is a different number or a non-space character, the function appends the corresponding letter to the output string and moves the iterator to the current character.
7. If the character is #, the function exits the loop and returns the output string.
8. If the character is *, the function removes the last character from the output string.

## Example
```
string input = "2 22 222 #";
string output = OldPhonePad(input); // output will be "abc"
```

## Complexity
The time complexity of the OldPhonePad function is O(n), where n is the length of the input string. The space complexity is also O(n), since the StringBuilder output stores the converted string.
