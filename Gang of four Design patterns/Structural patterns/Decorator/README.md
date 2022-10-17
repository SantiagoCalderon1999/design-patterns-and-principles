# Decorator

We use a decorator when we want to enhance behavior of our existing object dynamically.
So it basically wraps an object by adding functionality. You can leverage recursive composition
for adding many functionalities one after the other.

## Problem

In the code we have a TextMessage. However, we would like to include a HtmlEncodedMessage and a Base64EncodedMessage.
We could simply create a parent class an inherit all this messages from that one. Nevertheless, we wouldn't
be able to encode a message one after the other.

## Solution

We implement Decorators because we want to leverage recursive composition. Then we create a HmlEncodedMessage and a Base64EncodedMessage
that have an object of the Message parent class and they use it in their constructor. Hence, when these classes implement
a method, they implement the functionality of the parent class beforehand.