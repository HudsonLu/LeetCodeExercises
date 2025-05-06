| Feature                  | **Abstract Class**                                     | **Interface**                                                       |
| ------------------------ | ------------------------------------------------------ | ------------------------------------------------------------------- |
| **Purpose**              | Base class with partial implementation                 | Pure contract: only method signatures                               |
| **Methods**              | Can have both **implemented** and **abstract** methods | Only method signatures (until Java 8, now can have default methods) |
| **Fields (variables)**   | Can have instance variables (fields)                   | Only **public static final** constants                              |
| **Constructors**         | ✅ Yes                                                 | ❌ No                                                               |
| **Multiple inheritance** | ❌ No (can only extend one abstract class)             | ✅ Yes (can implement multiple interfaces)                          |
| **Access Modifiers**     | Methods can be `public`, `protected`, etc.             | Methods are implicitly `public` and `abstract`                      |
| **Usage**                | When objects share behavior (common code)              | When unrelated classes share a contract                             |

| Use This...        | When...                                                               |
| ------------------ | --------------------------------------------------------------------- |
| **Abstract Class** | You need **shared state** or **common code** across related classes   |
| **Interface**      | You need **pure abstraction**, or to support **multiple inheritance** |

```bash
# Abstract Class:
abstract class Animal {
    String name;

    Animal(String name) {
        this.name = name;
    }

    void eat() {
        System.out.println("This animal eats food.");
    }

    abstract void makeSound();
}
# Interface:
interface Flyable {
    void fly();  // no implementation
}
# A class using both:
class Bird extends Animal implements Flyable {
    Bird(String name) {
        super(name);
    }

    void makeSound() {
        System.out.println("Chirp chirp!");
    }

    public void fly() {
        System.out.println("Bird is flying");
    }
}

# Example 1
abstract class Animal {
    abstract void speak();
}

class Dog extends Animal {
    void speak() {
        System.out.println("Woof!");
    }
}

// Animal a = new Animal(); ❌ Error
Animal a = new Dog();      // ✅ Allowed

interface Flyable {
    void fly();
}
# Example 2
class Bird implements Flyable {
    public void fly() {
        System.out.println("Flying!");
    }
}

// Flyable f = new Flyable(); ❌ Error
Flyable f = new Bird();     // ✅ Allowed

```

💡 Think of Interface as a "Role":
An interface defines a role or ability (e.g., Flyable, Drivable)
but only a class can actually perform the role by implementing it.
| Reason | Example / Benefit |
| --------------------------- | -------------------------------------------------------------------------- |
| **1. Polymorphism** | Treat many different objects the same way |
| **2. Decoupling** | Code to a common interface, not specific implementations |
| **3. Multiple inheritance** | A class can implement many interfaces (Java only allows 1 class to extend) |
| **4. Enforce behavior** | Guarantee that classes provide specific methods |

## 🎭 What Is an Interface?

An interface is like a contract that says:

“If a class claims to implement me, it must provide implementations for all the methods I declare.”

But it does not care how the class does it.

🧠 Analogy:
Imagine you have a remote control interface:

```bash
interface RemoteControl {
void turnOn();
void turnOff();
}
# Now, any class that implements this interface — like a TV or an AC — must follow the remote control rules.

class TV implements RemoteControl {
public void turnOn() {
System.out.println("TV is on");
}

    public void turnOff() {
        System.out.println("TV is off");
    }

}

class AC implements RemoteControl {
public void turnOn() {
System.out.println("AC is on");
}

    public void turnOff() {
        System.out.println("AC is off");
    }

}
# Now you can write:
RemoteControl r = new TV(); # or new AC();
r.turnOn(); # You don't care _what_ r is — TV or AC — as long as it can turn on/off.
```
