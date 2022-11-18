# Abstract Factory

Abstract factory is used when we have to produce two or more objects which work together forming a kit or set. This pattern
uses the Factory method pattern as a part of its implementation. 

## Problem

We want to create instances of cloud services working together, such as a virtual machine and storage. However,
we would like to use AWS and GCP for such application, and it is desired to have a class that handles the creation
of the cloud services depending on the cloud provider.

## Solution

By using the Abstract Factory design pattern, we can create a concrete Factory for each of the cloud providers.
This way, we would have a different implementation for Virtual machine instances and storage, depending
on which cloud provider is used.