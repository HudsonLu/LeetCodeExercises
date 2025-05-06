# 📄 .gitignore Syntax Guide

## 🔹 Basic Patterns

| Pattern            | Meaning                                                 |
| ------------------ | ------------------------------------------------------- |
| `*.log`            | Ignore all `.log` files                                 |
| `build/`           | Ignore the entire `build` directory                     |
| `*.class`          | Ignore all `.class` files                               |
| `temp-*.txt`       | Ignore files starting with `temp-` and ending in `.txt` |
| `!important.txt`   | Do **not** ignore `important.txt` (exception)           |
| `/config/`         | Ignore `config/` directory at root only                 |
| `debug.log`        | Ignore the file `debug.log`                             |
| `**/node_modules/` | Ignore all `node_modules` directories recursively       |
| `*.env`            | Ignore all `.env` files                                 |

---

## 🔹 Comments

Use `#` for comments:

```
# Ignore log files
*.log
```

---

## 🔹 Exceptions

Use `!` to **negate** a pattern (i.e., include even if otherwise ignored):

```
*.txt       # ignore all .txt files
!important.txt  # but do not ignore this file
```

---

## 🔹 Wildcards

| Symbol | Use Case                                      |
| ------ | --------------------------------------------- |
| `*`    | Matches 0 or more characters                  |
| `?`    | Matches 1 character                           |
| `**`   | Matches any number of directories recursively |

---

## 🔹 Example .gitignore File

```
# Compiled source #
*.class

# Logs #
*.log

# OS Files #
.DS_Store

# IDEs #
.vscode/
.idea/

# Build #
/build/
/dist/

# Env Files #
.env

# Exception #
!keepme.txt
```

---

## 🧪 Test Your .gitignore

Run this command to verify what Git is ignoring:

```bash
git status --ignored
```

---
