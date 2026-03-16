# SQL Quick Recap README

A practical refresher for common SQL syntax and patterns. Good for interviews, school, backend work, and quick review before writing queries again.

---

# 1. What SQL Is

**SQL** = Structured Query Language

Used to:

* query data
* insert data
* update data
* delete data
* create tables/databases
* define relationships
* aggregate and analyze records

Common database systems:

* MySQL
* PostgreSQL
* SQL Server
* SQLite
* Oracle

---

# 2. Basic SQL Query Structure

```sql
SELECT column1, column2
FROM table_name
WHERE condition
GROUP BY column1
HAVING condition
ORDER BY column1;
```

Typical order of writing:

1. `SELECT`
2. `FROM`
3. `WHERE`
4. `GROUP BY`
5. `HAVING`
6. `ORDER BY`
7. `LIMIT`

---

# 3. Create a Table

```sql
CREATE TABLE Students (
    student_id INT PRIMARY KEY,
    name VARCHAR(100),
    age INT,
    major VARCHAR(100)
);
```

## Common data types

* `INT` → integers
* `VARCHAR(n)` → text with max length
* `TEXT` → long text
* `DATE` → date
* `DATETIME` / `TIMESTAMP` → date and time
* `DECIMAL(p, s)` → exact numeric values like money
* `FLOAT` / `DOUBLE` → decimals
* `BOOLEAN` → true/false

---

# 4. Insert Data

```sql
INSERT INTO Students (student_id, name, age, major)
VALUES (1, 'Alice', 20, 'Software Engineering');
```

Insert multiple rows:

```sql
INSERT INTO Students (student_id, name, age, major)
VALUES
(2, 'Bob', 22, 'Computer Science'),
(3, 'Charlie', 21, 'Mathematics');
```

---

# 5. Select All Data

```sql
SELECT * FROM Students;
```

`*` means all columns.

---

# 6. Select Specific Columns

```sql
SELECT name, major
FROM Students;
```

---

# 7. Rename Columns with AS

```sql
SELECT name AS student_name, major AS program
FROM Students;
```

---

# 8. Filter Rows with WHERE

```sql
SELECT *
FROM Students
WHERE age > 20;
```

Examples:

```sql
SELECT *
FROM Students
WHERE major = 'Computer Science';
```

```sql
SELECT *
FROM Students
WHERE age >= 18 AND age <= 25;
```

---

# 9. Comparison Operators

* `=` equal
* `!=` or `<>` not equal
* `>` greater than
* `<` less than
* `>=` greater than or equal
* `<=` less than or equal

Example:

```sql
SELECT *
FROM Students
WHERE age <> 20;
```

---

# 10. AND, OR, NOT

```sql
SELECT *
FROM Students
WHERE major = 'Software Engineering' AND age > 20;
```

```sql
SELECT *
FROM Students
WHERE major = 'Software Engineering' OR major = 'Computer Science';
```

```sql
SELECT *
FROM Students
WHERE NOT age < 18;
```

---

# 11. BETWEEN

```sql
SELECT *
FROM Students
WHERE age BETWEEN 18 AND 22;
```

Inclusive of both ends.

---

# 12. IN

```sql
SELECT *
FROM Students
WHERE major IN ('Software Engineering', 'Computer Science', 'Mathematics');
```

---

# 13. LIKE

Used for pattern matching.

```sql
SELECT *
FROM Students
WHERE name LIKE 'A%';
```

## Common patterns

* `'A%'` → starts with A
* `'%a'` → ends with a
* `'%ann%'` → contains ann
* `'__b%'` → third character is b

Example:

```sql
SELECT *
FROM Students
WHERE name LIKE '%son%';
```

---

# 14. NULL

`NULL` means missing or unknown value.

Find nulls:

```sql
SELECT *
FROM Students
WHERE major IS NULL;
```

Find non-nulls:

```sql
SELECT *
FROM Students
WHERE major IS NOT NULL;
```

Do **not** use:

```sql
WHERE major = NULL
```

Use `IS NULL` instead.

---

# 15. Order Results

```sql
SELECT *
FROM Students
ORDER BY age;
```

