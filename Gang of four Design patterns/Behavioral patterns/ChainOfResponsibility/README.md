# Chain of responsibility

We use chain of responsibility for avoid coupling between code that send request and handles
requests. This pattern lets you pass along a chain of handlers.
Upon receiving a request, each handler decides either to process the request 
or to pass it to the next handler.

## Problem

We want a system that allows the approval of leave days. There are many cases in which an approver 
will approve the request. For avoiding a long list of if-else blocks, the Chain of responsibility
pattern is a perfect solution.

## Solution

By creating a Chain of responsibility, each approver can decide whether it approves the leave days or 
pass it to the successor. However, it is not guaranteed that someone will handle the request.
For instance, there may be a case in which no one can approve the leave days, in such a case
the request remains unhandled. Be aware of that!