# Factory Method

Factory method provides an interface for creating objects in a superclass,
but allows many subclasses to alter the type of objects that will be created. This pattern is used when it is
desired to move the object creation logic to separate a class and we do not know in advance which class we 
may need to instantiate.

## Problem

We have a Message abstract class and two children inheriting from this class (JSONMessage and TextMessage). 
We want to create these objects by providing a creator object.

## Solution

We create an abstract class which configures the message. This class implements an abstract method that 
will be used for creating the specific Message class. Therefore, we create JSONMessageCreator and
TextMessageCreator for dealing with the creation of JSONMessage and TextMessage objects. It is noticeable
that the creators follow the same structure as the Messages.