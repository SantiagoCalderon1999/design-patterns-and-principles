# Flyweight

We use a flyweight when our system needs a large number of objects of a particular class
and maintaining these instances is a performance concern.

## Problem

In the code we want to create an error message. We have a common shared intrinsic state
which is a SystemErrorMessage. This is shared between all the objects.

## Solution

For achieving the goal of having many instances of a class with an specific state,
the Flyweight design pattern is implemented. This way, we have a SystemErrorMessage
class that acts as a concreteFlyweight, i.e. an intrinsic state. On the other hand,
the UserBannedErrorMessage acts as a class that includes objects with extrinsic state.
This example may be improved including a better approach of the Flyweight pattern.