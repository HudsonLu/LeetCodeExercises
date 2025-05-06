
# 📘 Linked Lists & Iterators – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Singly Linked Lists
- Doubly Linked Lists
- Circularly Linked Lists
- Iterators

---

## 🔗 Singly Linked List

- Sequence of nodes with:
  - `element`
  - `next` reference

### Node Class Example

```java
public class Node {
  private Object element;
  private Node next;

  public Node() { this(null, null); }
  public Node(Object e, Node n) { element = e; next = n; }

  public Object getElement() { return element; }
  public Node getNext() { return next; }
  public void setElement(Object newElem) { element = newElem; }
  public void setNext(Node newNext) { next = newNext; }
}
```

---

## 🧱 Operations on Singly Linked Lists

### Inserting at Head
1. Allocate new node
2. Set its next to old head
3. Update head

### Removing at Head
- Update head to next node

### Inserting at Tail
1. Allocate new node with null next
2. Link current tail’s next to new node
3. Update tail

### Removing at Tail
- Inefficient in singly linked lists (no back reference)

---

## 📚 Stack and Queue via Singly Linked List

- **Stack**: Top at head; O(1) push/pop
- **Queue**: Front at head, rear at tail; O(1) enqueue/dequeue (with both pointers)

---

## 🔁 Doubly Linked List

- Each node contains:
  - `element`
  - `prev` and `next` pointers

- Use **header** and **trailer** sentinel nodes

### Insertion Example

```java
addAfter(p, e):
  v = new Node(e)
  v.setPrev(p)
  v.setNext(p.getNext())
  p.getNext().setPrev(v)
  p.setNext(v)
  return v
```

### Deletion Example

```java
remove(p):
  t = p.element
  p.getPrev().setNext(p.getNext())
  p.getNext().setPrev(p.getPrev())
  p.setPrev(null)
  p.setNext(null)
  return t
```

- All operations: O(1)
- Space: O(n)

---

## 🔄 Iterators

- Abstract way to traverse a collection
- Maintains a **cursor** between elements

### Methods:
- `hasNext()` – true if more elements exist
- `next()` – returns and advances to next element

### Iterable Interface

```java
interface Iterable<E> {
  Iterator<E> iterator();
}
```

- Java: snapshot vs dynamic iterators

### For-Each Loop in Java

```java
List<Car> ls;
for (Car c : ls)
  System.out.println(c);
```

---

## 🧭 ListIterator in Java

Extends `Iterator` with:
- `add(e)`, `set(e)`, `remove()`
- `hasPrevious()`, `previous()`

```java
ListIterator<String> iter = list.listIterator();
while (iter.hasNext()) {
  String val = iter.next();
  iter.set(val.toUpperCase());
}
```

---

## ✅ Final Notes

| List Type          | Insert/Remove Head | Tail | Backward Traversal |
|--------------------|--------------------|------|---------------------|
| Singly Linked List | ✅ Efficient        | ❌ Inefficient | ❌ No              |
| Doubly Linked List | ✅ Efficient        | ✅ Efficient | ✅ Yes             |
| With Iterators     | ✅                 | ✅    | ✅                 |

---
