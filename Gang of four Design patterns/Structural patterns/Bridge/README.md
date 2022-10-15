# Bridge

We use a bridge when we need to decouple implementations and abstractions so that they can change
without affecting each other. It is useful when we have complex implementations of abstractions
such as:
Abstraction: Shape
Implementation: GreenTriangle, RedTriangle, GreenCircle, RedCircle

We could use this pattern to have a shape abstraction and a color implementor. This way
we could inherit Triangle and Circle from Shape, and we should include a color attribute
that is going to be an object of a Color parent class which has Green and Red as children.

## Problem

In the code we see a FifoCollection which is an abstraction. This abstraction has a
refinedAbstraction which is the Queue class. It is known that we could have a QueueArrayLinkedList and a
QueueSinglyLinkedList. however if we would like to add another refined abstraction, we would have to add
two classes. This problem would only grow exponentially over time.

## Solution

We can include the LinkedList as a BRIDGE in the Queue for giving it the methods we want to use.
Thus, the Queue will have ArrayLinkedList or SinglyLinkedList functionalities, depending on the 
implementation of the interface we use in the Queue constructor.