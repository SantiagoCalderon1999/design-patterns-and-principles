# O -> Open-closed principle

the Open-closed principle states that software entities should be opened for extension but closed for 
modification. In other words, you should extend the existing behavior of the code and keep
all the existing code unchanged. For further information, follow this [link](https://www.baeldung.com/java-open-closed-principle)

## Problem

The IPSSubscriber and the PhoneSubscriber share some attributes and some methods. Aside from that, if 
you would like to create a subscriber object, you would have to create an if-else statement for each type of subscriber.
So, when you add another subscriber for the system, you would have to add another nested if-else.
This is an issue because you have to modify this "factory" class, each time you need to create another type
of subscriber.

## Solution

The solution would be to leverage inheritance in OOP. You may create an abstract class (differs from
normal classes because it implements abstract methods) that implements all common attributes, and 
make mandatory to use the calculateBill method in child classes, by making it abstract.
