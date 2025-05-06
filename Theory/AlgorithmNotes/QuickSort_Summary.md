
# ⚡ Quick Sort – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Quick Sort Algorithm (Divide & Conquer)
- Partitioning Strategy
- Quick-Sort Tree
- Execution Examples
- Worst-case vs Expected Time
- In-Place Quick Sort
- Partition Optimization
- Comparison with Other Sorting Algorithms

---

## 🔧 Quick Sort – Overview

- **Randomized sorting algorithm** using **divide-and-conquer**.

### Steps:
1. **Divide**: Choose pivot `x` and partition input `S` into:
   - `L`: elements < x
   - `E`: elements = x
   - `G`: elements > x
2. **Recur**: Recursively sort `L` and `G`
3. **Conquer**: Concatenate `L`, `E`, and `G`

---

## 🧩 Partition Algorithm

```pseudo
partition(S, p):
  L, E, G ← empty sequences
  x ← S.remove(p)
  while ¬S.isEmpty():
    y ← S.remove(S.first())
    if y < x: L.addLast(y)
    else if y == x: E.addLast(y)
    else: G.addLast(y)
  return L, E, G
```

- Takes **O(n)** time.

---

## 🌲 Quick-Sort Tree

- Each node = recursive call on subsequence
- Root = original call; Leaves = size 0 or 1 subsequences

Example:
```
Initial: 85 24 63 45 17 31 96 50
→ Sorted: 17 24 31 45 50 63 85 96
```

---

## ▶️ Execution Example

Input: `7 2 9 4 3 7 6 1` → Output: `1 2 3 4 6 7 7 9`

- Partition and sort each sub-part recursively.
- Followed by recursive joining.

---

## 📉 Worst-case Running Time

Occurs when:
- Pivot = min or max element → highly unbalanced splits

Sum of comparisons: `n + (n-1) + (n-2) + ... + 1 = O(n²)`

---

## 📊 Expected Running Time

- Good pivot splits L and G into ≤ 3/4 of input.
- Probability of good call: 1/2.

Expected tree height: **O(log n)**

### Result:
- Total expected time: **O(n log n)**

---

## 🔁 In-Place Quick Sort

- Rearranged using rank positions without new space.

### Algorithm:

```pseudo
inPlaceQuickSort(S, l, r):
  if l ≥ r: return
  i ← random integer in [l, r]
  x ← S.elemAtRank(i)
  (h, k) ← inPlacePartition(x)
  inPlaceQuickSort(S, l, h−1)
  inPlaceQuickSort(S, k+1, r)
```

---

## 🔄 In-Place Partitioning

- Use two indices `j`, `k`
- Move j forward to find > pivot
- Move k backward to find < pivot
- Swap and repeat until j > k

---

## 🧠 Sorting Algorithm Comparison

| Algorithm       | Time       | Notes                         |
|-----------------|------------|-------------------------------|
| Selection Sort  | O(n²)      | In-place, good for small inputs |
| Insertion Sort  | O(n²)      | In-place, simple, small inputs |
| Quick Sort      | O(n log n) (expected) | In-place, fastest in practice |
| Heap Sort       | O(n log n) | In-place, large inputs        |
| Merge Sort      | O(n log n) | Sequential access, large data sets |

---
