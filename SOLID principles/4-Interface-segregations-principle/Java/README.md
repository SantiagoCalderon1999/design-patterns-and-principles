# I -> Interface segregation principle

The Interface segregation principle states that clients should not be forced to depend
upon interfaces that they do not use

## Problem

In the code you can see that the PersistenceService includes a findByName method. At this
particular moment, it is not causing any issue. However, if one would like to add an
OrderPersistenceService, it wouldn't be possible to use that interface, as the Order 
Entity does not have any name.

## Solution

In order to fix this issue, the findByName method should be completely removed from the
PersistenceService interface. Since the UserPersistenceService is the only class using this
method, it is only necessary to add this method in that one class. Nevertheless, if there
were any other class that implements a findByName method, it would be needed to create an
interface, and implement that interface in both of those classes.