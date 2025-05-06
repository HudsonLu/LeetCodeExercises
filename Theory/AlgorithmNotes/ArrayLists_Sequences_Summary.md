
# 📘 Array Lists, Node Lists & Sequences – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Array Lists
- Node Lists
- Sequences
- Sequence Implementations (Linked List vs Array-based)
- Favorites List ADT

---

## 📦 Array List ADT

- Stores a **sequence of arbitrary objects**
- Elements accessed by **index**
- Exceptions for invalid indices

### Core Methods:
- `get(i)` – returns element at index `i`
- `set(i, o)` – replaces element at index `i` with `o`
- `add(i, o)` – inserts `o` at index `i`
- `remove(i)` – removes and returns element at `i`
- `size()`, `isEmpty()`

---

## ⚙️ Array-based Implementation

- Uses array `A` of size `N` and counter `n`
- `get(i)` and `set(i, o)` – O(1)
- `add(i, o)` and `remove(i)` – O(n)

### Dynamic Resize:
- **Incremental**: Increase size by constant `c` → O(n²)
- **Doubling**: Double array size → O(n), amortized O(1)

---

## 🧮 Array List → Deque Adapter

| Deque Operation | Realized by Array List Method |
|------------------|-------------------------------|
| `addFirst(e)`    | `add(0, e)`                   |
| `addLast(e)`     | `add(size(), e)`              |
| `removeFirst()`  | `remove(0)`                   |
| `removeLast()`   | `remove(size() - 1)`          |
| `getFirst()`     | `get(0)`                      |
| `getLast()`      | `get(size() - 1)`             |

---

## 🔗 Node List ADT

- Elements accessed by **position**, not index.
- Avoids leaking pointers → uses `Position` ADT

### Position ADT Method:
- `element()` – returns stored element

### Node List Methods:
- Navigation: `first()`, `last()`, `next(p)`, `prev(p)`
- Insert: `addFirst(e)`, `addLast(e)`, `addBefore(p, e)`, `addAfter(p, e)`
- Modify: `set(p, e)`, `remove(p)`

---

## 🔁 Node List → Deque Adapter

| Deque Operation | Node List Method |
|------------------|------------------|
| `addFirst(e)`    | `addFirst(e)`    |
| `addLast(e)`     | `addLast(e)`     |
| `removeFirst()`  | `remove(first())`|
| `removeLast()`   | `remove(last())` |
| `getFirst()`     | `first().element()` |
| `getLast()`      | `last().element()`  |

---

## 🔁 Sequence ADT

- Combines **Array List** and **Node List** functionalities
- Supports both index- and position-based access

### Bridging Methods:
- `atIndex(i)` – returns position at index `i`
- `indexOf(p)` – returns index of position `p`

---

## 🧪 Sequence Implementations

### Linked List:
- Position-based ops: O(1)
- Index-based ops: O(n)

### Optimization:
- `get(i)` from nearest end → O(min(i+1, n-i))

### Array-based:
- Position updates required on insert/delete → O(n)
- Other methods → O(1)

---

## 📊 Performance Comparison

| Operation         | Array List | Node List |
|------------------|------------|-----------|
| `size`, `isEmpty`| O(1)       | O(1)      |
| `get(i)`         | O(1)       | O(n)      |
| `set(i, e)`      | O(1)       | O(n)      |
| `add(i)`         | O(n)       | O(n)      |
| `remove(i)`      | O(n)       | O(n)      |
| `addFirst`       | O(n)       | O(1)      |
| `addLast`        | O(1)       | O(1)      |
| `addAfter`       | O(n)       | O(1)      |
| `remove(p)`      | O(n)       | O(1)      |

---

## ⭐ Favorites List ADT

- Tracks most frequently accessed elements

### Key Methods:
- `access(e)` – increments count of `e`
- `remove(e)` – removes `e`
- `top(k)` – returns list of top-k accessed elements

### Applications:
- Web browser history (most visited)
- UI: most used buttons in menu

---
