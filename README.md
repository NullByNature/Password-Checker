A simple C# console program that evaluates the strength of a user's password based on common security rules. Built for practice and real-world relevance.

---

## ✨ Features

- Checks if a password:
  - Contains uppercase letters
  - Contains lowercase letters
  - Includes at least one digit
  - Includes at least one special character (`!@#$%^&*()` etc.)
  - Is longer than 12 characters
- Provides specific feedback on what's missing
- Displays a final strength message based on password quality

---

## 🧠 How It Works

The app uses:
- `char.IsUpper`, `char.IsLower`, `char.IsDigit`  
- A custom string of allowed special characters  
- Conditional `if` statements for each rule  
- A `while` loop to reject empty input  
- Console output to explain what's strong or weak about the password
