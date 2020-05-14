## Section A
Question 1: What is a class?

An oversimplified answer is that a class is a way of organizing functionality in a code base.

Question 2: What is an interface

An interface is a way of enforcing which methods a class should contain. They are also used to pass functionality down
allowing a class to inherit functaionality from mulitipe class, which is not supported with classes in C#

Question 3: What is information hiding?

Question: 4: What is polymorphism?

Queston: 5 What is inheritance?

Inheritance is the passing down of funcitonaity to other, related classes
example: We could have a class of Car which passes down functionaity to a type of car, as in class SportsCar. SportsCar would
have access to all the properties of Car, while still being able to have it's own methods.

Question 6: What is protection level?

Protection level determines the access other methods and classes to given class or method. They can be private, protected,
public, internal, protected internal, private protected

## Section B
1 & 2 See Person.cs

3. How many constructors can a class have?

I had hoped that the answer to this was one, but I ran into problems and found out you could have as many as you wanted, but this
would be a terrible idea.

4. If not specified, what is the default protection level for a class

The default is private. 

5,6,& 7 See Person.cs

8. If not specified, what is the default protection level for a property?

Properites are private by defualt

9. What is the difference between a property and a member variable?

## Section C

    Q:  Why is it considered good design to create interfaces?

        Allows for abstraction and protection I think... Though I'm sure my implimentation is wrong

    Q:  If not specified, what is the default protection level for an interface?

        public

    Q:  If not specified, what is the default protection level for properties and methods in an interface?

        public

    Apply the interface to the Person class

## Section D

    Make this class inherit from Person 

    Make this class use the interface 

    Q:  How many classes can an implementation class inherit from?

        A class can only inherit functionality from one class

    Q:  How many interfaces can an implementation class inherit from?

        Multiple, but is this a good idea? Probably not. 

    Why is it good design to create classes which inherit from other classes? 

    Q: In design, what is the inherited-from class called? 

        Base Class

    Create a public property for Employee ID 

    Create a new method called GetWelcomeMessage.  This method will return a string which says “Good [Morning | Afternoon | Evening | Night] [First Name] [Last Name]” 

    Q: What is the default protection level of this method?

        private

    Call this method from your test app 