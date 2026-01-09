# FormatException

<div align="center">

**A C# Educational Project Demonstrating Exception Handling and Input Validation**

[![GitHub](https://img.shields.io/badge/GitHub-lokeshvenkat17-blue?logo=github)](https://github.com/lokeshvenkat17)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](#license)
[![C#](https://img.shields.io/badge/Language-C%23-239120?logo=csharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-Framework-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)

</div>

---

## 📖 Overview

FormatException is an educational C# console application that demonstrates **proper exception handling** and **input validation** techniques. This project showcases how to handle `FormatException` when parsing user input, specifically in a banking context where numeric data conversion is critical.

The application implements a simple **Bank Account Management System** that requires users to input account holder name, account number, and current balance. It demonstrates real-world scenarios where invalid input must be gracefully handled.

---

## 🎯 Key Learning Objectives

- ✅ Understanding `FormatException` and when it occurs
- ✅ Implementing try-catch exception handling blocks
- ✅ Input validation best practices in C#
- ✅ Object-oriented programming with properties and auto-properties
- ✅ User-friendly error messages and recovery
- ✅ String parsing using `int.Parse()` and `double.Parse()`

---

## 📁 Project Structure

```
Format/
├── Program.cs              # Main entry point with exception handling logic
├── BankAccount.cs          # BankAccount class with properties
├── Format.csproj           # C# project configuration
└── .gitignore             # Git ignore patterns
```

---

## 🏗️ Architecture

### BankAccount.cs
A simple model class that encapsulates bank account information:

```csharp
public class BankAccount
{
    public string AccountHolderName { get; set; }
    public int AccountNumber { get; set; }
    public double CurrentBalance { get; set; }
}
```

**Properties:**
- `AccountHolderName` (string) - Name of the account holder
- `AccountNumber` (int) - Unique account identifier
- `CurrentBalance` (double) - Current account balance

### Program.cs
The main application logic that demonstrates:

1. **User Input Collection** - Prompts user for account details
2. **Exception Handling** - Try-catch blocks to handle `FormatException`
3. **Data Parsing** - Converts string input to appropriate types:
   - Account number: `int.Parse()`
   - Balance: `double.Parse()`
4. **Display Output** - Shows the created bank account details

---

## 🚀 Getting Started

### Prerequisites
- .NET Framework or .NET Core/5+ installed
- Visual Studio or Visual Studio Code
- C# knowledge (beginner level)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/lokeshvenkat17/FormatException.git
   cd FormatException
   ```

2. **Navigate to project directory**
   ```bash
   cd Format
   ```

3. **Build the project**
   ```bash
   dotnet build
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

---

## 💡 Usage Example

When you run the application, it will prompt you for input:

```
Enter the account holder name: John Doe
Enter the account number: 12345
Enter the current balance: 5000.50

--- New bank account details ---
Account Holder Name: John Doe
Account Number: 12345
Current Balance: 5000.50
```

### Exception Handling Example

If you enter invalid input (non-numeric for account number or balance):

```
Enter the account number: ABC123

[FormatException caught - Application handles gracefully]
```

The application will catch the `FormatException` and display an appropriate error message rather than crashing.

---

## 🔍 Code Highlights

### Exception Handling Pattern

```csharp
try
{
    bankAccount.AccountNumber = int.Parse(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine("Invalid input! Please enter a valid number.");
}
```

### Key Features

1. **Robust Input Parsing** - Handles both integers and floating-point numbers
2. **User-Friendly Messages** - Clear error messages guide users
3. **Data Encapsulation** - Properties manage account information
4. **Exception Documentation** - Comments explain where exceptions can occur

---

## 📚 Learning Resources

### FormatException Documentation
- [Microsoft Docs - FormatException](https://docs.microsoft.com/en-us/dotnet/api/system.formatexception)
- [C# Exception Handling](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/exception-handling)

### Related Topics
- [Try-Catch-Finally](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/statements/try-catch)
- [Type Conversion in C#](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/casting-and-type-conversions)
- [Properties and Auto-Properties](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)

---

## 🎓 Use Cases

This project is ideal for:

- 🎯 **Students** learning C# basics and exception handling
- 👨‍💼 **Beginners** understanding object-oriented programming
- 📖 **Educators** teaching exception handling concepts
- 💻 **Developers** refreshing C# fundamentals

---

## 🔧 Technologies Used

| Technology | Purpose |
|-----------|----------|
| C# | Programming Language |
| .NET | Framework |
| Console Application | User Interface |
| Visual Studio | Development Environment |

---

## 🤝 Contributing

Contributions are welcome! Here are ways you can improve this project:

- Add input validation improvements
- Implement `TryParse()` as an alternative to `Parse()`
- Add unit tests using xUnit or NUnit
- Create a GUI version using WinForms or WPF
- Add file persistence (save/load accounts)
- Implement internationalization for error messages

**To contribute:**
1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

---

## 🐛 Known Issues & Future Enhancements

### Current Limitations
- No persistent data storage
- Single account management only
- Basic console UI

### Planned Features
- ✨ Support for multiple accounts
- ✨ Data persistence with file I/O or database
- ✨ Account transactions (deposit/withdrawal)
- ✨ Input validation with TryParse()
- ✨ Unit tests coverage
- ✨ GUI implementation

---

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

---

## 👤 Author

**Lokesh Venkat**
- 🔗 GitHub: [@lokeshvenkat17](https://github.com/lokeshvenkat17)
- 💼 LinkedIn: [Connect](https://linkedin.com/in/lokeshvenkat17)
- 📧 Feel free to reach out for collaborations!

---

## ⭐ Show Your Support

If this project helped you learn C# exception handling, please consider:
- ⭐ Starring this repository
- 🔗 Sharing it with fellow developers
- 💬 Providing feedback and suggestions
- 🤝 Contributing improvements

---

## 📞 Support & Questions

If you have questions or need clarification:
1. Check the existing issues
2. Review the code comments
3. Open a new issue with detailed description
4. Reference relevant documentation links

---

<div align="center">

**Happy Learning! 🚀**

*Master exception handling in C# with practical examples*

</div>
