
# 🔍 Depth-First Search (DFS) – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Graph Traversal
- Subgraphs and Connectivity
- Trees, Forests, and Spanning Structures
- DFS Algorithm & Examples
- DFS Applications (Cycle/Path Finding)
- DFS Complexity & Properties

---

## 🔗 Subgraphs

- A **subgraph** S of graph G:
  - Vertices ⊆ G’s vertices
  - Edges ⊆ G’s edges
- A **spanning subgraph** contains all vertices of G.

---

## 🔄 Connectivity

- **Connected**: Path exists between every pair of vertices.
- **Connected Component**: Maximal connected subgraph.

---

## 🌳 Trees and Forests

- **Tree**: Undirected graph, connected & acyclic.
- **Forest**: Undirected graph with no cycles.
- Components of a forest are **trees**.

---

## 🌲 Spanning Trees and Forests

- **Spanning Tree**: Tree subgraph containing all vertices of a connected graph.
- Not unique unless graph is already a tree.
- Used in network design.

---

## 🔁 Graph Traversals

- Goal: Visit all vertices/edges.
- **DFS** (Depth-First Search): Recursive strategy, akin to navigating a maze with thread & paint:
  - Mark visited nodes
  - Backtrack on revisits
  - Explore unexplored paths

---

## 💡 DFS Algorithm

### DFS(G, v)
```pseudo
setLabel(v, VISITED)
for each edge e incident on v:
  if e is UNEXPLORED:
    w ← opposite(v, e)
    if w is UNEXPLORED:
      label e as DISCOVERY
      DFS(G, w)
    else:
      label e as BACK
```

### DFS(G)
```pseudo
for each vertex u:
  label u UNEXPLORED
for each edge e:
  label e UNEXPLORED
for each vertex v:
  if v is UNEXPLORED:
    DFS(G, v)
```

---

## 🧪 DFS Applications

- Visit all vertices/edges
- Check if G is connected
- Compute spanning tree (if connected)
- Compute spanning forest (if disconnected)
- Find connected components
- Find a path between two vertices
- Detect cycles

---

## ⏱️ DFS Time Complexity

- DFS called once per vertex
- Each edge examined twice → O(n + 2m) = **O(n + m)**

### Assumes:
- Labeling and incident edge queries run in constant time.
- Efficient data structure (e.g., adjacency list).

---

## 🧭 Maze Analogy

- Mark intersections and dead ends (nodes)
- Mark corridors (edges)
- Use rope/stack to track the return path

---

## 📐 DFS Properties

**Property 1**: DFS visits all vertices in a connected component.

**Property 2**: DFS discovery edges form a **spanning tree**.

---

## 🧱 DFS for Path Finding

Use stack to track path between `u` and `z`:

```pseudo
Algorithm pathDFS(G, v, z)
  setLabel(v, VISITED)
  S.push(v)
  if v == z: return S.elements()
  for each edge e incident on v:
    if e is UNEXPLORED:
      w ← opposite(v, e)
      if w is UNEXPLORED:
        label e DISCOVERY
        S.push(e)
        pathDFS(G, w, z)
        S.pop(e)
      else:
        label e BACK
  S.pop(v)
```

---

## 🔁 DFS for Cycle Finding

Use stack to backtrack on encountering a **back edge**:

```pseudo
Algorithm cycleDFS(G, v, z)
  setLabel(v, VISITED)
  S.push(v)
  for each edge e incident on v:
    if e is UNEXPLORED:
      w ← opposite(v, e)
      S.push(e)
      if w is UNEXPLORED:
        label e DISCOVERY
        cycleDFS(G, w, z)
        S.pop(e)
      else:
        T ← empty stack
        repeat:
          o ← S.pop()
          T.push(o)
        until o == w
        return T.elements()
  S.pop(v)
```

---
