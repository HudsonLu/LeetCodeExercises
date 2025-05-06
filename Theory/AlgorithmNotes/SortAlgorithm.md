| Algorithm          | Time Complexity (Best / Avg / Worst) | Space Complexity | Stable | In-place | Best For                                    |
| ------------------ | ------------------------------------ | ---------------- | ------ | -------- | ------------------------------------------- |
| **Merge Sort**     | O(n log n) / O(n log n) / O(n log n) | O(n)             | ✅ Yes | ❌ No    | Large datasets, stable sort needs           |
| **Quick Sort**     | O(n log n) / O(n log n) / O(n²)      | O(log n)         | ❌ No  | ✅ Yes   | Fast average-case sorting                   |
| **Bubble Sort**    | O(n) / O(n²) / O(n²)                 | O(1)             | ✅ Yes | ✅ Yes   | Simple, small or nearly sorted data         |
| **Insertion Sort** | O(n) / O(n²) / O(n²)                 | O(1)             | ✅ Yes | ✅ Yes   | Small or nearly sorted data                 |
| **Selection Sort** | O(n²) / O(n²) / O(n²)                | O(1)             | ❌ No  | ✅ Yes   | Simplicity; not suitable for large datasets |
| **Heap Sort**      | O(n log n) / O(n log n) / O(n log n) | O(1)             | ❌ No  | ✅ Yes   | When constant space is needed; not stable   |

| Use Case                                    | Recommended Algorithm                               | Why?                                        |
| ------------------------------------------- | --------------------------------------------------- | ------------------------------------------- |
| Large, general-purpose sorting              | **Merge Sort** or **Quick Sort**                    | Merge is stable; Quick is faster on average |
| Small or nearly sorted array                | **Insertion Sort**                                  | Very efficient for small datasets           |
| Need constant memory (in-place)             | **Quick Sort**, **Heap Sort**                       | Don’t use Merge Sort (needs O(n) space)     |
| Need stable sort (preserve order of equals) | **Merge Sort**, **Bubble Sort**, **Insertion Sort** | Others like Quick/Heap are unstable         |
| Teaching or simplicity                      | **Selection Sort**, **Bubble Sort**                 | Easy to understand but inefficient          |
| Sorting in real-time/limited memory systems | **Heap Sort**                                       | Predictable O(n log n) time, in-place       |

## 📈 Best Time Complexities Among Common Sorting Algorithms:

| Algorithm      | Best Case  | Average Case | Worst Case | Notes                           |
| -------------- | ---------- | ------------ | ---------- | ------------------------------- |
| **Merge Sort** | O(n log n) | O(n log n)   | O(n log n) | Stable, but needs O(n) space    |
| **Quick Sort** | O(n log n) | O(n log n)   | O(n²)      | Very fast in practice, in-place |
| **Heap Sort**  | O(n log n) | O(n log n)   | O(n log n) | In-place but not stable         |
