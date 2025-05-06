
# 🚦 Shortest Paths – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Weighted Graphs & Applications
- Shortest Path Properties
- Dijkstra’s Algorithm
- Bellman-Ford Algorithm
- DAG-Based Shortest Paths
- Negative-Weight Cycles
- Time Complexity & Analysis

---

## 📐 Weighted Graphs

- A **weighted graph** assigns a numerical value (weight) to each edge.
- Weights may represent distance, cost, time, etc.
- If all weights are equal → BFS can be used.
- Otherwise, **Dijkstra’s Algorithm** or others are used.

### Applications
- Internet routing
- Flight booking
- Driving directions

---

## ✨ Shortest Path Concepts

- **Path Length**: Sum of edge weights.
- **Shortest Path**: Path with minimum length between two nodes.
- **Subpath Property**: Any subpath of a shortest path is also a shortest path.
- **Shortest-Path Tree**: Tree of all shortest paths from a source node.

---

## 🚫 Negative-Weight Cycles

- A cycle with total weight < 0.
- Makes shortest path undefined (can cycle infinitely to reduce cost).
- Must be avoided for shortest path algorithms like Dijkstra.

---

## 🚀 Dijkstra’s Algorithm

### Goal:
Find the shortest path from a source vertex `s` to all other vertices in a graph.

### Assumptions:
- Graph is **connected**
- Edges are **non-negative**
- Graph is **undirected**

### Key Concepts:
- **D[u]** = current known shortest distance from `s` to `u`
- Use a **min-priority queue** for vertex selection

### Relaxation Rule:
```text
D[z] ← min(D[z], D[u] + weight(u,z))
```

### Time Complexity:
- Using a min-heap with adjacency list: **O((n + m) log n)**

---

## 💡 Dijkstra’s Pseudocode

```pseudo
DijkstraDistances(G, s):
  Q ← min-heap priority queue
  for v in G.vertices():
    if v = s: D[v] ← 0
    else:     D[v] ← ∞
    Q.insert(D[v], v)

  while Q not empty:
    u ← Q.removeMin()
    for each edge (u,z):
      if D[u] + weight(u,z) < D[z]:
        D[z] ← D[u] + weight(u,z)
        Q.replaceKey(z, D[z])
```

---

## 🌳 Dijkstra’s Shortest Paths Tree

- Store a **parent edge** for each vertex.
- When relaxing, update parent edge if distance improves.
- Build the **tree of shortest paths** after the algorithm completes.

---

## ❗ Limitations of Dijkstra

- Fails on **negative-weight edges**
- Greedy approach assumes once a vertex is added, its distance is finalized — not true with negative weights.

---

## 🔁 Bellman-Ford Algorithm

- Works for **directed graphs with negative weights**
- Detects **negative-weight cycles**
- Iterates |V|−1 times to relax all edges

### Time Complexity: **O(nm)**

### Pseudocode:
```pseudo
for v in vertices:
  D[v] = ∞
D[s] = 0

for i in 1 to n−1:
  for each edge (u,z):
    D[z] = min(D[z], D[u] + weight(u,z))
```

---

## 🧮 DAG-Based Shortest Paths

- For **DAGs**, even with negative weights
- Uses **topological sort** to compute distances efficiently

### Time Complexity: **O(n + m)**

---

## 📊 Summary of Algorithms

| Algorithm        | Handles Neg. Weights? | Time Complexity         | Notes                        |
|------------------|------------------------|--------------------------|-------------------------------|
| Dijkstra         | ❌                     | O((n + m) log n)         | Fast with positive weights     |
| Bellman-Ford     | ✔️                     | O(nm)                    | Slower but detects cycles      |
| DAG-Based        | ✔️ (DAG only)          | O(n + m)                 | Fastest but needs top. order   |

---

## ✅ Key Takeaways

- Choose **Dijkstra** for non-negative weights & efficiency.
- Use **Bellman-Ford** if negative weights or cycle detection is needed.
- Apply **DAG approach** for acyclic graphs with possible negative weights.

---
