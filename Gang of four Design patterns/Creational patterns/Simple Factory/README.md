# Simple Factory

Simple Factory pattern is useful when multiple types can be instantiated based on some simple criteria.

## Problem

We have NewsPost, ProductPost and BlogPost classes and we want to create objects of these classes based on a string.

## Solution

By implementing a PostFactory (SimpleFactory), one can leverage a static class for creating objects of every desired
class based on a string. In the case that the string is not correct, an exception is thrown.