# AdapterPattern

**Definition** Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

**Applicability**

Use the Adapter pattern when 

- you want to use an existing class, and its interface does not match the one you need.  
- you want to create a reusable class that cooperates with unrelated or unforeseen classes, that is, classes that don't necessarily have compatible interfaces.  
- (object adapter only) you need to use several existing subclasses, but it's impractical to adapt their interface by subclassing every one. An object adapter can adapt the interface of its parent class. 

**Consequences**

Class and object adapters have different trade-offs. A class adapter 

- adapts Adaptee to Target by committing to a concrete Adapter class. As a consequence, a class adapter won't work when we want to adapt a class and all its subclasses.  
- lets Adapter override some of Adaptee's behavior, since Adapter is a subclass of Adaptee.  
- introduces only one object, and no additional pointer indirection is needed to get to the adaptee.
  
An object adapter 

- lets a single Adapter work with many Adaptees—that is, the Adaptee itself and all of its subclasses (if any). The Adapter can also add functionality to all Adaptees at once.  
- makes it harder to override Adaptee behavior. It will require subclassing Adaptee and making Adapter refer to the subclass rather than the Adaptee itself.


**Related Patterns**

- Bridge
- Decorator
- Proxy