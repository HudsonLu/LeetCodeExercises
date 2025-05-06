# Binary Search

```bash
public class BinarySearch {
    public static int binarySearch(int[] array, int target) {
        int left = 0;
        int right = array.length - 1;

        while (left <= right) {
            int mid = (left + right) / 2;

            if (array[mid] == target) {
                return mid;
            } else if (array[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return -1; // target not found
    }

    public static void main(String[] args) {
        int[] arr = {1, 3, 5, 7, 9, 11};
        int target = 7;
        int result = binarySearch(arr, target);

        if (result != -1) {
            System.out.println("Target found at index: " + result);
        } else {
            System.out.println("Target not found in the array.");
        }
    }
}
```

Binary search is a divide-and-conquer algorithm that repeatedly divides the search interval in half to locate a target value within a sorted array.

### Algorithm Steps

1. **Initialization**:  
   Set two pointers, `low` and `high`, at the beginning and end of the array, respectively.

2. **Midpoint Calculation**:  
   Compute the midpoint index:  
   `mid = (low + high) / 2`

3. **Comparison**:  
   Compare the target value with the element at the `mid` index:

   - If equal, the target is found.
   - If the target is less than the midpoint value, adjust `high` to `mid - 1`.
   - If the target is greater, adjust `low` to `mid + 1`.

4. **Iteration**:  
   Repeat the process until the target is found or the `low` pointer exceeds the `high` pointer.

### Time Complexity

The algorithm operates in **O(log n)** time, making it significantly more efficient than linear search methods for large datasets.

`Note!` Binary search assumes the array is sorted — typically in ascending order.

# Breadth-first Search

```bash
import java.util.*;

public class BFSExample {
    public static void bfs(Map<String, List<String>> graph, String start) {
        List<String> visited = new ArrayList<>();
        Queue<String> queue = new LinkedList<>();

        visited.add(start);
        queue.add(start);

        while (!queue.isEmpty()) {
            String s = queue.poll();
            System.out.print(s + " ");

            for (String neighbor : graph.get(s)) {
                if (!visited.contains(neighbor)) {
                    visited.add(neighbor);
                    queue.add(neighbor);
                }
            }
        }
    }

    public static void main(String[] args) {
        Map<String, List<String>> graph = new HashMap<>();
        graph.put("A", Arrays.asList("B", "C"));
        graph.put("B", Arrays.asList("D", "E", "F"));
        graph.put("C", Arrays.asList("G"));
        graph.put("D", new ArrayList<>());
        graph.put("E", new ArrayList<>());
        graph.put("F", Arrays.asList("H"));
        graph.put("G", Arrays.asList("I"));
        graph.put("H", new ArrayList<>());
        graph.put("I", new ArrayList<>());

        bfs(graph, "A");
    }
}
```

BFS is a graph traversal algorithm that explores all the neighbor nodes at the present depth prior to moving on to the nodes at the next depth level. It uses a **queue** (FIFO) data structure to keep track of the nodes to be explored.
<br>
`Note!` Breadth means wide

### Algorithm Steps

1. **Initialization**:  
   Start by placing the root node into a queue.

2. **Exploration**:  
   While the queue is not empty:

   - Dequeue the front node.
   - Visit the node.
   - Enqueue all **unvisited neighboring nodes**.

3. **Termination**:  
   The process continues until the queue is empty, meaning all reachable nodes have been visited.

### Use Cases

BFS is particularly useful for:

- Finding the **shortest path** in unweighted graphs.
- Performing **level-order traversal** in trees.
- Applications in **peer-to-peer networks**, **web crawlers**, and **social networks**.

### Time Complexity

The time complexity of BFS is **O(V + E)**, where:

- `V` is the number of vertices,
- `E` is the number of edges in the graph.

## Depth-First Search (DFS)