Descending:

```sql
SELECT *
FROM Students
ORDER BY age DESC;
```

Multiple columns:

```sql
SELECT *
FROM Students
ORDER BY major ASC, age DESC;
```

---

# 16. Limit Results

## MySQL / PostgreSQL / SQLite

```sql
SELECT *
FROM Students
LIMIT 5;
```

## SQL Server

```sql
SELECT TOP 5 *
FROM Students;
```

---

# 17. Distinct

Get unique values only.

```sql
SELECT DISTINCT major
FROM Students;
```

---

# 18. Update Data

```sql
UPDATE Students
SET major = 'Data Science'
WHERE student_id = 1;
```

Update multiple columns:

```sql
UPDATE Students
SET age = 23, major = 'AI'
WHERE student_id = 2;
```

Be careful: without `WHERE`, all rows are updated.

---

# 19. Delete Data

```sql
DELETE FROM Students
WHERE student_id = 3;
```

Without `WHERE`, all rows are deleted.

---

# 20. Drop Table

```sql
DROP TABLE Students;
```

This removes the table structure and data.

---

# 21. Truncate Table

```sql
TRUNCATE TABLE Students;
```

Removes all rows but keeps the table.

---

# 22. Aggregate Functions

## COUNT

```sql
SELECT COUNT(*)
FROM Students;
```

## SUM

```sql
SELECT SUM(age)
FROM Students;
```

## AVG

```sql
SELECT AVG(age)
FROM Students;
```

## MIN

```sql
SELECT MIN(age)
FROM Students;
```

## MAX

```sql
SELECT MAX(age)
FROM Students;
```

---

# 23. GROUP BY

Used to aggregate rows by category.

```sql
SELECT major, COUNT(*) AS total_students
FROM Students
GROUP BY major;
```

Example:

```sql
SELECT major, AVG(age) AS average_age
FROM Students
GROUP BY major;
```

---

# 24. HAVING

Filters groups after aggregation.

```sql
SELECT major, COUNT(*) AS total_students
FROM Students
GROUP BY major
HAVING COUNT(*) > 1;
```

Difference:

* `WHERE` filters rows before grouping
* `HAVING` filters groups after grouping

---

# 25. Primary Key

A primary key uniquely identifies each row.

```sql
CREATE TABLE Students (
    student_id INT PRIMARY KEY,
    name VARCHAR(100)
);
```

Properties:

* unique
* not null

---

# 26. Auto Increment / Identity

## MySQL

```sql
student_id INT AUTO_INCREMENT PRIMARY KEY
```

## PostgreSQL

```sql
student_id SERIAL PRIMARY KEY
```

## SQL Server

```sql
student_id INT IDENTITY(1,1) PRIMARY KEY
```

---

# 27. Foreign Key

Used to connect tables.

```sql
CREATE TABLE Departments (
    department_id INT PRIMARY KEY,
    department_name VARCHAR(100)
);

CREATE TABLE Employees (
    employee_id INT PRIMARY KEY,
    name VARCHAR(100),
    department_id INT,
    FOREIGN KEY (department_id) REFERENCES Departments(department_id)
);
```

---

# 28. One-to-Many Relationship

Example:

* one department
* many employees

Each employee belongs to one department through a foreign key.

---

# 29. Joins

Very important in SQL.

Assume these tables:

```sql
Employees(employee_id, name, department_id)
Departments(department_id, department_name)
```

## INNER JOIN

Only matching rows.

```sql
SELECT Employees.name, Departments.department_name
FROM Employees
INNER JOIN Departments
ON Employees.department_id = Departments.department_id;
```

## LEFT JOIN

All rows from left table, matching rows from right table.

```sql
SELECT Employees.name, Departments.department_name
FROM Employees
LEFT JOIN Departments
ON Employees.department_id = Departments.department_id;
```

## RIGHT JOIN

All rows from right table, matching rows from left table.

```sql
SELECT Employees.name, Departments.department_name
FROM Employees
RIGHT JOIN Departments
ON Employees.department_id = Departments.department_id;
```

## FULL OUTER JOIN

