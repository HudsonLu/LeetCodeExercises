
# 🔗 Linked Data Structures – Part A Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Introduction to Linked Structures
- Node & Link Concept
- Linked List Construction & Traversal
- Head Node, Null References
- Add/Delete Operations
- Copy Constructors & clone()
- Privacy Leaks & Inner Classes
- Iterators and Usage
- Generic Linked Lists (Node<T>)
- Doubly Linked Lists

---

## 🧱 Linked Data Structures

- Nodes connected by references (links).
- Each node contains **data** and a **reference** to the next node.
- Links act like arrows pointing to the next node.

---

## 🧩 Linked List Basics

- **Head node**: first node.
- **Tail node**: ends with a `null` link.
- An empty list → `head == null`.
- Traversal starts at `head`, proceeds via `link` until `null`.

---

## 🧪 Creating and Using Nodes

```java
class Node {
    private String data;
    private Node link; // Reference to next node
}
```

- Each node object holds data and a link to another node.
- The list object contains a **head** reference.

---

## ➕ Adding a Node at Start

```java
Node newNode = new Node(data, head);
head = newNode;
```

- Makes the new node the new head.

---

## ❌ Deleting Head Node

```java
head = head.link;
```

- Deletes first node by bypassing it.
- Unreferenced node → auto collected (Java GC).

---

## 🧬 Copy Constructor & clone()

- Simple copy → **shallow copy**.
- Deep copy requires manual implementation.
- Inner Node class helps prevent privacy leaks.

---

## 🔐 Privacy Leak

- If accessor returns a `Node`, outer code can modify internals.
- Solution: make `Node` a **private inner class**.

---

## 🔁 Traversal

```java
Node position = head;
while (position != null) {
    // process position.data
    position = position.link;
}
```

---

## ➕ Adding & ❌ Deleting in Middle

- Use **iterator** variables: `position` and `previous`.
```java
previous.link = position.link; // delete
Node temp = new Node(newData, position);
previous.link = temp;         // insert
```

---

## 🔁 Doubly Linked Lists

- Each node has:
```java
TwoWayNode {
    String item;
    TwoWayNode next;
    TwoWayNode previous;
}
```
- Allows traversal in both directions.

---

## 🧪 Generic Linked List

```java
class Node<T> {
    private T data;
    private Node<T> link;
}
```

- Enables use of any object type.
- `Node<T>` must be used, not just `Node`.

### Pitfalls:
- `clone()` is protected → work around using bounded type parameters.

---

## ⚠️ clone() Issues

- `clone()` is protected in `Object`, so `T` must extend a custom interface like `Cloneable2`.

---

## 🚨 Exception Handling in Lists

- For null copy constructors → throw `NullPointerException`.

---

## 🔁 Iterators

### Custom Iterators:
- Must implement: `restart()`, `hasNext()`, `next()`.

```java
LinkedList.ListIterator i = list.iterator();
while (i.hasNext()) {
    System.out.println(i.next());
}
```

- Java also provides `Iterator` interface.

---

## ✅ Summary

| Concept               | Key Notes |
|------------------------|-----------|
| Node + Link            | Basic unit of linked structures |
| Head = null            | Empty list |
| Garbage Collection     | Auto in Java |
| Inner Class Node       | Prevents leaks |
| Deep Copy              | Manual implementation needed |
| Generic Linked List    | Use Node<T> not Node |
| Iterator               | Controlled traversal |
| Doubly Linked List     | Has previous and next links |

---
