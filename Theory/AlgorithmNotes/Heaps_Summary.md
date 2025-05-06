
# 🗂️ Heaps – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Heap Data Structure
- Heap Properties (Heap-Order & Complete Binary Tree)
- Upheap & Downheap Algorithms
- Heap-based Priority Queue
- Heap-Sort Algorithm
- Array-based Heap Implementation
- Bottom-Up Heap Construction

---

## 🔺 What is a Heap?

- A **heap** is a binary tree used to efficiently implement a **priority queue**.
- Not to be confused with the memory heap.
- Stores `(key, value)` pairs.
- Always satisfies:
  - **Heap-Order Property**: `key(v) ≥ key(parent(v))`
  - **Complete Binary Tree**: All levels are full, last level filled left to right.

---

## 📐 Heap Properties

### Heap-Order Property
- Keys on any path from root to leaves are in **non-decreasing** order.
- The **minimum key** is always at the **root**.

### Complete Binary Tree Property
- Ensures **minimum height** for `n` elements: height `O(log n)`.
- Node layout:
  - All levels have `2^i` nodes (for level `i`) except possibly the last.

---

## 🔃 Heap Operations

### Insertion
- Add new key at the last position.
- Apply **upheap** (bubble-up) to restore heap order.

### Removal (removeMin)
- Swap root with last node.
- Remove last node.
- Apply **downheap** (bubble-down) to restore heap order.

### Upheap & Downheap
- Both take `O(log n)` time (heap height).

---

## 💡 Heap-based Priority Queue

### Methods
- `insert(k, x)`: O(log n)
- `removeMin()`: O(log n)
- `min()`, `size()`, `isEmpty()`: O(1)

### Benefits
- Much faster than selection/insertion sort.
- Heap allows PQ-sort to run in **O(n log n)** time.

---

## 📊 Heap-Sort Algorithm

```pseudo
function heapSort(S, C):
  P ← new heap-based PQ with comparator C
  for each element e in S:
    P.insert(e, ∅)
  while not P.isEmpty():
    S.addLast(P.removeMin().getKey())
```

- Insertions + removals = **O(n log n)** time
- Much faster than O(n²) sorting algorithms

---

## 🧮 Array-Based Heap

- Use array A of size `n`.
- For element at index `i`:
  - Left child → `2i + 1`
  - Right child → `2i + 2`
- No explicit links needed.
- **In-place heap-sort** possible with this layout.

---

## 🔁 Merging Two Heaps

- New root stores key `k`
- Two heaps become left and right subtrees
- Apply **downheap** to restore heap-order

---

## 🧱 Bottom-Up Heap Construction

- Insert all known entries into tree without order
- Start at last internal node and apply **downheap** upwards
- Steps: h+1 where h = log(n+1)-1
- Final heap formed in **O(n)** time

### Benefits
- Reduces **heap-building** time phase in heap-sort
- Doesn't change asymptotic complexity but speeds phase I

---

## 📈 Summary of Heap Operations

| Operation    | Time Complexity |
|--------------|------------------|
| insert()     | O(log n)         |
| removeMin()  | O(log n)         |
| min()        | O(1)             |
| size(), isEmpty() | O(1)        |
| build-heap (bottom-up) | O(n)  |

---
