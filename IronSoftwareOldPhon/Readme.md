#OldPhonePad
OldPhonePad is a method that takes a string input and returns a string that represents the corresponding numbers dialed on an old phone keypad.

##Usage
To use the OldPhonePad method, pass a string as input to the method. The method will return a string representing the phone keypad numbers corresponding to the input.

Example:

```
string input = "8 88777444666*664#";
string output = OldPhonePad(input); // output will be "TURING"
```

##Implementation
The OldPhonePad method uses a dictionary that maps keypad numbers to their corresponding letters. It loops through the input string and converts each character to its corresponding keypad number.

The method also handles repeated characters and spaces by keeping track of a repeat count and updating the index accordingly. It also handles the '#' and '*' characters as the end of the input and as a backspace operation, respectively.

##Contact
If you have any questions or feedback, please feel free to contact me at kerdtalod@gmail.com.