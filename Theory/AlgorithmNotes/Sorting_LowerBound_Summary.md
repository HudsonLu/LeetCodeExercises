
# 📉 Sorting Lower Bound – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Comparison-Based Sorting Algorithms
- Decision Tree Model
- Lower Bound Proof
- Factorial-Based Permutations
- Height of Decision Tree
- Ω(n log n) Lower Bound

---

## 🧮 Comparison-Based Sorting

- Many sorting algorithms are **comparison-based**.
  - Compare pairs of elements to determine order.
  - Examples: **Bubble Sort**, **Selection Sort**, **Insertion Sort**, **Heap Sort**, **Merge Sort**, **Quick Sort**.

- Some achieve time complexity **O(n log n)**.

### Question:
> Can we sort **faster** than O(n log n)?
> What is the **lower bound** (best possible time) for comparison-based sorting?

---

## 🔁 Counting Comparisons

- Sorting involves comparing elements like: `is xi < xj?`
- Each comparison yields a **yes/no** (binary outcome).

### Key Observations:
- The algorithm’s flow can be represented as a **decision tree**.
- Each path from **root to leaf** = one possible execution.
- Each **leaf** represents a **permutation** of the input.

---

## 🌲 Decision Tree Model

- For `n` elements, there are `n!` permutations.
- Thus, the number of **leaves** in the decision tree is **n!**.
- The **height** of the tree corresponds to the **number of comparisons** in the worst case.

### Example (n = 3):
- 3! = 6 permutations
- Comparison tree will have **at least 6 leaves**.

---

## 📈 Lower Bound Derivation

- A decision tree for comparison-based sorting must have height **at least log₂(n!)**
- Because a binary tree with `L` leaves has minimum height `log₂(L)`

### Result:
```
Height ≥ log₂(n!) ≈ n log n − n
```

Therefore:
- Any comparison-based sort must make **Ω(log₂(n!)) = Ω(n log n)** comparisons in the worst case.

---

## ✅ Final Result

> Any **comparison-based** sorting algorithm has a **lower bound** of **Ω(n log n)** comparisons.

- We **cannot** beat this limit with **comparison-based** strategies.
- If we want better performance (e.g., **linear time**), we must use **non-comparison-based algorithms** like:
  - **Counting Sort**
  - **Radix Sort**
  - **Bucket Sort**

---