All rows from both sides.

```sql
SELECT Employees.name, Departments.department_name
FROM Employees
FULL OUTER JOIN Departments
ON Employees.department_id = Departments.department_id;
```

---

# 30. Join Mental Model

* `INNER JOIN` → only matches
* `LEFT JOIN` → everything from left + matches
* `RIGHT JOIN` → everything from right + matches
* `FULL OUTER JOIN` → everything from both

---

# 31. Aliases for Tables

Makes queries cleaner.

```sql
SELECT e.name, d.department_name
FROM Employees e
JOIN Departments d
ON e.department_id = d.department_id;
```

---

# 32. Subqueries

A query inside another query.

```sql
SELECT name
FROM Employees
WHERE department_id = (
    SELECT department_id
    FROM Departments
    WHERE department_name = 'Engineering'
);
```

Subquery with `IN`:

```sql
SELECT name
FROM Employees
WHERE department_id IN (
    SELECT department_id
    FROM Departments
    WHERE department_name LIKE '%Eng%'
);
```

---

# 33. EXISTS

Checks whether a subquery returns rows.

```sql
SELECT name
FROM Departments d
WHERE EXISTS (
    SELECT 1
    FROM Employees e
    WHERE e.department_id = d.department_id
);
```

---

# 34. Create Database

```sql
CREATE DATABASE SchoolDB;
```

Use database:

## MySQL

```sql
USE SchoolDB;
```

---

# 35. Constraints

## NOT NULL

```sql
name VARCHAR(100) NOT NULL
```

## UNIQUE

```sql
email VARCHAR(100) UNIQUE
```

## CHECK

```sql
age INT CHECK (age >= 0)
```

## DEFAULT

```sql
status VARCHAR(20) DEFAULT 'active'
```

---

# 36. Example Table with Constraints

```sql
CREATE TABLE Users (
    user_id INT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    email VARCHAR(100) UNIQUE,
    age INT CHECK (age >= 0),
    status VARCHAR(20) DEFAULT 'active'
);
```

---

# 37. Dates

```sql
SELECT CURRENT_DATE;
SELECT CURRENT_TIMESTAMP;
```

Filter by date:

```sql
SELECT *
FROM Orders
WHERE order_date >= '2026-01-01';
```

---

# 38. Common String Functions

## UPPER / LOWER

```sql
SELECT UPPER(name), LOWER(name)
FROM Students;
```

## LENGTH

```sql
SELECT LENGTH(name)
FROM Students;
```

## CONCAT

```sql
SELECT CONCAT(first_name, ' ', last_name) AS full_name
FROM Employees;
```

## SUBSTRING

```sql
SELECT SUBSTRING(name, 1, 3)
FROM Students;
```

## TRIM

```sql
SELECT TRIM(name)
FROM Students;
```

Note: exact function names can vary by DBMS.

---

# 39. Common Numeric Functions

```sql
SELECT ROUND(AVG(price), 2)
FROM Products;
```

```sql
SELECT ABS(-10);
SELECT CEIL(3.2);
SELECT FLOOR(3.9);
```

---

# 40. CASE

Like if/else in SQL.

```sql
SELECT name,
       age,
       CASE
           WHEN age < 18 THEN 'Minor'
           WHEN age >= 18 THEN 'Adult'
           ELSE 'Unknown'
       END AS category
FROM Students;
```

---

# 41. UNION

Combines result sets.

## UNION

Removes duplicates

```sql
SELECT name FROM Students
UNION
SELECT name FROM Teachers;
```

## UNION ALL

Keeps duplicates

```sql
SELECT name FROM Students
UNION ALL
SELECT name FROM Teachers;
```

---

# 42. Indexes

Used to improve query performance.

```sql
CREATE INDEX idx_student_name
ON Students(name);
```

Unique index:

```sql
CREATE UNIQUE INDEX idx_email
ON Users(email);
```

---

# 43. View

A virtual table based on a query.

```sql
CREATE VIEW EngineeringEmployees AS
SELECT e.name, d.department_name
FROM Employees e
JOIN Departments d
ON e.department_id = d.department_id
WHERE d.department_name = 'Engineering';
```

