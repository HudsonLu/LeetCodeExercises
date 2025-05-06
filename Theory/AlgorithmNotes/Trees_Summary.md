
# 🌳 Trees – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- General Trees
- Tree Terminology
- Tree Traversals
- Binary Trees
- Expression & Decision Trees
- Binary Tree Implementations
- Euler Tour & Template Method Pattern

---

## 🌲 What is a Tree?

- Abstract model of a hierarchical structure.
- Tree: a collection of **nodes** with **parent-child** relationships.
- **Applications**: Org charts, file systems, expression parsing.

### Tree Components:

| Term        | Description                                 |
|-------------|---------------------------------------------|
| Root        | Node without a parent                       |
| Internal    | Node with at least one child                |
| External    | Leaf node (no children)                     |
| Depth       | Number of ancestors                         |
| Height      | Max depth of any node in the tree           |
| Sibling     | Nodes with the same parent                  |
| Path        | Sequence of connected nodes                 |
| Subtree     | A node and all its descendants              |

---

## 🔀 Ordered Trees

- Children of each node are **ordered** (e.g., first, second).
- Example: Book → Chapters → Sections

---

## 🧱 Tree ADT (Abstract Data Type)

### Generic Methods:
- `size()`, `isEmpty()`, `iterator()`, `positions()`

### Accessor Methods:
- `root()`, `parent(p)`, `children(p)`

### Query Methods:
- `isInternal(p)`, `isExternal(p)`, `isRoot(p)`

### Update:
- `replace(p, e)` – replace node element

### Time Complexity:

| Operation   | Complexity |
|-------------|------------|
| size, isEmpty, root, parent | O(1) |
| children(p) (c = # children) | O(c) |
| iterator(), positions() | O(n) |

---

## 🔁 Tree Traversals

### Preorder
- Visit root, then children recursively
```pseudo
visit(v)
for each child w of v:
  preorder(w)
```

### Postorder
- Visit all children, then root
```pseudo
for each child w of v:
  postorder(w)
visit(v)
```

### Level Order (Breadth-First)
- Visit all nodes at depth `d` before `d+1`

---

## 🌳 Binary Trees

- Each node has **at most two children**.
- Children are **ordered**: left and right.

### Applications:
- Arithmetic expressions, decision trees, search trees.

---

## ➗ Arithmetic Expression Tree

- Internal nodes: operators (`+`, `-`, `×`, `/`)
- Leaves: operands (numbers or variables)

### Example: (2 × (a − 1) + (3 × b))

```
        +
       / \
      ×   ×
     / \ / \
    2  - 3  b
       / \
      a   1
```

---

## ❓ Decision Tree

- Internal nodes: questions (yes/no)
- Leaves: decisions

### Example:
```
        Want a fast meal?
         /             \
       Yes             No
     Coffee?        Expense?
     /    \         /    \
 Starbucks Spike  AlForno CaféParagon
```

---

## 📏 Binary Tree Properties

Let:
- `n`: total nodes
- `e`: external nodes
- `i`: internal nodes
- `h`: height

### Key Properties:
- `e = i + 1`
- `n = 2e − 1 = 2i + 1`
- `h ≤ (n − 1)/2`
- `e ≤ 2^h`
- `h ≥ log₂(e)`

---

## 🧩 BinaryTree ADT

Extends Tree ADT with:
- `left(p)`, `right(p)` – access children
- `hasLeft(p)`, `hasRight(p)` – test for children

---

## 🔂 Binary Tree Traversals

### Inorder (left, root, right)
```pseudo
if hasLeft(v) then inOrder(left(v))
visit(v)
if hasRight(v) then inOrder(right(v))
```

### Print Expressions:
- Use parentheses and inorder traversal

### Evaluate Expressions:
- Postorder traversal to evaluate

---

## 🔁 Euler Tour Traversal

- Visits nodes **3 times**: left, below, right
- General form that includes preorder, inorder, postorder

### Application:
- Count descendants of a node: `rightVisit - leftVisit + 1`

---

## 🪢 Linked Structure for Trees

### General Tree Node:
- Stores element, parent, and list of children

### Binary Tree Node:
- Stores element, parent, left, right

---

## 🧠 Binary Tree Implementations

| Operation     | Linked List | Array-based |
|---------------|-------------|-------------|
| size, isEmpty | O(1)        | O(1)        |
| root, left    | O(1)        | O(1)        |
| iterator      | O(n)        | O(n)        |

### Array Representation Rules:
- `left(i) = 2i + 1`
- `right(i) = 2i + 2`

---

## 🧰 Template Method Pattern

- Abstract base class defines generic `eulerTour()` traversal.
- Subclasses override `visitLeft()`, `visitBelow()`, `visitRight()`.

### Example: Evaluate Expression
```java
protected void visitRight(Position<Expr> v, TourResult<Integer> r) {
  if (tree.isInternal(v)) {
    op.setOperands(r.left, r.right);
  }
  r.out = term.getValue();
}
```

---
