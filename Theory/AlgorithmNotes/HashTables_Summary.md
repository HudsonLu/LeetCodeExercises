
# 🗃️ Hash Tables – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Hash Functions
- Compression Techniques
- Collision Handling: Separate Chaining, Open Addressing
- Probing Methods: Linear, Double, Quadratic
- Performance Analysis

---

## 🗺️ Map ADT Recap

- **get(k)**: return value associated with `k`, or null
- **put(k, v)**: insert/update key `k` with value `v`
- **remove(k)**: delete key `k` and return its value
- **entrySet()**, **keySet()**, **values()**
- **size()**, **isEmpty()**

---

## 🔢 Hash Tables & Hash Functions

- Hash table = array of buckets
- Key `k` hashed to index `i = h(k)`
- Ideal: each bucket has one item → O(1) access time

---

## 🧠 Hash Function Basics

- **Hash function h(x)** maps keys to range `[0, N−1]`
- Often defined as: `h(x) = h2(h1(x))`
  - `h1`: hash code
  - `h2`: compression function

### Common Hash Codes:
- Memory Address (Java's `hashCode()`)
- Integer Casting
- Summing Components (e.g., 16-bit partitions)
- **Polynomial Accumulation**: `p(z) = a₀ + a₁z + a₂z² + ...`
  - Evaluated efficiently via **Horner’s Rule**
  - z = 33, 37, 39, or 41 recommended

---

## 🧮 Compression Functions

### Division Method:
- `h2(y) = y mod N`
- Choose **prime N** to reduce collisions

### MAD Method (Multiply-Add-Divide):
- `h2(y) = (ay + b) mod N`
- Better version: `h2(y) = ((ay + b) mod p) mod N`
  - p: prime > N, a ≠ 0

---

## 💥 Collisions

- **Collision**: different keys hashed to same index

### Handling Collisions

#### 1. Separate Chaining
- Each bucket has a linked list (map)
- Delegates to list-based map at A[h(k)]

#### 2. Open Addressing
- Store entries directly in array
- Must maintain load factor < 1

---

## 🔁 Probing Strategies

### 🔹 Linear Probing
- If A[i] is full → try A[(i+1)%N], (i+2)%N, etc.
- Clustering risk (primary clustering)

### 🔸 Double Hashing
- Second hash `d(k)` guides the probing: `(i + j·d(k)) % N`
- Avoids clustering better than linear
- Requires: `d(k) ≠ 0` and N is prime

### 🔺 Quadratic Probing
- Probe sequence: h(k), h(k)+1², h(k)+2², h(k)+3², ...
- Reduces clustering but may fail (cyclic probing)

---

## 🔍 Search with Linear Probing

```java
i = h(k)
while p < N:
  if A[i] == ∅ → return null
  if A[i].key == k → return A[i].value
  i = (i + 1) % N
```

---

## ➖ Deletion in Open Addressing

- Use **AVAILABLE** marker instead of deletion
- Avoids breaking probe sequences

---

## 📈 Performance Analysis

| Method              | Time        |
|---------------------|-------------|
| get / put / remove  | O(1) expected |
| Worst-case          | O(n)         |

### Load Factor (α = n/N)
- Ideal: α < 0.5 for open addressing, α < 0.9 for separate chaining
- Java default threshold: α = 0.75 → triggers **rehashing**

---

## 🔁 Rehashing

- Resize table (usually double size)
- Rebuild hash table with new hash function
- Amortizes cost over many insertions

---
