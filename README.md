# 🩸 Blood Bank Console Application

A simple C# console application that simulates a blood bank system.  
It allows users to **donate blood**, **request transfusions**, and **view donation records** with built-in input validation.

---

## ✨ Features
- **Donation System**  
  - Donors provide their name and blood type.  
  - Each donation adds 0.4 liters to the blood bank stock.  
  - Records are stored with donor name, ID, blood type, and amount.

- **Transfusion System**  
  - Requests are validated against blood type compatibility rules.  
  - If the requested type is unavailable, compatible alternatives are checked.  
  - Clear feedback is given when transfusion succeeds or fails.

- **Input Validation**  
  - Custom `Valid` class ensures safe user input for integers, doubles, strings, chars, and booleans.  
  - Retry logic with error messages and termination after too many failed attempts.

- **Records & Stock View**  
  - View all donation records with donor details.  
  - View available blood stock by type.

---

## 🛠 Technologies Used
- **Language:** C#  
- **Framework:** .NET (Console Application)  
- **Collections:** `List<T>`, `Dictionary<TKey, TValue>`  
- **Namespaces:** Organized into `Valid_Rep` (validation & helpers) and `Programm` (main app logic)

---

## 📂 Project Structure