Use it like a table:

```sql
SELECT * FROM EngineeringEmployees;
```

---

# 44. Transactions

Useful when multiple queries should succeed or fail together.

```sql
BEGIN TRANSACTION;

UPDATE Accounts
SET balance = balance - 100
WHERE account_id = 1;

UPDATE Accounts
SET balance = balance + 100
WHERE account_id = 2;

COMMIT;
```

If something goes wrong:

```sql
ROLLBACK;
```

---

# 45. Common Query Order vs Execution Logic

You write:

```sql
SELECT ...
FROM ...
WHERE ...
GROUP BY ...
HAVING ...
ORDER BY ...
LIMIT ...
```

But conceptually SQL processes like:

1. `FROM`
2. `JOIN`
3. `WHERE`
4. `GROUP BY`
5. `HAVING`
6. `SELECT`
7. `ORDER BY`
8. `LIMIT`

This helps explain why aliases from `SELECT` often cannot be used in `WHERE`.

---

# 46. Most Common Mistakes

## Forgetting WHERE in UPDATE/DELETE

Bad:

```sql
UPDATE Students
SET age = 100;
```

This updates every row.

## Using = NULL

Bad:

```sql
WHERE name = NULL
```

Correct:

```sql
WHERE name IS NULL
```

## Mixing WHERE and HAVING

* `WHERE` for rows
* `HAVING` for grouped results

## Not understanding joins

Always know:

* which table is left
* which table is right
* what key matches them

---

# 47. Practical Examples

## Find all students older than 20

```sql
SELECT *
FROM Students
WHERE age > 20;
```

## Count students per major

```sql
SELECT major, COUNT(*) AS total
FROM Students
GROUP BY major;
```

## Find majors with more than 5 students

```sql
SELECT major, COUNT(*) AS total
FROM Students
GROUP BY major
HAVING COUNT(*) > 5;
```

## Find employee names and department names

```sql
SELECT e.name, d.department_name
FROM Employees e
JOIN Departments d
ON e.department_id = d.department_id;
```

## Find employees without a department match

```sql
SELECT e.name
FROM Employees e
LEFT JOIN Departments d
ON e.department_id = d.department_id
WHERE d.department_id IS NULL;
```

---

# 48. Interview-Style SQL Patterns

## Find duplicates

```sql
SELECT email, COUNT(*) AS total
FROM Users
GROUP BY email
HAVING COUNT(*) > 1;
```

## Second highest salary

```sql
SELECT MAX(salary) AS second_highest
FROM Employees
WHERE salary < (
    SELECT MAX(salary)
    FROM Employees
);
```

## Top N rows

```sql
SELECT *
FROM Products
ORDER BY price DESC
LIMIT 3;
```

## Rows with max value

```sql
SELECT *
FROM Employees
WHERE salary = (
    SELECT MAX(salary)
    FROM Employees
);
```

---

# 49. SQL for CRUD

CRUD = Create, Read, Update, Delete

## Create

```sql
INSERT INTO Students (student_id, name, age)
VALUES (1, 'Alice', 20);
```

## Read

```sql
SELECT * FROM Students;
```

## Update

```sql
UPDATE Students
SET age = 21
WHERE student_id = 1;
```

## Delete

```sql
DELETE FROM Students
WHERE student_id = 1;
```

---

# 50. Typical Table Design Example

```sql
CREATE TABLE Customers (
    customer_id INT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100) UNIQUE
);

CREATE TABLE Orders (
    order_id INT PRIMARY KEY,
    customer_id INT,
    order_date DATE,
    total DECIMAL(10, 2),
    FOREIGN KEY (customer_id) REFERENCES Customers(customer_id)
);
```

Get all orders with customer names:

```sql
SELECT o.order_id, c.name, o.order_date, o.total
FROM Orders o
JOIN Customers c
ON o.customer_id = c.customer_id;
```

---

# 51. Common SQL Keywords to Remember

