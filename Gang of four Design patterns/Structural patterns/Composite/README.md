# Composite

When we want to treat objects uniformly in a hierarchy of objects, we use composite.
Using the Composite pattern makes sense only when the core model of your app can be
represented as a tree.

## Problem

In the code we have a Client and a File. We would like to implement a BinaryFile and Directory(Folder)
tree system. This means that all the objects can be represented as a tree, in which the leafs
are the files. Hence, using the Composite pattern would be an appropriate approach.

## Solution

We implement the Composite in which the leafs are the BinaryFiles and the Composite is the 
directory. Hence, the children the composite has can be either a directory or a file. 
Allowing this way the creation of a complex tree structure.