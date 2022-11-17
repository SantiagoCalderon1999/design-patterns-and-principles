# Template

Template design pattern defines an algorithm in a method as a series of steps and provides a chance for subclasses
to redefine some of these steps. This pattern allows one to defer implementation of parts of the algorithm which can 
vary. the main difference between Strategy and Template is that in the former, each subclass defines a different 
algorithm, whereas in the latter, each subclass implements different steps for the very same algorithm.

## Problem

We want to create a bill with a different format depending on the occasion. The first format is completely
compose of text, whereas the second format includes HTML tags. We could apply the Strategy pattern,
however, since there is only one algorithm with different steps, the Template design pattern is more appropriate.

## Solution

As mentioned before, by using the Template pattern, we can define the way we implement each and every step
for the bill printing. Therefore, we have an abstract class that defines all the steps which must be
implemented by the child classes. In this case, we have two classes inheriting from that base class, which are
HtmlPrinter and TextPrinter. Another class could be added without further issue.