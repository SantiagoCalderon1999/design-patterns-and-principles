# D -> Dependency inversion principle

The dependency inversion principle is divided in two statements:
* High level modules should not depend upon low level modules. Both should depend upon abstractions.
* Abstractions should not depend upon details. Details should depend upon abstractions.

## Problem

In the code you can see that the writeMessage method inside the MessagePrinter class
is tightly coupled with the writer and the formatter. If one needs to create another type of file
it would be necessary to change the writeMessage, which is a violation of the single
responsibility principle.

## Solution

In order to fix this issue, the writer and formatter are passed as parameters to 
the writeMessage function inside the MessagePrinter class. This leads to a loosely 
coupled code and avoids the violation of the single responsibility principle.