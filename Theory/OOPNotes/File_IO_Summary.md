
# 📂 File I/O in Java – Summary

### Author: Dr. Aiman Hanna, Concordia University

---

## 📌 Topics Covered

- Streams: Input & Output
- Text vs Binary Files
- Writing/Reading Text Files
- Exception Handling in File I/O
- BufferedReader & Scanner
- Appending, Path Names, and File Class
- Binary File Handling (Object Streams)
- Random Access Files
- Serializable Interface

---

## 🔁 Streams

- A **stream** connects a program to a file/device for data flow.
- Input stream: flows **into** the program (e.g., `System.in`).
- Output stream: flows **out** of the program (e.g., `System.out`).

```java
Scanner kb = new Scanner(System.in); // input stream from keyboard
System.out.println("Text"); // output to screen
```

---

## 📜 Text vs Binary Files

| Type       | Readable | Portable | Efficient |
|------------|----------|----------|-----------|
| Text File  | Yes      | Yes      | No        |
| Binary File| No       | Yes (Java) | Yes     |

- Text files use ASCII encoding; binary files use native machine format.
- Binary files require Java-specific tools for compatibility.

---

## ✍️ Writing to Text Files

```java
PrintWriter pw = new PrintWriter(new FileOutputStream("file.txt"));
pw.println("Hello");
pw.close();
```

- Uses `java.io` classes.
- Must close file to flush buffer & release resources.
- Use `flush()` or `close()` to ensure all data is written.

---

## 🔐 FileNotFoundException

- Thrown if file can’t be opened or created.
- Wrap file operations in `try-catch` blocks.

```java
PrintWriter pw = null;
try {
  pw = new PrintWriter(new FileOutputStream("file.txt"));
  pw.println("Hello");
} catch (FileNotFoundException e) {
  System.out.println("Error opening file");
} finally {
  if (pw != null) pw.close();
}
```

---

## ➕ Appending to Files

```java
PrintWriter pw = new PrintWriter(new FileOutputStream("file.txt", true));
```

- Second argument `true` enables appending.

---

## 📥 Reading from Text Files

### Using Scanner:
```java
Scanner sc = new Scanner(new FileInputStream("file.txt"));
while (sc.hasNextLine()) {
  String line = sc.nextLine();
}
```

### Using BufferedReader:
```java
BufferedReader br = new BufferedReader(new FileReader("file.txt"));
String line;
while ((line = br.readLine()) != null) {
  // process line
}
```

---

## 📌 Paths and File Names

- Use full or relative path names.
- Windows: use `\` or forward slashes (`C:/path/to/file.txt`)
- UNIX: `/home/user/file.txt`

```java
BufferedReader reader = new BufferedReader(new FileReader("C:/Comp249/data.txt"));
```

---

## 🗃️ File Class

- Wraps file names and provides file-related metadata.

```java
File f = new File("data.txt");
f.exists();
f.length();
```

---

## 💾 Binary File I/O

### Writing:
```java
ObjectOutputStream out = new ObjectOutputStream(new FileOutputStream("file.bin"));
out.writeInt(42);
out.writeObject(myObj);
out.close();
```

### Reading:
```java
ObjectInputStream in = new ObjectInputStream(new FileInputStream("file.bin"));
int x = in.readInt();
MyClass obj = (MyClass) in.readObject();
```

### Exceptions:
- `EOFException` → signals end of file.
- Always handle with `try-catch`.

---

## 🔁 Random Access Files

```java
RandomAccessFile raf = new RandomAccessFile("file.bin", "rw");
raf.seek(0); // move pointer
raf.writeInt(123);
raf.seek(0);
int value = raf.readInt();
raf.close();
```

- Supports `readInt`, `readUTF`, `writeUTF`, etc.
- Use for fast record access in large files.

---

## 📦 Serializable Interface

```java
class MyClass implements Serializable { ... }
```

- Required for object serialization.
- All fields and composed classes must also be serializable.

---

## ✅ Summary Table

| Topic               | Key Points |
|---------------------|------------|
| Streams             | Objects to move data |
| Text Files          | Human-readable |
| Binary Files        | Machine-readable, efficient |
| Scanner/BufferedReader | For reading text |
| PrintWriter         | For writing text |
| Object Streams      | For reading/writing objects |
| RandomAccessFile    | Direct file access |
| Exception Handling  | Always close streams safely |
| Serializable        | Required for object I/O |

---
