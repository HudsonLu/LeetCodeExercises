
# 🧬 Polymorphism – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- OOP Principles: Encapsulation, Inheritance, Polymorphism
- Method Overriding & Dynamic Binding
- Static Methods and Binding Pitfalls
- Upcasting, Downcasting, and `instanceof`
- `final` Methods and Classes
- Clone Method & Copy Constructors
- Abstract Classes and Methods

---

## 🔁 What is Polymorphism?

- Polymorphism = many forms.
- Allows **multiple meanings** for a **single method name**.
- Achieved through **late binding** (a.k.a. dynamic binding).

### Example:
```java
Vehicle v = new Bus();
v.display(); // Calls Bus's display() if overridden
```

---

## 🔗 Binding Types

| Type        | When it Happens | Applies to                    |
|-------------|------------------|-------------------------------|
| Early       | Compile-time     | `private`, `static`, `final` methods |
| Late (dynamic) | Runtime       | Overridden public/protected methods |

---

## ⚠️ Pitfall: Static Methods

- Static methods are **not polymorphic**.
- They use the **type of the reference variable**, not the object.

```java
Vehicle v1 = new Bus();
v1.DisplayNumberOfCreatedObjects(); // Uses Vehicle's method
```

---

## 🔐 Final Modifier

- `final` **method**: cannot be overridden.
- `final` **class**: cannot be extended.

```java
public final class Car { ... }
public final void print() { ... }
```

---

## 🔄 Upcasting and Downcasting

### Upcasting:
```java
Vehicle v = new Bus(); // Always safe
```

### Downcasting:
```java
Bus b = (Bus)v; // Unsafe without instanceof check
```

### Use `instanceof`:
```java
if (v instanceof Bus) {
  Bus b = (Bus)v;
}
```

---

## 🧬 clone() Method

- Inherited from `Object`, should be **overridden**.
- Used to make **deep copies** of objects.

### Example:
```java
public Vehicle clone() {
  return new Vehicle(this);
}
```

- Uses **copy constructor** for cloning logic.

### Covariant Return:
- Overriding `clone()` can return subtype (e.g., `Vehicle` or `Bus` instead of `Object`).

---

## 🚫 Abstract Classes & Methods

### Abstract Class
- Cannot be instantiated.
- Must be extended by concrete subclasses.

### Abstract Method
```java
public abstract double getPrice(); // No body
```

- Must be implemented by non-abstract subclasses.

---

## 🧱 Abstract Class Rules

| Rule                                 | Allowed? |
|--------------------------------------|----------|
| Abstract method in abstract class    | ✔️       |
| Abstract class with no abstract methods | ✔️    |
| Constructor for abstract class       | ✔️ (used via `super`) |
| Instance of abstract class           | ❌       |

---

## ✅ Summary

| Concept             | Key Idea                                       |
|---------------------|------------------------------------------------|
| Polymorphism        | Same method name behaves differently by type  |
| Late Binding        | Determines method at runtime                   |
| Static Binding      | Early decision based on reference type         |
| Final Methods       | Can't be overridden                            |
| `instanceof`        | Ensures safe downcasting                       |
| Clone & Copy        | Enable deep copies using override              |
| Abstract Class      | Template base class with unimplemented methods |

---
