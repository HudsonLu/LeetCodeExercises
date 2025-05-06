
# 📊 Graphs – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Graph Definitions & Applications
- Edge Types (Directed, Undirected, Mixed)
- Graph Terminology
- Graph Properties
- Graph ADT & Main Methods
- Graph Representations (Edge List, Adjacency List, Adjacency Matrix)
- Performance Comparison

---

## 🔗 What is a Graph?

- A **graph** G = (V, E) consists of:
  - `V`: set of **vertices** (nodes)
  - `E`: set of **edges** (connections between vertices)
- Vertices and edges can store values (e.g., airport code, distance).

### Example:
- Airports as vertices
- Flights as directed/undirected edges with distances

---

## ➿ Edge Types

- **Directed Edge**: (u, v) → from u (origin) to v (destination)
- **Undirected Edge**: (u, v) unordered → no direction
- **Mixed Graph**: has both directed and undirected edges

---

## 🧭 Applications

- **Circuits**: PCB, ICs
- **Transport**: road, flight networks
- **Networks**: LAN, Internet, Web
- **Databases**: ER diagrams

---

## 📘 Terminology

| Term            | Meaning |
|------------------|--------|
| Endpoints        | Vertices of an edge |
| Adjacent         | Vertices connected by an edge |
| Incident         | An edge is incident on its endpoints |
| Degree deg(v)    | # of incident edges |
| In-degree        | # of incoming directed edges |
| Out-degree       | # of outgoing directed edges |
| Parallel edges   | Same endpoints |
| Self-loop        | Edge connecting a vertex to itself |
| Path             | Sequence of alternating vertices and edges |
| Simple path      | No repeated vertices/edges |
| Cycle            | Path that starts/ends at the same vertex |
| Simple cycle     | Cycle with distinct vertices and edges |
| Subgraph         | Subset of graph (vertices + edges) |
| Spanning subgraph| Subgraph with all vertices |
| Connected graph  | Path between any 2 vertices exists |
| Tree             | Connected acyclic graph |
| Forest           | Disconnected acyclic graph |
| Spanning Tree    | Tree covering all vertices of G |

---

## 📐 Graph Properties

Assume simple graph with `n` vertices and `m` edges.

- **Property 1**: ∑ deg(v) = 2m
- **Property 2 (Directed)**: ∑ in-deg(v) = ∑ out-deg(v) = m
- **Property 3**: `m ≤ n(n − 1)/2` for undirected graphs

---

## 🛠️ Graph ADT Methods

### Accessors
- `endVertices(e)`
- `opposite(v, e)`
- `areAdjacent(v, w)`
- `replace(v, x)`, `replace(e, x)`

### Updaters
- `insertVertex(x)`, `insertEdge(v, w, x)`
- `removeVertex(v)`, `removeEdge(e)`

### Iterable Methods
- `vertices()`, `edges()`
- `incidentEdges(v)`

---

## 🗂️ Graph Representations

### 1. Edge List
- Vertices and edges stored in collections V and E
- Simple but poor performance for adjacency/incident queries

### 2. Adjacency List
- Each vertex has list of incident edges
- Efficient for sparse graphs

### 3. Adjacency Matrix
- Matrix A[i][j] stores edge info between vertex i and j
- Fast adjacency check, expensive for sparse graphs

---

## 📊 Performance Comparison

| Operation           | Edge List | Adjacency List | Adjacency Matrix |
|---------------------|-----------|----------------|------------------|
| Space               | O(n + m)  | O(n + m)       | O(n²)            |
| `incidentEdges(v)`  | O(m)      | O(deg(v))      | O(n)             |
| `areAdjacent(v, w)` | O(m)      | O(min(deg(v), deg(w))) | O(1)     |
| `insertVertex(x)`   | O(1)      | O(1)           | O(n²)            |
| `removeVertex(v)`   | O(m)      | O(deg(v))      | O(n²)            |

---
