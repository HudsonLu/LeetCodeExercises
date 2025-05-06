
# 🌲 AVL Trees – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- AVL Tree Definition & Height-Balance Property
- Tree Height Bounds
- Insertion & Rebalancing
- Trinode Restructuring (Single & Double Rotations)
- Removal & Rebalancing
- AVL Tree Performance

---

## 🌳 What is an AVL Tree?

- A **self-balancing binary search tree**.
- Named after inventors **Adelson-Velskii and Landis (1962)**.
- Maintains **Height-Balance Property**:
  - For every internal node `v`, the heights of its children differ by **at most 1**.

### Implication:
- Guarantees **height O(log n)** for `n` nodes.

---

## 📐 Height of an AVL Tree

- Let `n(h)` be the minimum number of nodes in an AVL tree of height `h`.

Recursive relationship:
```
n(h) = 1 + n(h−1) + n(h−2)
```

- Implies: `n(h) > 2n(h−2)` (exponential growth)

### Bound:
- `n(h) ≥ 2^(h/2) - 1` ⇒ `h < 2 log n + 2`
- Thus, AVL tree height is **O(log n)**

---

## ➕ Insertion in AVL Trees

1. Insert as in **binary search tree**.
2. New node becomes internal, grows height by 1.
3. May **violate balance** on the path back to the root.
4. Rebalancing is done via **Trinode Restructuring**.

---

## 🔁 Trinode Restructuring

To rebalance an unbalanced node `z`:
- Let `y` be the **child of z** with larger height
- Let `x` be the **child of y** with larger height

### Rebalancing Steps:
1. Identify nodes x, y, z
2. Rename x, y, z to a, b, c in inorder order
3. Restructure so b becomes new subtree root
4. a and c become children; 4 subtrees T0–T3 reattached

---

## 🔄 Rotations

### Single Rotation (2 cases)
- When y is aligned with z (left-left or right-right)

### Double Rotation (2 cases)
- When y is misaligned with z (left-right or right-left)

| Rotation Type     | Description                     |
|-------------------|----------------------------------|
| Single Rotation   | One structural change            |
| Double Rotation   | Two rotations: x over y, then x over z |

---

## ➖ Removal in AVL Trees

1. Start as in BST — remove node, mark as external.
2. Parent node may cause **imbalance**.
3. From this node up to the root:
   - Rebalance using **restructure(x)**.
   - Multiple rebalances may be needed.

---

## ⚖️ Rebalancing after Removal

- After node deletion, **tree height may decrease**.
- May propagate upward causing **multiple imbalances**.
- Must rebalance all the way to the root if needed.
- Each rebalance takes O(1), but can be done O(log n) times.

---

## ⏱️ AVL Tree Performance

| Operation | Time Complexity | Notes                          |
|-----------|------------------|-------------------------------|
| `get`     | O(log n)         | Binary search only             |
| `put`     | O(log n)         | Binary search + restructure    |
| `remove`  | O(log n)         | Binary search + multiple restructure |
| `space`   | O(n)             | Standard linked binary tree    |

- Efficient for dynamic sets/maps with frequent inserts/removals.

---
