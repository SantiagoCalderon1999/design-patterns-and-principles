# S -> Single responsibility principle

The Single responsibility principle states that there should ONLY be one reason
for changing a class. This basically means that a class must only be related to 
one function.

## Problem

In the code you can see that the UserController class is handling validation,
mapping the Json to the User and persistence. This creates an issue because if you need
to change validation and mapping, you would have to modify the same class. This might
be harder to do since you are making both changes in the same class. Hence, a change could lead to
side-effects and when you finally fix that, you need to apply the other change.
Aside from that, classes with a single responsibility are substantially easier to understand.

## Solution

In order to fix the UserController problem, it is recommended to implement three additional classes:
UserMapper, UserPersistenceService and UserValidator. This will derive in an improved
understandability of the code.