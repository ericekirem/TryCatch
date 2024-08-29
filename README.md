# **Try-Catch Example Project**

This project is a simple C# application that demonstrates the use of the try-catch structure to handle user input errors. The program prompts the user to enter a number, calculates the square of the number if the input is valid, and handles invalid inputs by displaying an appropriate error message.

# **Project Description**
Functionality
The program asks the user to enter a number.
If the user enters a valid integer, the program calculates and displays the square of the number.
If the user enters an invalid input (e.g., letters or symbols instead of a number), the program catches the FormatException and displays a custom error message.
Code Structure
Try Block: The try block contains the code that attempts to parse the user's input as an integer and calculate its square.
Catch Block: The catch block handles the FormatException that occurs when the input cannot be parsed as an integer, and it provides feedback to the user.

# **Usage**
Running the Project:

Upon running the program, the user is prompted to enter a number.
If the user inputs a valid number, the program calculates and prints the square of the number.
If the input is invalid, an error message "Invalid input! Please enter a number." is displayed.
Error Handling:

The program demonstrates basic error handling using the try-catch mechanism in C#.
This ensures that the program does not crash when the user enters an unexpected input.


# **Development**
This project is an introductory example for understanding error handling in C#. Potential extensions include:

Adding more detailed error messages for different types of exceptions.
Implementing a loop to continuously prompt the user until a valid input is received.

# **Requirements**
.NET Framework (or .NET Core)
A C# IDE (Visual Studio, Visual Studio Code, etc.)
