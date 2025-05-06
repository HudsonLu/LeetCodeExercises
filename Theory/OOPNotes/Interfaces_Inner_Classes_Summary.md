
# 🧩 Interfaces & Inner Classes – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Interfaces vs Abstract Classes
- Interface Syntax and Implementation
- Multiple Inheritance via Interfaces
- Constants in Interfaces
- Pitfalls: Semantic Consistency & Conflicts
- Serializable and Cloneable Interfaces
- Inner Classes (Local, Private, Public, Static)
- Inheritance with Inner Classes
- Anonymous Inner Classes

---

## 🧪 Interfaces

### What is an Interface?
- Not a class, but a **type**
- Specifies **method signatures** and **constants**
- Implemented by any class using `implements`
- Supports **multiple inheritance** in Java

### Syntax Example
```java
public interface MyInterface {
    void method1();
    int CONSTANT = 10;
}
```

### Key Rules
- All methods are **public** and **abstract**
- All fields are **public static final**
- Java 8+ allows **default** and **static** methods

---

## 📌 Implementing Interfaces

### Basic Implementation
```java
public class MyClass implements MyInterface {
    public void method1() {
        // implementation
    }
}
```

- A class can implement multiple interfaces (comma-separated)
- Abstract classes can implement interfaces partially

### Derived Interfaces
- Use `extends` keyword
```java
interface SubInterface extends BaseInterface { ... }
```

---

## ❗ Pitfalls in Interfaces

- Interfaces **do not enforce semantics** (only syntax)
- Inconsistent interfaces may arise:
  - Same method name but **different return types**
  - **Conflicting constants** with same name

---

## 🔁 Common Interfaces

- **Serializable**: Empty tag interface (used by object streams)
- **Cloneable**: Used to control cloning behavior
  - Override `clone()` method
  - Handle shallow vs deep copying carefully

### clone() Example:
```java
public Object clone() {
    MyClass copy = (MyClass) super.clone();
    copy.mutableField = new MutableType(this.mutableField);
    return copy;
}
```

---

## 🧱 Inner Classes

### What is an Inner Class?
- Class defined **within another class**
- Can be **private**, **public**, or **static**

### Uses
- Helper class encapsulated within outer class
- Has access to outer class’s private members

### Syntax Example
```java
class Outer {
    private class Inner {
        void display() {
            System.out.println("Inner class");
        }
    }
}
```

---

## 🔄 Types of Inner Classes

| Type           | Description |
|----------------|-------------|
| Member Class   | Defined inside class but outside methods |
| Static Class   | No access to instance members of outer class |
| Local Class    | Defined within a method |
| Anonymous Class| Class without a name, defined on-the-fly |

---

## 🌐 Static Inner Classes

- Declared with `static` keyword
- Cannot access outer instance members
```java
static class Helper {
    static void doSomething() { ... }
}
```

---

## 🔍 Public Inner Classes

- Instantiated using outer class instance
```java
Outer.Inner obj = new Outer().new Inner();
```

### Static Inner Class Instantiation
```java
Outer.StaticInner obj = new Outer.StaticInner();
```

---

## 🔁 Anonymous Classes

- No name, declared & instantiated in one statement
- Typically used to implement interfaces
```java
Runnable r = new Runnable() {
    public void run() {
        System.out.println("Running");
    }
};
```

---

## ✅ Summary

| Topic                  | Key Notes |
|------------------------|-----------|
| Interface              | Declares required methods |
| Multiple Inheritance   | Achieved via interfaces |
| Constants              | Are public static final |
| Abstract + Interface   | Allowed in Java |
| Inner Class            | Defined inside outer class |
| Static Inner Class     | No access to outer instance |
| Anonymous Class        | One-time use class expression |

---
