# Builder

The Builder design pattern is used when we have a complex process to construct an object.

## Problem

We have many parameters required for creating an UserDTO. We could use all these fields in the constructor. However,
it wouldn't be a good idea as it wouldn't be the cleanest solution.

## Solution 1

By implementing an UserDTOBuilder we can make a cleaner code when creating an UserWebDTO. This Builder leverages
method chaining for setting each field of the Builder.

## Solution 2

Aside from the previously described solution, one can implement the Builder inside the UserWebDTO class. This 
implementation is more common than the first one used.