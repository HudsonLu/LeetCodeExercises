
# ⚠️ Exception Handling – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- try-throw-catch Mechanism
- Exception Class Hierarchy
- Custom Exception Classes
- throws Clause
- Catch or Declare Rule
- Multiple catch Blocks
- Checked vs Unchecked Exceptions
- finally Block and Nested try-catch
- AssertionError and Controlled Loops

---

## 🎯 What is Exception Handling?

- Handles **unexpected or exceptional** cases in code.
- Mechanism to **throw** and **catch** error conditions.

### Terminology
- **Throwing** an exception: using `throw new ExceptionType()`
- **Catching**: using `catch(Exception e)`

---

## 🔁 try-throw-catch Structure

```java
try {
  // Code that may throw an exception
} catch (Exception e) {
  // Code to handle the exception
}
```

- `try`: contains normal code and possibly throw statements
- `throw`: initiates an exception
- `catch`: handles the thrown exception

---

## 🧱 Exception Classes

- Base class: `Exception`
- Examples: `IOException`, `FileNotFoundException`, etc.
- Can be **extended** to define **custom exceptions**.

### Custom Exception Example

```java
class MyException extends Exception {
  public MyException(String message) {
    super(message);
  }
}
```

---

## ✋ Declaring Exceptions

- Methods can declare exceptions using the **throws clause**:
```java
public void aMethod() throws IOException, SQLException
```

- Declaring shifts responsibility to the caller.

---

## ⚖️ Catch or Declare Rule

1. Use `try-catch` to handle exceptions locally.
2. Use `throws` to defer handling to the caller.

- Every exception must be caught **or** declared.
- Methods can mix both, but must **not ignore** exceptions.

---

## 🧩 Multiple catch Blocks

```java
try {
  // code
} catch (IOException e) {
  // specific
} catch (Exception e) {
  // generic
}
```

- Always catch **more specific exceptions first**.

---

## 🧪 Checked vs Unchecked Exceptions

| Type                | Description                    | Must be caught? |
|---------------------|--------------------------------|------------------|
| Checked Exceptions  | Subclass of Exception          | ✅ Yes           |
| Unchecked Exceptions| Subclass of RuntimeException   | ❌ No            |
| Errors              | Subclass of Error              | ❌ No            |

Examples:
- `InputMismatchException`: unchecked
- `IOException`: checked

---

## 🧱 finally Block

- Executes regardless of whether exception is thrown or caught.

```java
try {
  // risky code
} catch (Exception e) {
  // handle
} finally {
  // always executes
}
```

### Cases:
1. Try runs completely → finally runs.
2. Try throws → catch handles → finally runs.
3. Try throws → no catch → finally runs.

---

## 🔁 Nested try-catch

- Inner try-catch can exist inside outer try/catch.
- Uncaught exceptions in inner block may propagate to outer.

### Tip:
- Use distinct names for exception variables in nested blocks.

---

## 🔁 Rethrowing Exceptions

```java
catch (Exception e) {
  if (e.getMessage().equals("critical")) {
    throw e;
  }
}
```

- Useful when higher-level logic needs to handle specific cases.

---

## 🧪 AssertionError

- Thrown when `assert` fails.
- Unchecked exception derived from `Error`.

---

## 🔁 Exception-Controlled Loops

```java
boolean done = false;
while (!done) {
  try {
    // code that may throw
    done = true;
  } catch (SomeException e) {
    // retry logic
  }
}
```

- Retry mechanism using exceptions.

---

## 🧠 Summary

| Feature          | Key Idea                            |
|------------------|--------------------------------------|
| try-catch        | Basic exception handling block       |
| throw            | Initiate an exception                |
| throws           | Declare exceptions a method may throw|
| finally          | Always executes                      |
| Checked Exception| Must be declared/caught              |
| Unchecked        | Runtime exceptions                   |
| Rethrow          | Pass exception to higher handler     |
| Custom Exception | Extend Exception base class          |

---
