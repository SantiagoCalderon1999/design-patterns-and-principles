# Proxy

We use Proxy when we need to provide a placeholder to another object.

## Problem

We want to create an Image, however we want to perform many operations before
actually rendering the image in screen. Rendering the image in the first place
would pose a high load on the computer.

## Solution

By implementing the Proxy design pattern we can create
an ImageProxy object that performs operation that are not 
computationally expensive. When we definitely need to render the real BitmapImage object,
we can just create it and make the rendering operations.

This approached can be done completely manually or by using Java InvocationHandler.