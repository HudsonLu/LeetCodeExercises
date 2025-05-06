
# 📘 Queues – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 The Queue ADT

- **FIFO (First In, First Out)** structure.
- Basic operations:
  - `enqueue(obj)`: add element to rear
  - `dequeue()`: remove and return front element

### Auxiliary operations:
- `front()`: return front element without removing
- `size()`: return number of elements
- `isEmpty()`: check if queue is empty

### Exceptions:
- `dequeue()` or `front()` on empty queue → `EmptyQueueException`

---

## 🔄 Example Sequence

| Operation         | Output | Queue Contents |
|------------------|--------|----------------|
| enqueue(5)       | —      | [5]            |
| enqueue(3)       | —      | [5, 3]         |
| dequeue()        | 5      | [3]            |
| enqueue(7)       | —      | [3, 7]         |
| dequeue()        | 3      | [7]            |
| front()          | 7      | [7]            |
| dequeue()        | 7      | []             |
| dequeue()        | error  | []             |
| enqueue(9)       | —      | [9]            |
| isEmpty()        | false  | [9]            |
| size()           | 1      | [9]            |
| dequeue()        | 9      | []             |

---

## 💡 Applications of Queues

- Waiting lists, printer queues, task scheduling
- Multiprogramming in OS
- Intermediate structure in algorithms & data structures

---

## 🧮 Array-based Queue (Circular Array)

- Uses a fixed-size array Q[0...N-1].
- Variables `f` (front) and `r` (rear) track position.
- Wraps around using modulo: `(index) mod N`
- Queue holds **N - 1** elements max.

### Key Operations

```java
size() → ((N - f) + r) mod N
isEmpty() → f == r

enqueue(o)
  if size() == N - 1 → throw FullQueueException
  Q[r] = o
  r = (r + 1) % N

dequeue()
  if isEmpty() → throw EmptyQueueException
  o = Q[f]
  f = (f + 1) % N
  return o
```

---

## 🧪 Java Queue Interface (custom)

```java
public interface Queue<E> {
  int size();
  boolean isEmpty();
  E front() throws EmptyQueueException;
  void enqueue(E element);
  E dequeue() throws EmptyQueueException;
}
```

- Java has a built-in `Queue` interface but different from this one.

---

## 🔁 Round Robin Scheduling

- Use a queue Q to schedule jobs cyclically.

```java
while (!Q.isEmpty()) {
  e = Q.dequeue();
  service(e);
  Q.enqueue(e);
}
```

---

## 📈 Growable Array-Based Queue

- If full, replace with a larger array.
- **Amortized Complexity**:
  - Incremental strategy: O(n)
  - Doubling strategy: **O(1)**

---

## ⏮️ Double-Ended Queues (Deque)

- Insertions and deletions from both ends.

### Operations

- `addFirst(e)`: Insert at head
- `addLast(e)`: Insert at tail
- `removeFirst()`: Remove from head
- `removeLast()`: Remove from tail
- Other: `getFirst()`, `getLast()`, `size()`, `isEmpty()`

### Example

| Operation         | Output | Deque Contents       |
|------------------|--------|----------------------|
| addFirst(3)      | —      | [3]                  |
| addFirst(5)      | —      | [5, 3]               |
| removeFirst()    | 5      | [3]                  |
| addLast(7)       | —      | [3, 7]               |
| addLast(9)       | —      | [3, 7, 9]            |
| addLast(12)      | —      | [3, 7, 9, 12]        |
| addFirst(8)      | —      | [8, 3, 7, 9, 12]     |
| removeLast()     | 12     | [8, 3, 7, 9]         |
| removeFirst()    | 8      | [3, 7, 9]            |
| isEmpty()        | false  | [3, 7, 9]            |
| addFirst(6)      | —      | [6, 3, 7, 9]         |
| size()           | 4      | [6, 3, 7, 9]         |

---
