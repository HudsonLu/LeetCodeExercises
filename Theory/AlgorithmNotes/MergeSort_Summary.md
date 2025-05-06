
# 🔀 Merge Sort – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Merge Sort Algorithm
- Divide-and-Conquer Paradigm
- Merging Sorted Sequences
- Merge-Sort Tree
- Execution Examples
- Merge Cost Analysis (Arrays & Lists)
- Time Complexity
- Merge Sort vs Heap Sort
- Sorting Algorithm Summary

---

## 🔧 Merge Sort – Core Idea

- **Merge Sort** applies **divide-and-conquer** to sort a sequence.

### Steps:
1. **Divide**: Split sequence S into two halves S1 and S2
2. **Recur**: Recursively sort S1 and S2
3. **Conquer**: Merge S1 and S2 into sorted sequence

### Base Case:
- If size of S ≤ 1, return (already sorted).

---

## 🧠 Divide-and-Conquer Paradigm

```pseudo
mergeSort(S, C):
  if S.size() > 1:
    (S1, S2) ← partition(S)
    mergeSort(S1, C)
    mergeSort(S2, C)
    S ← merge(S1, S2)
```

- **Merge step** takes O(n), where n is total elements.

---

## 🧩 Merge Step – Sorted Sequences

```pseudo
merge(A, B):
  S ← empty sequence
  while A and B not empty:
    compare A.first() and B.first()
    move smaller to S
  append remaining of A or B to S
  return S
```

- Efficient with **doubly linked lists or arrays**.
- Time complexity: **O(n)** for merging `n` elements.

---

## 🌲 Merge-Sort Tree

- Binary tree representing recursive calls.
- **Root**: original unsorted sequence.
- **Leaves**: size 0 or 1 subsequences (base cases).
- **Internal nodes**: store partitioned and then merged results.

---

## ▶️ Execution Example

Input: `7 2 9 4 3 8 6 1`

Recursive partitioning and merging produces:

```
→ 7 2 → 2 7
→ 9 4 → 4 9
→ 3 8 → 3 8
→ 6 1 → 1 6
→ 2 7 + 4 9 → 2 4 7 9
→ 3 8 + 1 6 → 1 3 6 8
→ final merge → 1 2 3 4 6 7 8 9
```

---

## 🧮 Merge Sorted Arrays

```pseudo
merge(A1, A2, A):
  i = j = 0
  while i < A1.size and j < A2.size:
    if A1[i] ≤ A2[j]: A.add(A1[i]); i++
    else: A.add(A2[j]); j++
  append remaining elements of A1 and A2
```

- Total cost: **O(n1 + n2)** = O(n)

---

## 📉 Merge Sorted Lists

- Similar idea as arrays but use **head pointers**.
- Append smaller to result and move head forward.
- Final cost is also **O(n1 + n2)** = O(n)

---

## 📊 Merge Sort Analysis

| Depth (i) | # Sequences | Size per Sequence |
|-----------|-------------|-------------------|
| 0         | 1           | n                 |
| 1         | 2           | n/2               |
| i         | 2ⁱ         | n/2ⁱ              |

- Each level takes **O(n)** time.
- There are **log n** levels.
- **Total Time**: **O(n log n)**

---

## 🔁 Merge-Sort vs Heap-Sort

| Feature         | Merge Sort            | Heap Sort           |
|------------------|------------------------|----------------------|
| Comparator       | ✔️                    | ✔️                  |
| Runtime          | O(n log n)            | O(n log n)          |
| Data Access      | Sequential (good for disk) | Random             |
| In-place         | ❌ (unless modified)   | ✔️                  |
| Memory Usage     | High                  | Low                 |

---

## ✅ Sorting Algorithm Summary

| Algorithm        | Time     | Notes                                  |
|------------------|----------|----------------------------------------|
| Selection Sort   | O(n²)    | Slow, in-place, good for < 1K          |
| Insertion Sort   | O(n²)    | Slow, in-place, good for < 1K          |
| Heap Sort        | O(n log n) | Fast, in-place, good for 1K–1M        |
| Merge Sort       | O(n log n) | Fast, not in-place, good for > 1M     |

---
