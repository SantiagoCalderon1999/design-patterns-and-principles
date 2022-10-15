# Adapter

We use an adapter when we have an existing object which provides functionality that clients needs. But
client code can't use this object because it expects an object with different
interface. It is sometimes called a wrapper.

## Problem

In the code we have a Customer interface and an Employee class.
We have a BusinessDesigner that needs a Customer as a parameter,
however we only have an Employee object. Therefore, we need to 
adapt the Employee to the Customer.

## Solution - Class

We can create a class that implements the Customer interface 
and extends the Employee class. By doing that, we can adapt
directly methods from Employee to Customer.

## Solution - Object

We can create a class that implements the Customer interface
and has an Employee object. We have to initialize the Employee
object in a constructor, and then we can map directly its methods
to the Customer interface.

## Preferred approach

The latter one (Object adapter) is the preferred solution as Class adapter
may break Liskov substitution principle. Besides people would be able to use
Customer methods and Employee methods in the same class. That would create a mess!