* `SELECT`
* `FROM`
* `WHERE`
* `INSERT INTO`
* `VALUES`
* `UPDATE`
* `SET`
* `DELETE`
* `CREATE TABLE`
* `DROP TABLE`
* `ALTER TABLE`
* `PRIMARY KEY`
* `FOREIGN KEY`
* `JOIN`
* `GROUP BY`
* `HAVING`
* `ORDER BY`
* `DISTINCT`
* `LIMIT`
* `UNION`
* `CASE`
* `NULL`
* `IS NULL`
* `IN`
* `BETWEEN`
* `LIKE`

---

# 52. ALTER TABLE

Add a column:

```sql
ALTER TABLE Students
ADD email VARCHAR(100);
```

Modify a column:

```sql
ALTER TABLE Students
ALTER COLUMN email VARCHAR(150);
```

Drop a column:

```sql
ALTER TABLE Students
DROP COLUMN email;
```

Syntax can vary by database.

---

# 53. SQL Server / MySQL / PostgreSQL Differences

Some syntax differs depending on the database:

* `LIMIT` vs `TOP`
* `AUTO_INCREMENT` vs `SERIAL` vs `IDENTITY`
* string/date functions may vary
* `FULL OUTER JOIN` not supported in some systems like MySQL without workaround

So always check which DBMS you are using.

---

# 54. Fast Mental Model for SQL

Think of SQL as answering questions like:

* Which rows do I want?
* From which table?
* How do tables connect?
* Do I need grouping?
* Do I need sorting?
* Do I want all rows or only matching rows?

---

# 55. Tiny Cheatsheet

## Select all

```sql
SELECT * FROM table_name;
```

## Filter

```sql
SELECT * FROM table_name WHERE condition;
```

## Sort

```sql
SELECT * FROM table_name ORDER BY column_name DESC;
```

## Count

```sql
SELECT COUNT(*) FROM table_name;
```

## Group

```sql
SELECT column_name, COUNT(*)
FROM table_name
GROUP BY column_name;
```

## Join

```sql
SELECT a.col, b.col
FROM table_a a
JOIN table_b b
ON a.id = b.id;
```

## Insert

```sql
INSERT INTO table_name (col1, col2)
VALUES (val1, val2);
```

## Update

```sql
UPDATE table_name
SET col1 = val1
WHERE condition;
```

## Delete

```sql
DELETE FROM table_name
WHERE condition;
```

---

# 56. Good Things to Review Before Writing SQL Again

Review in this order:

1. `SELECT`, `FROM`, `WHERE`
2. `ORDER BY`, `LIMIT`
3. `INSERT`, `UPDATE`, `DELETE`
4. aggregate functions
5. `GROUP BY`, `HAVING`
6. joins
7. subqueries
8. keys and constraints
9. transactions

That already covers a lot of practical SQL.

---

# 57. Final Fast Recap

Most common things you will use:

* `SELECT`
* `WHERE`
* `JOIN`
* `GROUP BY`
* `HAVING`
* `ORDER BY`
* `INSERT`
* `UPDATE`
* `DELETE`
* `COUNT`, `SUM`, `AVG`
* primary key / foreign key
* `INNER JOIN` / `LEFT JOIN`
* `LIKE`, `IN`, `BETWEEN`, `IS NULL`

If you remember those well, you can already do a lot.

---

# 58. Tiny Starter Practice Script

```sql
CREATE TABLE Students (
    student_id INT PRIMARY KEY,
    name VARCHAR(100),
    age INT,
    major VARCHAR(100)
);

INSERT INTO Students (student_id, name, age, major)
VALUES
(1, 'Alice', 20, 'Software Engineering'),
(2, 'Bob', 22, 'Computer Science'),
(3, 'Charlie', 21, 'Mathematics');

SELECT * FROM Students;

SELECT name, age
FROM Students
WHERE age > 20
ORDER BY age DESC;

SELECT major, COUNT(*) AS total
FROM Students
GROUP BY major;
```

---

If you want, I can also make you a **DBMS interview version** with:

* SQL joins diagrams
* 20 classic interview queries
* normalization recap
* primary key / foreign key examples
* MySQL vs PostgreSQL vs SQL Server notes.
