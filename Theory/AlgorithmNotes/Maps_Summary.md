
# 🗺️ Maps – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Map ADT (Abstract Data Type)
- List-based Map Implementation
- get, put, remove Algorithms
- Performance of List-Based Maps
- Applications of Maps

---

## 🗂️ What is a Map?

- A **Map** is a collection of **key-value entries**.
- Keys are **unique**, and each maps to **one value**.
- Primary operations: **searching**, **inserting**, **deleting**.

### Applications:
- Address book
- Student-record database

---

## 🧾 Map ADT – Core Methods

| Method        | Description |
|---------------|-------------|
| `get(k)`      | Returns value for key `k`, or null if not found |
| `put(k, v)`   | Adds or updates entry for key `k` with value `v` |
| `remove(k)`   | Deletes entry for key `k`, returns its value |
| `entrySet()`  | Returns all key-value pairs |
| `keySet()`    | Returns all keys |
| `values()`    | Returns all values |
| `size()`      | Returns number of entries |
| `isEmpty()`   | Checks if map is empty |

---

## 🔄 Example Map Operations

| Operation      | Output | Map Contents                     |
|----------------|--------|----------------------------------|
| isEmpty()      | true   | Ø                                |
| put(5, A)      | null   | (5, A)                           |
| put(7, B)      | null   | (5, A), (7, B)                   |
| put(2, C)      | null   | (5, A), (7, B), (2, C)           |
| put(8, D)      | null   | (5, A), (7, B), (2, C), (8, D)   |
| put(2, E)      | C      | (5, A), (7, B), (2, E), (8, D)   |
| get(7)         | B      |                                  |
| get(4)         | null   |                                  |
| get(2)         | E      |                                  |
| size()         | 4      |                                  |
| remove(5)      | A      | (7, B), (2, E), (8, D)           |
| remove(2)      | E      | (7, B), (8, D)                   |
| get(2)         | null   |                                  |
| isEmpty()      | false  | (7, B), (8, D)                   |

---

## 📄 List-Based Map

- Implemented using **unsorted doubly-linked list**
- Items stored in arbitrary order

---

## 🔍 get(k) Algorithm

```pseudo
Algorithm get(k):
  for each position p in list:
    if p.element().key == k:
      return p.element().value
  return null
```

---

## ➕ put(k, v) Algorithm

```pseudo
Algorithm put(k, v):
  for each position p in list:
    if p.element().key == k:
      oldVal = p.element().value
      p.element = (k, v)
      return oldVal
  addLast((k, v))
  size++
  return null
```

---

## ➖ remove(k) Algorithm

```pseudo
Algorithm remove(k):
  for each position p in list:
    if p.element().key == k:
      val = p.element().value
      remove(p)
      size--
      return val
  return null
```

---

## 📉 Performance Analysis

| Operation | Time Complexity |
|-----------|------------------|
| `get(k)`  | O(n)             |
| `put(k,v)`| O(n)             |
| `remove(k)`| O(n)            |

- Worst case: traverse entire list
- **Unsorted list** works best for **small maps** only

---
