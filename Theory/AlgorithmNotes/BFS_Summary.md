
# 🌐 Breadth-First Search (BFS) – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Graph Traversal Concepts
- Breadth-First Search (BFS) Algorithm
- BFS Examples and Levels
- Discovery vs Cross Edges
- BFS Applications
- Time Complexity
- DFS vs BFS

---

## 🚶‍♂️ What is BFS?

- BFS explores the graph **level-by-level**, starting from a selected **anchor** node.
- It visits all **closest neighbors** before moving to more distant vertices.
- Nodes are divided into levels:
  - Level 0: starting vertex
  - Level 1: vertices 1 edge away
  - Level 2: vertices 2 edges away
  - ... and so on

---

## 🧶 BFS Strategy

1. Start from a node `s` (Level 0).
2. Visit all unvisited neighbors (Level 1).
3. Extend search to neighbors of Level 1 (Level 2).
4. Repeat until all reachable vertices are visited.

- **Discovery edge**: leads to an unexplored vertex.
- **Cross edge**: connects to an already visited vertex.

---

## 🧠 BFS Algorithm

```pseudo
Algorithm BFS(G, s):
  L0 ← new empty sequence
  L0.addLast(s)
  setLabel(s, VISITED)
  i ← 0
  while ¬Li.isEmpty():
    Li+1 ← new empty sequence
    for each v in Li:
      for each e in G.incidentEdges(v):
        if getLabel(e) = UNEXPLORED:
          w ← opposite(v, e)
          if getLabel(w) = UNEXPLORED:
            setLabel(e, DISCOVERY)
            setLabel(w, VISITED)
            Li+1.addLast(w)
          else:
            setLabel(e, CROSS)
    i ← i + 1
```

---

## 🧪 BFS Applications

- Visit all vertices and edges.
- Check graph connectivity.
- Compute a **spanning tree** or **spanning forest**.
- Find connected components.
- Detect cycles.
- Find **shortest path** (least number of edges).

---

## ⏱️ BFS Time Complexity

- BFS runs in **O(n + m)** time, where:
  - `n`: number of vertices
  - `m`: number of edges

### Why?
- Each vertex is labeled twice (UNEXPLORED → VISITED).
- Each edge is labeled twice (UNEXPLORED → DISCOVERY/CROSS).
- Each vertex is enqueued once.
- Each edge is examined via `incidentEdges()`.

---

## 🌲 BFS Properties

| Property | Description |
|----------|-------------|
| 1 | Visits all vertices/edges in the connected component of the start node. |
| 2 | Discovery edges form a **spanning tree** of the component. |
| 3 | Each vertex `v` in level `Li` has a shortest path (in terms of edges) from `s` with `i` edges. |

---

## 🔁 DFS vs. BFS

| Feature / Use Case            | DFS | BFS |
|-------------------------------|-----|-----|
| Spanning tree / forest        | ✔   | ✔   |
| Connected components          | ✔   | ✔   |
| Path finding                  | ✔   | ✔   |
| **Shortest path** (unweighted)| ❌   | ✔   |
| Biconnected components        | ✔   | ❌   |
| Cycle detection               | ✔   | ✔   |

---

## 🎨 Edge Types

| Type        | DFS                       | BFS                                   |
|-------------|---------------------------|----------------------------------------|
| Tree edge   | Discovery edge            | Discovery edge (new vertex found)      |
| Back edge   | Connects to ancestor      | Not applicable                         |
| Cross edge  | Unrelated node or sibling | To visited vertex at same/later level  |

---

## 🛠️ Summary

- BFS is ideal for level-order traversal and finding shortest paths in unweighted graphs.
- It builds a **BFS tree** with discovery and cross edges.
- Provides **efficient O(n + m)** solutions to many graph problems.

---
