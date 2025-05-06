
# 📘 Ordered Maps & Dictionaries – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Ordered Maps & Binary Search
- Ordered Map Operations & Performance
- Dictionary ADT
- List-Based & Hash-Based Dictionaries
- Search Tables

---

## 🗂️ Ordered Maps

- Extends the basic **Map** by maintaining keys in **sorted order**.
- Assumes a **total order** on keys (via comparator).

### Additional Methods:
- `firstEntry()`: Entry with smallest key
- `lastEntry()`: Entry with largest key
- `floorEntry(k)`: Largest key ≤ k
- `ceilingEntry(k)`: Smallest key ≥ k

---

## 🔍 Binary Search in Ordered Maps

- Binary search supports:
  - `get(k)`, `floorEntry(k)`, `ceilingEntry(k)`
- Search time: **O(log n)** using sorted array-based sequence.

---

## ⏱️ Performance of Ordered Maps

| Operation       | Time Complexity |
|----------------|------------------|
| get, floor, ceiling | O(log n) |
| put             | O(n) (shift items) |
| remove          | O(n) (shift items) |

- Best when **reads dominate**, and **writes are rare**.
- Suitable for small maps or read-heavy workloads.

---

## 📚 Dictionary ADT

- Stores **key-value entries** like Map.
- **Difference**: allows **duplicate keys**.

### Example:
Like an English dictionary with multiple definitions per word.

---

## 📋 Dictionary ADT Methods

| Method        | Description |
|---------------|-------------|
| `get(k)`      | Return any one entry with key `k` (or null) |
| `getAll(k)`   | Return **all entries** with key `k` |
| `put(k, v)`   | Add `(k, v)` to dictionary |
| `remove(e)`   | Remove the entry `e` |
| `entrySet()`  | All entries |
| `size()`, `isEmpty()` | Size and emptiness check |

---

## 🔁 Dictionary Example

| Operation         | Output     | Dictionary Contents                   |
|------------------|------------|---------------------------------------|
| put(5,A)          | (5,A)      | (5,A)                                 |
| put(7,B)          | (7,B)      | (5,A), (7,B)                          |
| put(2,C)          | (2,C)      | (5,A), (7,B), (2,C)                   |
| put(8,D)          | (8,D)      | (5,A), (7,B), (2,C), (8,D)            |
| put(2,E)          | (2,E)      | (5,A), (7,B), (2,C), (8,D), (2,E)     |
| get(2)            | (2,C)      | same                                  |
| getAll(2)         | (2,C),(2,E)| same                                  |
| remove(get(5))    | (5,A)      | (7,B), (2,C), (8,D), (2,E)            |

---

## 📄 List-Based Dictionary

- Items stored in a sequence (e.g., doubly linked list).
- Unordered.

### Performance:

| Operation | Time     |
|-----------|----------|
| put       | O(1)     |
| get/remove| O(n)     |

- Best for small dictionaries or when **inserts dominate**.

---

## 🧮 Dictionary Algorithms

### getAll(k)
```pseudo
Create empty list L
for e in dictionary D:
  if e.key == k:
    L.add(e)
return L
```

### put(k, v)
```pseudo
Create entry (k, v)
Add to end of sequence S
Return entry
```

### remove(e)
```pseudo
for position p in S:
  if p.element == e:
    S.remove(p)
    return e
return null
```

---

## 🧰 Hash Table Dictionary

- Use **separate chaining** at each cell (list-based dictionary).
- Performance: **O(1)** for all operations (expected).

---

## 📈 Search Table Dictionary

- Dictionary implemented via **sorted array**.
- Use **binary search** for lookups.

### Performance:

| Operation | Time     |
|-----------|----------|
| get       | O(log n) |
| put/remove| O(n)     |

- Best when **search dominates**.

---
