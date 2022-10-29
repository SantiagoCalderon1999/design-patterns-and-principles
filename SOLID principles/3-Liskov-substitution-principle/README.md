# L -> Liskov Substitution principle

The Liskov substition principle states that we should be able to substitute base class
objects with child class objects and this should not alter the
behavior of the program.

## Problem

In the code you can see that the Square is a child of the Rectangle as it is 
mathematically accurate. However, when you provide a Square instance to a function
requiring a Rectangle, it would lead to some buggy behavior, because the Square changes
the behavior of the parent.

## Solution

In order to fix this issue, a Shape interface must be included in order to inherit functions
but not behavior. The Shape interface must be implemented in the Rectangle and Square class.
This way, the Square is no longer extending the Rectangle class and changing the behavior of its
methods. By following this principle, if a new class get added, it won't interfere with past behavior.