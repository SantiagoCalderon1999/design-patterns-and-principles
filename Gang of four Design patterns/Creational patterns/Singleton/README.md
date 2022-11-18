# Singleton

A Singleton class is a creational pattern that ensures you that a class has one and only once instance of 
an object, while providing a global access point to this instance.

## Problem

We want to create only one instance globally of our class.

## Solution Eager

The eager implementation creates the Singleton as soon as the class is loaded. This is the easiest approach,
however is the one that must always be tried first.

## Solution Lazy Double Check Lock (DCL)

The lazy implementation creates the Singleton only when it is first required. However, a double check lock
must be implemented for avoiding that many threads create mistakenly two instances of the Singleton class.

## Solution Lazy Initialization Holder (IODH)

In contrast with DCL, the initialization holder provides us an easier way to approach the lazy loading concern by 
using an internal Holder class. This approach gives us a simpler way of creating a Lazy Singleton, while
providing thread safety.