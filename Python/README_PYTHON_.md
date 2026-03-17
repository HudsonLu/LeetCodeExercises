Here’s a solid **Python recap sheet** with the main things you’ll use most often.

---

# Python Overview

## 1. Variables and basic types

```python
x = 10              # int
y = 3.14            # float
name = "Hudson"     # str
is_ready = True     # bool
nothing = None      # NoneType
```

Python is **dynamically typed**, so you do not write the type when declaring variables.

```python
a = 5
a = "hello"
```

Use `type()` to check the type:

```python
print(type(5))        # <class 'int'>
print(type("abc"))    # <class 'str'>
```

---

## 2. Input / Output

## Print

```python
print("Hello")
print("Age:", 21)
```

Formatted output:

```python
name = "Hudson"
age = 22
print(f"My name is {name} and I am {age} years old.")
```

## Input

```python
name = input("Enter your name: ")
print(name)
```

`input()` always returns a string, so convert if needed:

```python
age = int(input("Enter age: "))
height = float(input("Enter height: "))
```

---

# 3. Strings

A string is text.

```python
s = "hello"
```

## Access characters

```python
print(s[0])   # h
print(s[-1])  # o
```

## Slicing

```python
print(s[0:2])   # he
print(s[1:4])   # ell
print(s[:3])    # hel
print(s[2:])    # llo
print(s[::-1])  # olleh
```

## Common string methods

```python
s = " hello world "

print(s.strip())       # remove spaces at both ends
print(s.lower())       # lowercase
print(s.upper())       # uppercase
print(s.replace("world", "Python"))
print(s.split())       # split by spaces
print("a,b,c".split(","))

print("hello".startswith("he"))  # True
print("hello".endswith("lo"))    # True
print("123".isdigit())           # True
print("abc".isalpha())           # True
print("abc123".isalnum())        # True
```

## Join strings

```python
words = ["I", "love", "Python"]
result = " ".join(words)
print(result)   # I love Python
```

## String formatting

```python
name = "Hudson"
score = 95
print(f"{name} got {score}")
```

---

# 4. Lists (Python’s most common array-like structure)

Python does not have Java/C-style arrays as the main default. Usually you use **lists**.

```python
nums = [1, 2, 3, 4]
names = ["Alice", "Bob"]
mixed = [1, "hi", True]
```

## Access and modify

```python
print(nums[0])   # 1
nums[1] = 99
print(nums)      # [1, 99, 3, 4]
```

## Common list methods

```python
nums = [1, 2, 3]

nums.append(4)        # add at end
nums.insert(1, 10)    # insert at index
nums.remove(2)        # remove first occurrence
last = nums.pop()     # remove and return last
nums.sort()           # sort ascending
nums.reverse()        # reverse list
```

## Useful operations

```python
print(len(nums))         # length
print(3 in nums)         # membership
print(nums.count(3))     # count occurrences
print(nums.index(3))     # first index of 3
```

## Slicing lists

```python
arr = [10, 20, 30, 40, 50]
print(arr[1:4])   # [20, 30, 40]
print(arr[:3])    # [10, 20, 30]
print(arr[::2])   # [10, 30, 50]
```

---

# 5. Tuples

A tuple is like a list, but **immutable**.

```python
point = (3, 4)
print(point[0])   # 3
```

You cannot modify it:

```python
# point[0] = 10   # error
```

Useful when data should not change.

---

# 6. Dictionaries

Dictionary = key-value pairs, like a hash map.

```python
student = {
    "name": "Hudson",
    "age": 22,
    "grade": "A"
}
```

## Access values

```python
print(student["name"])
print(student.get("age"))
```

`get()` is safer because it returns `None` instead of crashing if key does not exist.

```python
print(student.get("email"))   # None
```

## Add / update

```python
student["age"] = 23
student["email"] = "test@gmail.com"
```

## Remove

```python
student.pop("grade")
del student["age"]
```

## Common methods

```python
print(student.keys())
print(student.values())
print(student.items())
```

Loop through dictionary:

```python
for key in student:
    print(key, student[key])

for key, value in student.items():
    print(key, value)
```

---

# 7. Sets

A set stores **unique values**.

```python
nums = {1, 2, 3, 3, 3}
print(nums)   # {1, 2, 3}
```

Common methods:

```python
nums.add(4)
nums.remove(2)
print(3 in nums)
```

Useful for removing duplicates or fast membership checks.

---

# 8. Conditions

```python
x = 10

if x > 5:
    print("big")
elif x == 5:
    print("equal")
else:
    print("small")
```

Logical operators:

```python
and
or
not
```

Example:

```python
if age >= 18 and age < 65:
    print("working age")
```

---

# 9. Loops

## For loop

```python
for i in range(5):
    print(i)   # 0 1 2 3 4
```

```python
for i in range(1, 6):
    print(i)   # 1 to 5
```

Loop through list:

```python
nums = [10, 20, 30]
for n in nums:
    print(n)
```

Loop with index:

```python
for i, value in enumerate(nums):
    print(i, value)
```

## While loop

```python
x = 0
while x < 5:
    print(x)
    x += 1
```

## break / continue

```python
for i in range(10):
    if i == 5:
        break
```

```python
for i in range(5):
    if i == 2:
        continue
    print(i)
```

---

# 10. Functions

```python
def greet(name):
    return f"Hello, {name}"
```

```python
print(greet("Hudson"))
```

## Default parameters

```python
def power(base, exp=2):
    return base ** exp

print(power(3))     # 9
print(power(3, 3))  # 27
```

## Multiple return values