```bash
import java.util.*;

public class DFSExample {
    public static void dfs(Map<String, List<String>> graph, String start) {
        List<String> visited = new ArrayList<>();
        Deque<String> stack = new ArrayDeque<>();

        visited.add(start);
        stack.push(start);

        while (!stack.isEmpty()) {
            String current = stack.pop();
            System.out.print(current + " ");

            // Reverse neighbors to match Python's reversed(graph[s]) behavior
            List<String> neighbors = graph.get(current);
            ListIterator<String> it = neighbors.listIterator(neighbors.size());
            while (it.hasPrevious()) {
                String neighbor = it.previous();
                if (!visited.contains(neighbor)) {
                    visited.add(neighbor);
                    stack.push(neighbor);
                }
            }
        }
    }

    public static void main(String[] args) {
        Map<String, List<String>> graph = new HashMap<>();
        graph.put("A", Arrays.asList("B", "G"));
        graph.put("B", Arrays.asList("C", "D", "E"));
        graph.put("C", new ArrayList<>());
        graph.put("D", new ArrayList<>());
        graph.put("E", Arrays.asList("F"));
        graph.put("F", new ArrayList<>());
        graph.put("G", Arrays.asList("H"));
        graph.put("H", Arrays.asList("I"));
        graph.put("I", new ArrayList<>());

        dfs(graph, "A");
    }
}
```

Depth-First Search (DFS) is a graph traversal algorithm that explores as far as possible along each branch before backtracking. It utilizes a **stack** (FIFO) data structure, either explicitly or via recursion, to keep track of the nodes to be explored.
<br>

`Note!` Depth means vertical before horizontal stack

### Algorithm Steps

1. **Initialization**:  
   Start by placing the root (or starting) node into a stack or initiating a recursive call.

2. **Exploration**:  
   While the stack is not empty (or during recursive calls):

   - Pop the top node from the stack (or process the current node in recursion).
   - If the node has not been visited:
     - Mark it as visited.
     - Push all unvisited neighboring nodes onto the stack (or recursively visit them).

3. **Termination**:  
   The process continues until the stack is empty (or all recursive calls have completed), meaning all reachable nodes have been visited.

### Use Cases

DFS is particularly useful for:

- **Pathfinding** in mazes and puzzles
- **Cycle detection** in graphs
- **Topological sorting** in DAGs
- **Solving puzzles** like Sudoku
- **Analyzing networks** (e.g., social graphs, web crawlers)

### Time Complexity

The time complexity of DFS is **O(V + E)**, where:

- `V` is the number of vertices
- `E` is the number of edges in the graph

# Conclusion

| Goal                         | Best Choice      |
| ---------------------------- | ---------------- |
| Search in sorted array       | ✅ Binary Search |
| Shortest path in graph       | ✅ BFS           |
| Explore all possible paths   | ✅ DFS           |
| Less memory, fewer neighbors | ✅ DFS           |
| Want shortest solution fast  | ✅ BFS           |

| Feature                 | **Binary Search**                               | **Breadth-First Search (BFS)**                                           | **Depth-First Search (DFS)**                          |
| ----------------------- | ----------------------------------------------- | ------------------------------------------------------------------------ | ----------------------------------------------------- |
| **Data Structure**      | Array (sorted)                                  | Graph or Tree                                                            | Graph or Tree                                         |
| **Traversal Strategy**  | Divide and conquer                              | Level by level (breadth-wise)                                            | Path by path (depth-wise)                             |
| **Auxiliary Structure** | None (uses indices)                             | Queue                                                                    | Stack or Recursion                                    |
| **Time Complexity**     | O(log n)                                        | O(V + E)                                                                 | O(V + E)                                              |
| **Space Complexity**    | O(1)                                            | O(V)                                                                     | O(V)                                                  |
| **Optimal For**         | Searching in sorted arrays                      | Finding shortest path in unweighted graphs                               | Exploring all paths; cycle detection                  |
| **Use Cases**           | - Search in sorted arrays<br>- Efficient lookup | - Shortest path in unweighted graphs<br>- Level-order traversal in trees | - Topological sorting<br>- Solving puzzles like mazes |
| **Limitations**         | Requires sorted data                            | Can consume more memory in wide graphs                                   | May get trapped in deep or infinite paths             |
