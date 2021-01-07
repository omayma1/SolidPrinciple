This Repository contains a simple explanation examples about the SOLID Principles.
# SOLID PRINCIPLES
SOLID are five design principles of Object-Oriented-Programs that aim to build applications with:

        clean
        
        readable,
        
        adaptable,
        
        testablity,
        
        and scalable Code.
        

The intention of these principles is to make software designs more understandable, easier to maintain and easier to extend.

Solid code makes solid business for long term.

# Single Responsibility Principle
Classes should have one and only  responsibility. So that ,it has :

       One reason to be changed which can only change its single reponsibiliy,

       We need to read one class to understnad its functionality.

This principle is going to be a vital key for easier changes. And if you break something, you break one thing (or fewer), not an entire system.

# Open And Closed Principle

Software should be open for extension but closed for modification.
In this principle we can apply an important component of the OOP which is polymorphisme:
      
      Extend the parent entity to suit the needs of the child entity while leaving the parent intact.

# Liskov Substitution Principle

It's about any class must be directly replacable by any of its subclass without errors.

# Interface Segregation Principle

Classes only be able to perform behaviours that are useful to achieve its end functionnality
Split interfaces to not forcing classes to handle what they don’t need, they need less code.
         
                    Less code, fewer problems, closer deadlines.

# Dependency Inversion Principle

One should depend upon abstraction not concretion.
High level class must not depend upon a lower level class.Both must depend uponabstraction .And an abstraction must not depend details but the details must depend upon abstraction.
For example an object B cannot inherits directly from an another object A .Instead ,B inhert from the interface of A ,and object A can be reference type of the interface A.
