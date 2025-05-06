
# 🗂️ Priority Queues – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Priority Queue ADT
- Total Order Relations
- Entry & Comparator ADTs
- Sorting using Priority Queues
- Selection Sort & Insertion Sort (via PQ)
- In-place Sorting

---

## 📬 Priority Queue ADT

- Stores prioritized elements `(key, value)`.
- Arbitrary **insertion**, but **removal by priority** (smallest key).

### Core Methods:
- `insert(k, x)`: Insert key-value pair
- `removeMin()`: Remove and return entry with smallest key

### Additional Methods:
- `min()`: Return smallest key entry (do not remove)
- `size()`, `isEmpty()`

### Applications:
- Auctions, stock market systems, scheduling tasks

---

## 🧮 Priority Queue Example

| Operation         | Output | Queue Contents                |
|------------------|--------|-------------------------------|
| insert(5, A)      | e1     | {(5, A)}                      |
| insert(9, C)      | e2     | {(5, A), (9, C)}              |
| insert(3, B)      | e3     | {(3, B), (5, A), (9, C)}      |
| insert(7, D)      | e4     | {(3, B), (5, A), (7, D), (9, C)} |
| min()             | e3     | unchanged                     |
| removeMin()       | e3     | {(5, A), (7, D), (9, C)}      |
| removeMin()       | e1     | {(7, D), (9, C)}              |

---

## ✅ Total Order Relations

To avoid contradiction, comparison rule (≤) must be:

- **Reflexive**: `k ≤ k`
- **Antisymmetric**: `k1 ≤ k2 ∧ k2 ≤ k1 ⇒ k1 = k2`
- **Transitive**: `k1 ≤ k2 ∧ k2 ≤ k3 ⇒ k1 ≤ k3`

---

## 🔗 Entry ADT

Stores `(key, value)` pairs. Provides:

- `getKey()` – retrieve key
- `getValue()` – retrieve value

### Java Interface:
```java
public interface Entry<K, V> {
  public K getKey();
  public V getValue();
}
```

---

## 🧮 Comparator ADT

Provides a comparison rule outside of the key.

### Core Method:
```java
int compare(a, b)
  // returns <0 if a<b, 0 if a=b, >0 if a>b
```

### Java Interface:
- `java.util.Comparator`

---

## 📍 Example Comparator – Lexicographic Order

```java
public class Lexicographic implements Comparator {
  public int compare(Object a, Object b) {
    int xa = ((Point2D) a).getX();
    int ya = ((Point2D) a).getY();
    int xb = ((Point2D) b).getX();
    int yb = ((Point2D) b).getY();
    if (xa != xb)
      return xb - xa;
    else
      return yb - ya;
  }
}
```

---

## 📊 Sorting with Priority Queues

### Algorithm: PQ-Sort(S, C)
```pseudo
Input: sequence S, comparator C
Output: sorted sequence S

P ← empty priority queue with C
while !S.isEmpty():
  e ← S.removeFirst()
  P.insert(e, ∅)
while !P.isEmpty():
  e ← P.removeMin().getKey()
  S.addLast(e)
```

- Runtime depends on PQ implementation

---

## 🔁 Sequence-based Implementations

### Unsorted List
- `insert`: O(1)
- `removeMin` / `min`: O(n)

### Sorted List
- `insert`: O(n)
- `removeMin` / `min`: O(1)

---

## 📉 Selection Sort via PQ

- Use unsorted list as PQ
- Insert: O(n)
- Repeated removeMin: O(n²)
- **Total time**: O(n²)

---

## 📈 Insertion Sort via PQ

- Use sorted list as PQ
- Insert: O(n)
- removeMin: O(n)
- **Total time**: O(n²)

### Best Case:
- If already sorted:
  - Insert: O(n)
  - removeMin: O(n)
  - **Total**: O(n)

---

## 🧩 In-place Insertion Sort

- No external structure
- Keep initial part of array sorted

### Steps:
- Use swaps to maintain sorted portion in-place

Example (descending to ascending):
```
5 4 2 3 1
↓
4 5 2 3 1
2 4 5 3 1
2 3 4 5 1
1 2 3 4 5
```

---
