# State

The State design pattern allows our objects to behave differently based on its current internal state. 
This pattern defines specific behaviours in classes. Aside from that, it is important to note that state
transitions can be triggered by states themselves.

## Problem

We want to implement a service for handling the cancellation of a product in different delivery states. By
implementing the State design pattern one would avoid a long list of if-else based on the state.

## Solution

Initially, there is an OrderState interface which will be implemented for each state of the order-product.
This state handle differently the order cancellation. Hence, every time an order is in a different states,
the cancellation instruction will be handled differently.