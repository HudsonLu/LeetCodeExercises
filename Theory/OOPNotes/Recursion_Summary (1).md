
# 🔁 Recursion – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Recursive Methods & Tracing Calls
- Stack Mechanism for Recursion
- Base Case & Infinite Recursion
- Recursion vs Iteration
- Value-Returning Recursive Methods
- Binary Search with Recursion
- Efficiency and Validation of Recursive Design

---

## 🔁 What is Recursion?

- A **recursive method** calls itself directly or indirectly.
- Solves a problem by breaking it into **smaller subproblems**.

### Example:
```java
int factorial(int n) {
  if (n == 0) return 1;
  else return n * factorial(n - 1);
}
```

---

## 🧠 Tracing Recursive Calls

- Each call **suspends execution** until its recursive call completes.
- The system resumes previous calls using the **call stack**.

---

## 📄 Stack for Recursion

- A **stack** keeps track of recursive calls (LIFO structure).
- Each call has a **stack frame** (activation record).
- If recursion goes too deep → **stack overflow**.

---

## 🛑 Base Case & Infinite Recursion

- Recursive calls must reach a **base (stopping) case**.
- If not → **infinite recursion** and potential crash.

### Common Pitfall:
```java
int recurse(int n) {
  return recurse(n - 1); // no base case
}
```

---

## ✅ General Form of Recursive Method

1. One or more **recursive cases** with smaller subproblems.
2. One or more **base cases** without recursion.

---

## 🔁 Recursion vs Iteration

| Feature        | Recursion                 | Iteration            |
|----------------|---------------------------|----------------------|
| Approach       | Divide into subproblems   | Loop-based           |
| Performance    | Slower, more memory       | Faster, less memory  |
| Code Simplicity| Cleaner in some cases     | May be verbose       |
| Stack Usage    | Uses call stack           | No stack needed      |

---

## 🧾 Value-Returning Recursive Methods

- Recursive methods can return values:
```java
int power(int x, int n) {
  if (n == 0) return 1;
  return x * power(x, n - 1);
}
```

- Must define base and recursive cases.

---

## 🧠 Thinking Recursively

1. Ensure recursion ends with base case.
2. Base case returns correct value.
3. If all recursive calls return correct value, overall return is correct.

- This aligns with **mathematical induction**.

---

## 🧮 Binary Search (Recursive)

- Requires **sorted array**.
- Reduces search space by half each time.

### Pseudocode:
```java
binarySearch(array, key, low, high):
  if low > high: return -1
  mid = (low + high) / 2
  if array[mid] == key: return mid
  else if key < array[mid]: search in low to mid-1
  else: search in mid+1 to high
```

### Efficiency:
- **Worst-case time**: O(log n)
- **Much faster** than linear search O(n)

---

## 🧪 Verifying Recursive Correctness

1. Ends with a base case
2. Base case does the right thing
3. Recursive case works if recursive calls are correct

- Applies to **void** and **returning** methods

---

## ✅ Summary

| Concept         | Key Idea                                |
|------------------|------------------------------------------|
| Recursive Call   | Method calls itself                      |
| Base Case        | Terminates recursion                     |
| Infinite Recursion| Occurs when base case is missing         |
| Stack Frame      | Memory used per recursive call           |
| Recursion vs Loop| Any recursive task can be iterative      |
| Binary Search    | Efficient recursive divide & conquer     |
| Correctness      | Follows induction-like reasoning         |

---
