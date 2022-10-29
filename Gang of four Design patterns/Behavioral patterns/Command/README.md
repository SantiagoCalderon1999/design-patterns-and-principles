# Command

We implement Command when we want to represent a request or a method call as an object. It is useful for storing info
about the parameters and the operation performed. This design pattern is used when you want to schedule many
functions in a multi-threading environment.

## Problem

We want to implement many commands in a multi-threading environment. A solution would be to directly call
the desired function in the thread. Nevertheless, this solution is not good enough since it keeps a tightly coupled
code. Furthermore, it would be a challenge to implement more functions in the thread or add a function to a queue
waiting to be implemented.

## Solution

By implementing the Command design pattern, we create a Command interface that can execute any desired method in 
the thread. This way we only call the desired method and the object that execute the method we desired is
defined during runtime. This design pattern applies the Open-closed principles because the thread code is closed 
for modification (you can't add more functions in there because you don't need any) and open for extension as you can 
implement the Command interface and create as many functions as you want.