```python
def calc(a, b):
    return a + b, a - b

x, y = calc(10, 5)
print(x, y)
```

---

# 11. List comprehensions

A compact way to build lists.

```python
squares = [x * x for x in range(5)]
print(squares)   # [0, 1, 4, 9, 16]
```

With condition:

```python
evens = [x for x in range(10) if x % 2 == 0]
```

---

# 12. Common built-in functions

```python
print(len([1, 2, 3]))   # 3
print(max([1, 5, 2]))   # 5
print(min([1, 5, 2]))   # 1
print(sum([1, 2, 3]))   # 6
print(sorted([3, 1, 2]))  # [1, 2, 3]
```

Conversions:

```python
int("123")
float("3.14")
str(100)
list("abc")   # ['a', 'b', 'c']
```

---

# 13. Indexing summary

Works for strings, lists, tuples.

```python
arr = [10, 20, 30, 40]

arr[0]    # first
arr[-1]   # last
arr[1:3]  # index 1 to 2
```

---

# 14. Mutability

Important concept:

## Mutable

Can change:

* list
* dict
* set

## Immutable

Cannot change:

* str
* tuple
* int
* float
* bool

Example:

```python
s = "hello"
# s[0] = "H"   # error
```

But:

```python
nums = [1, 2, 3]
nums[0] = 99
```

---

# 15. Files

## Write to file

```python
with open("test.txt", "w") as f:
    f.write("Hello\n")
    f.write("World\n")
```

## Read file

```python
with open("test.txt", "r") as f:
    content = f.read()
    print(content)
```

Read line by line:

```python
with open("test.txt", "r") as f:
    for line in f:
        print(line.strip())
```

---

# 16. Exception handling

```python
try:
    x = int(input("Enter a number: "))
    print(10 / x)
except ValueError:
    print("Invalid integer")
except ZeroDivisionError:
    print("Cannot divide by zero")
```

---

# 17. Classes and objects

```python
class Student:
    def __init__(self, name, age):
        self.name = name
        self.age = age

    def greet(self):
        print(f"Hi, I am {self.name}")
```

Use it:

```python
s1 = Student("Hudson", 22)
s1.greet()
```

---

# 18. Useful operators

```python
+   -   *   /   //   %   **
```

Examples:

```python
print(7 / 2)   # 3.5
print(7 // 2)  # 3
print(7 % 2)   # 1
print(2 ** 3)  # 8
```

Comparison:

```python
==  !=  >  <  >=  <=
```

---

# 19. Truthy and falsy values

Falsy values include:

```python
False
None
0
0.0
""
[]
{}
set()
```

Example:

```python
if not []:
    print("empty")
```

---

# 20. Common interview / beginner patterns

## Loop through string

```python
for ch in "hello":
    print(ch)
```

## Count frequency with dict

```python
s = "banana"
freq = {}

for ch in s:
    freq[ch] = freq.get(ch, 0) + 1

print(freq)
```

## Reverse string

```python
s = "hello"
print(s[::-1])
```

## Find max in list

```python
nums = [3, 8, 2, 10]
print(max(nums))
```

## Remove duplicates

```python
nums = [1, 2, 2, 3, 1]
unique = list(set(nums))
print(unique)
```

---

# 21. Python naming style

Usually:

* `snake_case` for variables and functions
* `PascalCase` for classes
* constants often written as `UPPER_CASE`

Example:

```python
user_name = "Hudson"

def get_total():
    pass

class BankAccount:
    pass

PI = 3.14159
```

---

# 22. Very common methods to remember

## Strings

```python
lower(), upper(), strip(), replace(), split(), join(), find(), startswith(), endswith()
```

## Lists

```python
append(), insert(), remove(), pop(), sort(), reverse(), index(), count()
```

## Dicts

```python
get(), keys(), values(), items(), pop(), update()
```

## Sets

```python
add(), remove(), discard()
```

---

# 23. Small all-in-one example

```python
name = input("Enter your name: ")
scores = [80, 90, 100]

student = {
    "name": name,
    "scores": scores
}

average = sum(student["scores"]) / len(student["scores"])

print(f"Student: {student['name']}")
print(f"Scores: {student['scores']}")
print(f"Average: {average}")
```

---

# 24. Quick comparison table

## String

Text, immutable

```python
s = "hello"
```

## List

Ordered, mutable

```python
arr = [1, 2, 3]
```

## Tuple

Ordered, immutable

```python
t = (1, 2, 3)
```

## Dict

Key-value, mutable

```python
d = {"a": 1, "b": 2}
```

## Set

Unique values, mutable

```python
st = {1, 2, 3}
```

---

# 25. Best things to memorize first

Focus on these first:

* `input()`, `print()`
* strings: slicing, `split()`, `join()`, `replace()`
* lists: `append()`, `pop()`, `sort()`
* dict: `get()`, looping with `items()`
* loops: `for`, `while`, `range()`
* functions: `def`, `return`
* conditions: `if / elif / else`
* list comprehensions
* file reading/writing
* try/except

---

# 26. Tiny cheat sheet

```python
# string
s = "hello"
s[0]
s[::-1]
s.upper()
s.split()

# list
arr = [1, 2, 3]
arr.append(4)
arr.pop()
len(arr)

# dict
d = {"a": 1}
d["a"]
d.get("b", 0)
for k, v in d.items():
    print(k, v)

# loop
for i in range(5):
    print(i)

# function
def add(a, b):
    return a + b
```

If you want, I can also make you a **Python recap README-style version** like I did for C#/SQL, with cleaner sections and more examples for interview/LeetCode use.
