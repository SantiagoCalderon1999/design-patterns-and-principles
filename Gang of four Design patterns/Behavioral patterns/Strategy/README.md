# Strategy

The Strategy design pattern encapsulates an algorithm in a class. By using this pattern, we can configure our context 
with an object of this class, to change the algorithm used to perform the given operation. This design pattern is
specially helpful if you have many possible variations of an algorithm.

## Problem

We want to implement a service for bill printing. Nevertheless, we would like to have two possible options: the first one
must print the bill including every article and its price, the second one must print a general overview of the bill. 

## Solution

The Strategy design pattern is helpful in this context because we want to implement two variations of the same algorithm,
which is bill printing. Therefore, we create an OrderPrinter interface which is the abstraction of the Strategy.
After of that, we implement this interface in the DetailPrinter and SummaryPrinter classes. By doing so, we can
use any of these classes when we want to implement a variation fo the bill printing algorithm.