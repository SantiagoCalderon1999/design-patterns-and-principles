# Null Object

Null Object pattern represents an absence of object. By using this design pattern, we can provide an alternate 
representation to indicate an absence of an object, instead of making every value null in the object. A null object
does nothing and stores nothing when an operation is called on it.

## Problem

We want an instance of the Storage service that does nothing, this is a suitable use case of the Null object design pattern.

## Solution

By using Null object pattern, we can create a NullStorageService class that inherits from StorageService and
implements its methods but does absolutely nothing inside them.

