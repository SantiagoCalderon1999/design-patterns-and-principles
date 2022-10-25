# Visitor

The visitor allows us to define new operations that can be performed on an object without changing
the class definition of the object.

## Problem

Let's suppose that we have an Employee interface and a handful of classes implementing this interface.
We want to keep the logging in an unique class, as it would follow the single responsibility principle.
Therefore, we don't want to make changes in the existing classes.

## Solution

We might want to use the Visitor design pattern for tackling this problem, as this would allow us
to visit all the nodes (Employees) and make a call on a specific method. This way we would only have 
a PrintVisitor class handling the logging of all the objects.