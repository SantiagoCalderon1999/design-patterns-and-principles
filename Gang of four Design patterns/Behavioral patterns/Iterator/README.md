# Iterator

Iterator allows a way to access elements/children of an object in sequence while hiding the internal data structure used.
This pattern is not often used as Iterators are an integral part of collection frameworks. It is important to mention
that iterators cannot get the next value of a data structure if the content and size itself is changed.

This pattern is useful in data structures such as a tree, because this data structure does not have a single way
of traversing, thus many iterators can be created for each different way od traversing the tree.

## Problem

In the code we have an enum containing many values. We wish to iterate over this data structure without 
showing explicitly how we are doing it.

## Solution

By implementing an iterator we can iterate over the enum without exposing its underlying representation.