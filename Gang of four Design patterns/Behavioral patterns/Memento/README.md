# Memento

Memento is implemented when it is desired to store an object's state without exposing internal details about
the state. This pattern is usually combined with Command to provide "undo" functionality.

## Problem

We have a Workflow for handling a leave application in the company. Nevertheless, we would like to roll back
any changes that are made in the Workflow. In the code we implement the Command pattern for representing
the actions of adding and removing a step to the Workflow.

## Solution

By implementing the Memento pattern we can store the state of the Workflow before applying an action. In the
case that we need to undo an action, we would have to fetch the Memento object stored with the applied action.
The Memento class is created inside the Workflow designer as private class because we don't want to provide access
for the stored object to other parts of the code.