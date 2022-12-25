# CSharp.Net

## Grade App

Expectation -
1. User will add a mark in the command prompt
2. Grade will display based on the mark with Pass / Fail. Example: Mark: 50, Result: Fail

Technicals -
Mark < 50   ->  Fail
Mark > 50 && < 55    ->  D Grade
Mark > 55 && < 65    ->  C Grade
Mark > 65 && < 75    ->  B Grade
Mark > 75 && < 90    ->  A Grade
Mark > 90 && < 100  ->  A+ Grade


## Prime Number

Prime number is a number which is divisible by itself or 1. Does not have factors other than 1 and number itself.

### Core logic:
factors = number % 2
Any number other than 0, 1 &&
Other than it, Check the number factors if its not 1 and also not divisible by 2, 3, 5.
Any number that does not satisfy any of the above is prime number.


0 - Not a prime number

1 - Not a prime number

2 - 1* 2 - prime number

3 - 1 * 3 - prime number

4 - 1 * 2 * 2 - Not  a prime number

5 - 1 * 5 - prime number

6 - 1 * 2 * 3 - Not a prime number

7 -  1 * 7 - prime number

8 - 1 * 2 * 4 - Not a prime number
