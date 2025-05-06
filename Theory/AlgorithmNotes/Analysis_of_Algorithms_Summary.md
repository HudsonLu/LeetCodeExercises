
# 📘 Analysis of Algorithms – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 1. Introduction

- **Correctness**: Does the algorithm solve the problem?
- **Efficiency**: Measures resource usage (time, memory).
- Efficiency ≠ Correctness.
- Must be independent of software/hardware environment.

---

## 📊 2. Experimental Studies

- Implement and time execution using `System.currentTimeMillis()`.
- **Limitations**:
  - Requires working code.
  - Input variation affects accuracy.
  - Hardware/software must be constant for fair comparison.

---

## 📐 3. Theoretical (Abstract) Analysis

- Focus on **number of executed statements**.
- Assumes unlimited resources (RAM model).
- Defines `worstTime(n)` – maximum steps for input size `n`.

---

## 🧠 4. Example – Worst Time

```java
for (int i = 0; i < n - 1; i++)
  if (a[i] > a[i+1])
    System.out.println(i);
```

- **worstTime(n) = 4n - 2**

---

## 📋 5. Pseudocode

- Language-agnostic algorithm description.
- Easy to read and analyze.
- Example:

```pseudocode
Algorithm arrayMax(A, n)
  currentMax ← A[0]
  for i ← 1 to n - 1 do
    if A[i] > currentMax then
      currentMax ← A[i]
  return currentMax
```

---

## 🔢 6. Common Complexity Classes

| Type            | Big-O    |
|------------------|----------|
| Constant         | O(1)     |
| Logarithmic      | O(log n) |
| Linear           | O(n)     |
| Linear-Logarithmic | O(n log n) |
| Quadratic        | O(n²)    |
| Cubic            | O(n³)    |
| Exponential      | O(2ⁿ)    |

---

## 🖥️ 7. RAM Model

- Unlimited memory cells.
- Each operation takes **constant time**.
- Used for theoretical analysis.

---

## 🧮 8. Primitive Operations

- Assignments
- Comparisons
- Arithmetic
- Array indexing
- Method calls/returns

---

## 🔍 9. Growth Rate

- Constant factors do **not** change the growth class.
- Example:
  - Insertion Sort: O(n²)
  - Merge Sort: O(n log n)
  - Sorting 1M elements: 70 hours vs 40 seconds

---

## ⭕ 10. Big-O Notation

- Describes **upper bound** on performance.
- Formal definition:
  > f(n) is O(g(n)) if ∃ c, n₀ > 0 such that f(n) ≤ c·g(n) for all n ≥ n₀

- Examples:
  - `2n + 10` → O(n)
  - `3n⁴ + 6n³ + ...` → O(n⁴)

---

## ⚡ 11. Quick Big-O Estimation

| Code Pattern                    | Complexity |
|--------------------------------|------------|
| Constant work                  | O(1)       |
| `while (n > 1) n = n / 2;`     | O(log n)   |
| `for i in 0..n`                | O(n)       |
| `for i in 0..n: while m > 1`   | O(n log n) |
| Nested loops (`i` and `j`)     | O(n²)      |
| Loop + Nested Loop             | O(n²)      |

---

## ⏱️ 12. Asymptotic Analysis

- Focuses on large `n`.
- Disregards constants and lower-order terms.
- Example:
  - `prefixAverages1()` → O(n²)
  - `prefixAverages2()` → O(n)

---

## ⚖️ 13. Big-Omega and Big-Theta

- **Big-Ω (Omega)**: Lower bound
  - `f(n) ≥ c·g(n)` for n ≥ n₀
- **Big-Θ (Theta)**: Tight bound
  - `c₁·g(n) ≤ f(n) ≤ c₂·g(n)` for n ≥ n₀

### Examples:

- `f(n) = 2n + 10`
  - O(n), Ω(n), Θ(n)
- `f(n) = 3n⁴ + ...`
  - O(n⁴), Ω(n⁴), Θ(n⁴)

---

## 🧾 14. English Equivalents of Big-Θ

| Big-Θ        | English Name          |
|--------------|------------------------|
| Θ(1)         | Constant               |
| Θ(log n)     | Logarithmic            |
| Θ(n)         | Linear                 |
| Θ(n log n)   | Linear-Logarithmic     |
| Θ(n²)        | Quadratic              |

---

## 📈 15. Doubling Input Size Effect

| Complexity | Result when doubling `n`     |
|------------|------------------------------|
| O(n)       | Runtime doubles              |
| O(n²)      | Runtime quadruples           |
| O(2ⁿ)      | Runtime explodes exponentially |

---

## 🧮 16. Execution Time Estimates (n = 1B, 1B ops/sec)

| Function     | Time Estimate     |
|--------------|------------------|
| log₂ n       | 0.0024 seconds   |
| n            | 17 minutes       |
| n log₂ n     | 7 hours          |
| n²           | 3000 years       |

---

## 📚 17. Math to Review

- Logarithm Laws
- Exponent Properties
- Summations
- Proof Techniques
- Basic Probability

---

## ✅ Final Notes

- **Big-O**: Upper bound
- **Big-Ω**: Lower bound
- **Big-Θ**: Tight bound (both upper and lower)
- Asymptotic analysis gives insight into scalability and efficiency
