
# 📘 Recursion – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 What is Recursion?

- **Recursion** occurs when a method calls itself.
- **Example: Factorial**
```java
public static int recursiveFactorial(int n) {
    if (n == 0) return 1; // base case
    else return n * recursiveFactorial(n - 1); // recursive case
}
```

---

## 🧱 Structure of a Recursive Method

- **Base Case(s)**: No recursive calls, must be reached eventually.
- **Recursive Calls**: Must approach the base case.

---

## 🧠 Visualizing Recursion

- Each recursive call uses a **stack frame**.
- Stack frames store: parameters, local variables, return address.
- Example: recursiveFactorial(4) creates a stack from 4 → 0 and returns up.

---

## 🗂️ Memory Use in Recursion

- **Stack**: Stores method calls.
- **Heap**: Stores dynamically created objects.
- **Danger**: Infinite or deep recursion may cause a **stack overflow**.

---

## 🔁 Linear Recursion

- A method makes at most **one recursive call** per activation.
- **Example: LinearSum** (sum of first `n` array elements)
```java
if (n == 1) return A[0];
else return LinearSum(A, n - 1) + A[n - 1];
```

---

## 🔄 Reversing an Array (Tail Recursion)

```java
if (i < j) {
    swap(A[i], A[j]);
    ReverseArray(A, i + 1, j - 1);
}
```

- Tail-recursive methods can be rewritten iteratively.

---

## 📐 Power Function – O(n) and O(log n)

### Naive:
```java
if (n == 0) return 1;
else return x * Power(x, n - 1);
```

### Optimized (Recursive Squaring):
```java
if (n == 0) return 1;
if (n is odd) return x * Power(x, (n - 1) / 2)^2;
else return Power(x, n / 2)^2;
```

- Runs in **O(log n)**

---

## 🪃 Binary Recursion

- Two recursive calls per activation.
- **Example: Summing array halves**
```java
return binarySum(A, i, n/2) + binarySum(A, i + n/2, n/2);
```

- Total calls: `2n - 1`, time complexity: **O(n)**

---

## 🧮 Fibonacci – Naive vs Optimized

### Naive Recursive (Exponential Time):
```java
if (k <= 1) return k;
else return binaryFib(k - 1) + binaryFib(k - 2);
```

- Call count grows exponentially: **> 2^(k/2)**

### Optimized Linear Recursion:
```java
if (k == 1) return (1, 0);
(i, j) = linearFibonacci(k - 1);
return (i + j, i);
```

- Makes **k - 1 calls**, runs in **O(k)**

---

## 📏 Drawing – The English Ruler (Binary Recursion)

```java
if (length > 0) {
    drawTicks(length - 1);
    drawOneTick(length);
    drawTicks(length - 1);
}
```

- Recursive drawing pattern visualized as a central tick surrounded by shorter ones.

---

## 🌐 Multiple Recursion

- A method makes **more than two recursive calls**.
- **Example: Folder copy**
```java
for (subfolder in folder)
    copyFolder(subfolder);
```

- **Example: PuzzleSolve** – Generates permutations of a set.

---

## 🔚 Final Notes

| Recursion Type     | Characteristics                            |
|--------------------|--------------------------------------------|
| Linear             | One recursive call per step                |
| Tail               | Recursive call is last action              |
| Binary             | Two recursive calls per step               |
| Multiple           | More than two recursive calls per step     |

- Deep recursion can exhaust stack memory.
- Tail and linear recursion are most efficient for large input sizes.

---
