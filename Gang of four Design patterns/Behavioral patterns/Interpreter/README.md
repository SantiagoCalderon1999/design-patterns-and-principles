# Interpreter

We implement Interpreter when we want to process a simple language with rules and grammar. It allows us to represent 
the rules of grammar in a data structure.

## Problem

We want to implement a basic language interpreter consisting of "AND", "OR" and "NOT". This system will grant access
to users based on their corresponding roles. For instance, if the system has a rule of "ADMIN AND ACCOUNTANT", then
only the admin and the accountant will be given access.

## Solution

By implementing the Interpreter pattern we can achieve language interpretation of these sentences quite easily.
Therefore, we would need to create the AndExpression, OrExpression and OrExpression class. Either way we would have to parse
the string to this tree, that's where we use the ExpressionBuilder class. This way, we can decide whether the user
should be granted access or not.