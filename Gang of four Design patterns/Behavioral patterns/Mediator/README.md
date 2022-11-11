# Mediator

Mediator encapsulates how a set of objects interact with each other. This leads to loose coupling.
In this pattern, an object only knows about the mediator, not the object it is interacting with. 
By using this design pattern, the interaction can now change without needing modifications in participating
objects.

## Problem

We have a Slider, a text box and a label. The main idea is to change the value displayed by the label and the
text box when the value of the slider is changed. We could be tempted to include a reference of the text box and
the label in the slider, however this leads to tightly coupled code.

## Solution

We can implement the Mediator pattern as the slider will only know about the Mediator and not the other
classes to which it is passing values. By implementing this pattern, we can create other classes for
displaying data easily since the code is loosely coupled.