
# 🪣 Bucket-Sort & 🧮 Radix-Sort – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Bucket-Sort Algorithm
- Stable Sorting
- Radix-Sort Algorithm
- Lexicographic Order
- Multi-Key Sorting (d-tuples)
- Time Complexity Analysis

---

## 🪣 Bucket-Sort

- Used when keys are **integers in a fixed range** `[0, N−1]`.
- Avoids comparisons: uses keys as indices into an auxiliary array `B` of sequences (buckets).

### Algorithm
```pseudo
bucketSort(S, N):
  B ← array of N empty buckets
  for each (k, v) in S:
    B[k].addLast((k, v))
  S.clear()
  for i = 0 to N − 1:
    for each item in B[i]:
      S.addLast(item)
```

### Time Complexity:
- Phase 1 (bucket placement): O(n)
- Phase 2 (collect buckets): O(n + N)
- Overall: **O(n + N)** → If `N = O(n)`, sorting is **linear**

---

## 🧾 Stability in Sorting

### Stable Sort Definition:
- Preserves the **relative order** of items with equal keys.

### Bucket-Sort & Stability:
- Not stable by default.
- Can be made stable by:
  - Inserting items **in order** from S to buckets
  - Removing items **in order** from buckets

---

## 🔤 Lexicographic Order

- For d-tuples (k₁, k₂, ..., k_d), ordering defined recursively:
```text
(x₁, ..., x_d) < (y₁, ..., y_d) ⟺
x₁ < y₁ ∨ (x₁ = y₁ ∧ ... ∧ x_d < y_d)
```

---

## 🧮 Radix-Sort

- Sorts sequences of tuples (e.g., (x, y), or (x₁, x₂, ..., x_d)).
- Applies **stable bucket-sort** on each component, starting from the **last** to the **first**.

### Why Back-to-Front?
- Preserves earlier-order stability.
- Ensures **lexicographic correctness**.

### Example:
```text
Original:   (3,3), (1,5), (2,5), (1,2), (2,3), (1,7), (3,2), (2,2)
Sort 2nd:   (1,2), (3,2), (2,2), (3,3), (2,3), (1,5), (2,5), (1,7)
Sort 1st:   (1,2), (1,5), (1,7), (2,2), (2,3), (2,5), (3,2), (3,3)
```

---

## ⏱️ Lexicographic Sort Complexity

Let `T(n)` be the time for stableSort, `d` the number of keys per tuple.

- **Total Time**: O(d × T(n))
- For radix-sort using bucket-sort (O(n + N)): **O(d(n + N))**

---

## 🔢 Binary Radix-Sort

- Sorts `n` b-bit integers.
- Treats each integer as b-tuple in {0, 1}ᵇ.
- Uses bucket-sort for each bit (starting from least significant).

### Algorithm:
```pseudo
binaryRadixSort(S):
  for i = 0 to b−1:
    for each (k, x) in S:
      replace key k with bit i of x
    bucketSort(S, 2)
```

- Time: **O(bn)** — efficient for fixed-bit integers (e.g., 32-bit ints)

---

## 🧮 Summary

| Algorithm      | Key Assumptions         | Time Complexity |
|----------------|--------------------------|------------------|
| Bucket Sort    | Keys in range [0, N−1]   | O(n + N)         |
| Radix Sort     | d-tuple keys in [0, N−1] | O(d(n + N))      |
| Binary Radix   | b-bit integers           | O(bn)            |

- Non-comparison-based sorting can beat the **Ω(n log n)** lower bound if input conditions allow.

---
