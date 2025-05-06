
# 📘 Stacks – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Abstract Data Types (ADTs)

- An **ADT** is defined by:
  - Data stored
  - Operations available
  - Error conditions
- Examples include stacks, queues, and lists.

---

## 🧱 The Stack ADT

- **LIFO (Last In, First Out)** structure.
- Basic operations:
  - `push(obj)`: insert element
  - `pop()`: remove and return top element
  - `top()`: return top element without removing it
  - `size()`: number of elements
  - `isEmpty()`: checks if empty

---

## 📦 Java Stack Class

- Java provides `java.util.Stack`
- Methods: `push`, `pop`, `peek`, `empty`, `size`
- Throws `EmptyStackException` if invalid operations are attempted

---

## ⚠️ Exceptions

- Pop or top on an empty stack throws `EmptyStackException`.
- Exception is said to be “thrown”.

---

## 💡 Applications of Stacks

- Web browsing history (back button)
- Undo sequence in editors
- Java method call stack (recursion)
- Expression evaluation
- HTML tag matching
- Stock span problem

---

## 🔁 Method Stack in JVM

- JVM uses stack for managing method calls.
- Each method call pushes a frame with local variables & return data.
- Frame is popped once the method completes.

---

## 🧮 Array-based Stack

- Stack implemented using an array.
- `top` tracks the last element.
- **Limitations**:
  - Fixed size unless dynamically resized.
  - FullStackException may be thrown.

---

## ⏱️ Performance

| Operation | Time Complexity |
|-----------|------------------|
| push      | O(1)             |
| pop       | O(1)             |
| top       | O(1)             |
| size      | O(1)             |
| isEmpty   | O(1)             |

- Space: O(n)

---

## 🔄 Linked List Stack

- Eliminates fixed-size issue.
- Dynamic memory allocation.

---

## ✅ Example: Reverse Array using Stack

```java
public static <E> void reverse(E[] a) {
    Stack<E> s = new ArrayStack<>(a.length);
    for (E element : a) s.push(element);
    for (int i = 0; i < a.length; i++) a[i] = s.pop();
}
```

- Time: O(n)
- Space: O(n)

---

## 🧮 Parentheses Matching

- Each open symbol `(`, `{`, `[` must match a close symbol `)`, `}`, `]`.

```java
Algorithm ParenMatch(X, n):
  for each symbol in X:
    if open, push to stack
    if close, pop and check match
  return true if stack is empty
```

---

## 🌐 HTML Tag Matching

- Same principle as ParenMatch.
- Every `<name>` should match `</name>`.

---

## ➗ Arithmetic Expression Evaluation

- Use **two stacks**:
  - `valStk` for values
  - `opStk` for operators
- Respect **precedence** and **associativity**
- Use helper algorithms: `doOp()` and `repeatOps()`

---

## 📈 Stock Span Problem

- Span of `X[i]`: max number of consecutive elements before `X[i]` ≤ `X[i]`
- Stack-based algorithm: O(n)

---

## 🆚 Array Growth Strategies

### Incremental Strategy
- Add fixed number `c` each time full
- Amortized cost: O(n)

### Doubling Strategy
- Double size when full
- Amortized cost: **O(1)** per push

---

## 📌 Final Notes

| Feature                     | Array Stack         | Linked List Stack     |
|----------------------------|----------------------|------------------------|
| Size flexibility           | Fixed unless resized | Dynamic                |
| Memory usage               | May waste space      | Efficient              |
| Performance (avg)          | O(1) operations      | O(1) operations        |
| Grow strategy (doubling)   | O(1) amortized       | Not needed             |

---
