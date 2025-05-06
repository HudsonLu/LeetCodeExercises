
# 🔁 Directed Graphs (DiGraphs) – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Directed Graphs & Applications
- Reachability & Strong Connectivity
- DFS in Directed Graphs
- Transitive Closure
- Floyd-Warshall Algorithm
- Directed Acyclic Graphs (DAGs)
- Topological Sorting

---

## ➡️ What is a DiGraph?

- A **directed graph (digraph)** has edges with direction.
- Edge (a, b) goes from a to b (not vice versa).

### Applications:
- One-way streets
- Flight paths
- Task scheduling

---

## 🔄 Properties of DiGraphs

- For a simple digraph with `n` nodes:
  - Max degree = 2(n−1): n−1 incoming + n−1 outgoing edges
- Use separate adjacency lists for in-edges and out-edges

---

## 🔁 Reachability

- Vertex `u` is **reachable** from vertex `w` if a **directed path** exists from `w` to `u`.
- A vertex `v` reaches edge (w, z) if it reaches `w`.

---

## 🔗 Strong Connectivity

- A digraph is **strongly connected** if every vertex can reach every other vertex via a directed path.
- A graph is **acyclic** if it has no **directed cycles**.

---

## 🔄 Transitive Closure

- The **transitive closure** G* of a digraph G includes all edges (u, v) where v is reachable from u.
- G* has the same vertex set as G but more edges.

---

## 🌲 Traversing DiGraphs (DFS & BFS)

- DFS and BFS must follow edge directions.
- Directed DFS identifies 4 edge types:
  - **Discovery edge** (tree edge): leads to new vertex
  - **Back edge**: to ancestor
  - **Forward edge**: to descendant
  - **Cross edge**: to unrelated vertex

### DFS Complexity (from a node s):
- Time: O(ns + ms) where ns is number of reachable nodes, ms is number of reachable edges.

---

## 🔍 Strong Connectivity Testing (Efficient)

1. Run DFS from vertex `s`.
2. If DFS doesn’t reach all nodes → Not strongly connected.
3. Reverse all edges.
4. Run DFS again from `s`.
5. If it reaches all nodes → Graph is strongly connected.

### Time Complexity:
- Two DFS runs → O(n + m)

---

## 🧮 Transitive Closure: Floyd-Warshall

### Floyd-Warshall Algorithm

- Computes transitive closure using dynamic programming.
- For each triple (i, j, k):
  - If there’s a path i → k and k → j, add i → j.
- Based on vertex indices from 1 to n.

```pseudo
FloydWarshall(G):
  for k ← 1 to n:
    for i ← 1 to n:
      for j ← 1 to n:
        if edge(i, k) and edge(k, j):
          add edge(i, j)
```

- **Time Complexity**: O(n³)

---

## 🧱 DAGs (Directed Acyclic Graphs)

- A digraph with **no directed cycles**.
- Used in:
  - Course prerequisites
  - Task scheduling
  - Inheritance graphs

---

## 🔢 Topological Sorting

- Orders vertices so that for every edge (u, v), u comes before v.
- Only valid for DAGs.

### Algorithm:
1. Find vertex with indegree 0
2. Assign order number, remove vertex
3. Repeat

### Time Complexity:
- **O(n + m)**

---

## 🔁 DFS-Based Topological Sort

1. Perform DFS.
2. Assign topological number **when backtracking**.
3. Multiple DFS calls are needed to ensure full coverage.

---

## ✅ Summary

| Concept               | Description                         |
|-----------------------|-------------------------------------|
| Reachability          | Directed path exists from u to v    |
| Strong Connectivity   | All pairs (u, v) are reachable      |
| Transitive Closure    | Add all reachable edges to G*       |
| Floyd-Warshall        | Dynamic programming, O(n³)          |
| DAG                   | No directed cycles                  |
| Topological Sort      | Valid ordering for tasks            |
| DFS Traversal         | Discovers reachable structure       |

---
