# Testing Calculator

Your workshop task is to change/upgrade & test the previously created calculator, you will need to
refactor(change) the code.

Create a Calc class and inside of it you shall have the methods that can calculate Addition,
Subtraction, Multiplication and Division on two decimal numbers.

You shall overload your addition (+) and subtract (-) methods with a version that takes an array as
input parameter (Ex: Addition method gets an array in with the following five numbers +1.1 -3.3 +5
+7 +8.8 and it returns the sum +18.6) (+/- indicates if it’s a positive or negative number).

The Program class is responsible for interacting with the user using the Console and letting the Calc
class and its methods do the calculation work.

Code Requirements:

• The Calc class may not contain any Console code.
• Throw a DivideByZeroException in your division method for dividing by Zero.
• Each mathematical operation should be testable by xUnit.
• Minimal of 3 tests per mathematical operation (Mix of Positive, Negative, decimal numbers).
• Make a method to take in user number inputs and use Try/Catch & exceptions to give
feedback to the user when they given incorrect inputs.
• Application needs to have an Overloaded method for Addition & Subtract that accepts an
array as input parameter.
