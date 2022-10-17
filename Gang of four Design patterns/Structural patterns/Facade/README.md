# Facade

We use a facade when we want to interact with a larger number of interfaces. It provides a simplified interface to a library
or framework.

## Problem

In the code we have a broad set of objects related to emails. Ordinarily, you’d need to initialize all of those
objects, keep track of dependencies, execute methods in the correct order, and so on. This poses a great issue as 
it makes harder to use our library.

## Solution

We implement an EmailFacade that provides a simple interface to a complex subsystem which contains lots of moving parts. 
A facade might provide limited functionality in comparison to working with the subsystem directly. However, the 
client only needs to send an order email and this facade gets the job done.