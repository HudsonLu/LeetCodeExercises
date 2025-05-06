
# 🔣 Generics & The ArrayList Class – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📘 Generics

- Java 5.0 introduced **Generics** to enable **type-safe** code.
- Generics allow **parameterized types** for classes and methods.

### Syntax Example
```java
class Box<T> {
    T item;
    void set(T item) { this.item = item; }
    T get() { return item; }
}
```

---

## 🧰 ArrayList Class

- Part of `java.util` package.
- Unlike arrays, **ArrayLists are resizable**.
- Base type of an ArrayList must be a **class type**.

### Syntax
```java
ArrayList<String> list = new ArrayList<String>();
```

---

## ➕ Adding & Modifying Elements

| Method | Description |
|--------|-------------|
| `add(element)` | Adds to next available index |
| `add(index, element)` | Inserts at index, shifts remaining |
| `set(index, element)` | Replaces element at index |
| `get(index)` | Retrieves element |
| `size()` | Returns number of stored elements |

### Example
```java
list.add("A");
list.set(0, "B");
String s = list.get(0);
```

---

## 📊 Conversion: ArrayList ↔ Array

```java
Object[] arr = list.toArray();
String[] sArr = list.toArray(new String[0]);
```

---

## 🌀 For-Each Loop

```java
for (String s : list) {
    System.out.println(s);
}
```

---

## 📩 Passing as Parameters

```java
public void printList(ArrayList<String> list) { ... }
```

---

## 🧠 Memory Tip: trimToSize

- Reduces internal capacity to fit actual size.
```java
list.trimToSize();
```

---

## ⚠️ Pitfall: clone() Makes a Shallow Copy

- Must implement **deep copy** manually if needed.

```java
ArrayList<Car> deepCopy = new ArrayList<>();
for (Car c : originalList)
    deepCopy.add(new Car(c));
```

---

## ⚖️ Vector vs ArrayList

| Feature | Vector | ArrayList |
|---------|--------|-----------|
| Thread Safe | ✅ | ❌ |
| Preferred Today | ❌ | ✅ |

---

## 📦 Generic Class

```java
class Sample<T> {
    T data;
    void set(T value) { data = value; }
    T get() { return data; }
}
Sample<String> s = new Sample<>();
```

- Generics work with **reference types only** (not primitives).

---

## ⚠️ Pitfalls with Generics

- Cannot use `new T()`, `T[]` directly.
- Cannot create generic exceptions.
- Cannot use generics as array base type:
```java
Pair<String>[] a = new Pair<String>[10]; // ❌ not allowed
```

---

## 🧬 Generic Wildcards

| Wildcard | Description |
|----------|-------------|
| `<?>` | Unknown type |
| `<? extends T>` | Subtype of T (read-only) |
| `<? super T>` | Supertype of T (write-safe) |

---

## 🔒 Bounds on Type Parameters

```java
class RClass<T extends Comparable> { ... }
```

- Multiple bounds: one class + multiple interfaces.
```java
class Two<T1 extends Class1, T2 extends Class2 & Comparable> { ... }
```

---

## 🧮 Generic Methods

```java
public static <T> T getMiddle(T[] a) { return a[a.length/2]; }
```

- Type parameter is declared before return type.

---

## 🧱 Inheritance with Generic Classes

- Subclass can extend a generic superclass.
- `G<A>` and `G<B>` are unrelated even if `A` is superclass of `B`.

```java
class Gen<T> { ... }
class SubGen<T> extends Gen<T> { ... }
```

---

## ✅ Summary Table

| Concept               | Key Notes |
|------------------------|-----------|
| Generics               | Type-safe, reusable code |
| ArrayList              | Dynamic array with utility methods |
| clone()                | Makes shallow copy |
| trimToSize             | Reduces memory |
| For-each               | Iterates over elements |
| Wildcards              | For flexible type handling |
| Bounds & Constraints   | Limit types using `extends` |
| Generic Method         | Uses its own `<T>` parameter |

---
