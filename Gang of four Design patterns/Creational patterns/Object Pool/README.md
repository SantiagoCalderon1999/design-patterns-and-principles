# Object pool

Object Pool pattern is applicable in cases in which the cost of creating an instance of a class is high and we need
a large number of objects of this class for short duration.

## Problem

In this particular case, we emulate the loading process of a bitmap. This special object takes
a lot of time upon creation. Therefore, we want to have a pool of objects such that they are already 
created and we only need to use them.

## Solution 

By using the Object pool design pattern, one can take the object from the pool, use it, and return
it to the pool. It is important to mention that this pattern must be applied in cases in which
the object is not long-lived, otherwise it would cause performance issues. It must be considered
that the creation of these pooled objects may add-up to start up time.