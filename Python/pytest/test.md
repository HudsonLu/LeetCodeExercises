## What is `pytest`?

`pytest` is a Python testing framework used to write and run tests.

It is like **JUnit for Java**, but for Python.

You use it to check if your functions/classes behave correctly.

---

# 1. Install pytest

```bash
pip install pytest
```

Check version:

```bash
pytest --version
```

---

# 2. Basic example

Suppose you have this file:

```python
# calculator.py

def add(a, b):
    return a + b
```

Create a test file:

```python
# test_calculator.py

from calculator import add

def test_add():
    assert add(2, 3) == 5
```

Run:

```bash
pytest
```

Output:

```text
1 passed
```

---

# 3. Naming rules

`pytest` automatically finds tests if:

```text
file name starts with test_
function name starts with test_
```

Examples:

```python
test_user.py
test_calculator.py
test_payment.py
```

Functions:

```python
def test_login():
    pass

def test_register_user():
    pass
```

---

# 4. `assert` is used for testing

In pytest, you usually use normal Python `assert`.

```python
def test_subtract():
    result = 10 - 4
    assert result == 6
```

If it fails:

```python
def test_subtract():
    result = 10 - 4
    assert result == 5
```

pytest shows a clear error:

```text
assert 6 == 5
```

---

# 5. Testing multiple cases

Example function:

```python
# math_utils.py

def is_even(number):
    return number % 2 == 0
```

Test:

```python
# test_math_utils.py

from math_utils import is_even

def test_is_even():
    assert is_even(2) == True
    assert is_even(4) == True
    assert is_even(7) == False
```

Better style:

```python
def test_is_even():
    assert is_even(2)
    assert is_even(4)
    assert not is_even(7)
```

---

# 6. Testing exceptions

Example:

```python
# calculator.py

def divide(a, b):
    if b == 0:
        raise ValueError("Cannot divide by zero")
    return a / b
```

Test:

```python
# test_calculator.py

import pytest
from calculator import divide

def test_divide_by_zero():
    with pytest.raises(ValueError):
        divide(10, 0)
```

You can also check the error message:

```python
def test_divide_by_zero_message():
    with pytest.raises(ValueError, match="Cannot divide by zero"):
        divide(10, 0)
```

---

# 7. Parametrized tests

Instead of writing many similar tests:

```python
def test_add_1():
    assert add(1, 2) == 3

def test_add_2():
    assert add(5, 5) == 10

def test_add_3():
    assert add(-1, 1) == 0
```

Use `@pytest.mark.parametrize`:

```python
import pytest
from calculator import add

@pytest.mark.parametrize("a, b, expected", [
    (1, 2, 3),
    (5, 5, 10),
    (-1, 1, 0),
])
def test_add(a, b, expected):
    assert add(a, b) == expected
```

This runs the same test with different inputs.

---

# 8. Fixtures

A fixture is reusable setup code.

Example:

```python
# test_user.py

import pytest

@pytest.fixture
def sample_user():
    return {
        "name": "Hudson",
        "age": 22
    }

def test_user_name(sample_user):
    assert sample_user["name"] == "Hudson"

def test_user_age(sample_user):
    assert sample_user["age"] == 22
```

The `sample_user` fixture is automatically passed into the test.

---

# 9. Testing a class

Example:

```python
# bank_account.py

class BankAccount:
    def __init__(self):
        self.balance = 0

    def deposit(self, amount):
        self.balance += amount

    def withdraw(self, amount):
        if amount > self.balance:
            raise ValueError("Insufficient funds")
        self.balance -= amount
```

Test:

```python
# test_bank_account.py

import pytest
from bank_account import BankAccount

def test_deposit():
    account = BankAccount()
    account.deposit(100)

    assert account.balance == 100

def test_withdraw():
    account = BankAccount()
    account.deposit(100)
    account.withdraw(40)

    assert account.balance == 60

def test_withdraw_too_much():
    account = BankAccount()

    with pytest.raises(ValueError):
        account.withdraw(50)
```

---

# 10. Common pytest commands

Run all tests:

```bash
pytest
```

Run one file:

```bash
pytest test_calculator.py
```

Run one test function:

```bash
pytest test_calculator.py::test_add
```

Show print output:

```bash
pytest -s
```

More detailed output:

```bash
pytest -v
```

Stop after first failure:

```bash
pytest -x
```

Run tests matching a name:

```bash
pytest -k "login"
```

---

# 11. Simple project structure

```text
project/
│
├── calculator.py
├── user_service.py
│
└── tests/
    ├── test_calculator.py
    └── test_user_service.py
```

Run from the project root:

```bash
pytest
```

---

# 12. Example with a service

Code:

```python
# user_service.py

def register_user(username, password):
    if len(password) < 8:
        raise ValueError("Password too short")

    return {
        "username": username,
        "active": True
    }
```

Test:

```python
# tests/test_user_service.py

import pytest
from user_service import register_user

def test_register_user_success():
    user = register_user("hudson", "password123")

    assert user["username"] == "hudson"
    assert user["active"] is True

def test_register_user_short_password():
    with pytest.raises(ValueError, match="Password too short"):
        register_user("hudson", "123")
```

---

# 13. Pytest vs unittest

Python also has built-in `unittest`.

`unittest` style:

```python
import unittest

class TestCalculator(unittest.TestCase):
    def test_add(self):
        self.assertEqual(2 + 3, 5)
```

`pytest` style:

```python
def test_add():
    assert 2 + 3 == 5
```

`pytest` is usually simpler and cleaner.

---

# Summary

`pytest` is used to:

```text
Write tests
Run tests automatically
Check expected results with assert
Test errors with pytest.raises
Reuse setup code with fixtures
Run many input cases with parametrize
```

Basic pattern:

```python
def test_something():
    result = function_to_test()
    assert result == expected_value
```
