# Observer

By using Observer we can notify multiple objects whenever an object changes state.
It is also called pub-sub or publisher-subscriber. A good application case would be that
in which onne needs to notify users about a new song release.

## Problem

We want a discount service that is used whenever the price surpasses a certain range.
We also would like to include a ShippingCost service that changes the shipping cost based on how many
products are included in the Order.

## Solution

The observer allows to notify tha ShippingCost service and the Discount service for any change in the order.