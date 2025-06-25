# CSharp-UnitTests

This repository contains **unit tests only**, written in C# using the NUnit framework.  
Each test corresponds to a task implemented in the [CSharp-Learning](https://github.com/dich3v/CSharp-Learning) repository.

## Purpose

The purpose of this repo is to:

- ✅ Practice writing clean, isolated unit tests
- ✅ Apply test-first thinking to existing logic
- ✅ Structure tests in a dedicated solution
- ✅ Develop confidence using **NUnit** and test runners in Visual Studio

## What’s Included

Each test project targets a single task or method (e.g. string manipulation, array logic, filters).  
The tests cover:

- Normal cases
- Edge cases
- Invalid input
- Result verification

Projects are named after the logic they test (e.g. `RemoveDuplicatesTests`, `MaxValueComparisonTests`, etc.).

## Technologies Used

- **C#**
- **.NET SDK**
- **NUnit**
- **Visual Studio**
- `.sln` + multiple `.csproj` projects

## How to Run the Tests

1. Open the solution file located at:

    ```
    CSharp-NUnit-Tests/Unit-Tests/Unit-Tests.sln
    ```

2. In **Visual Studio**, open **Test > Test Explorer**

3. Click **Run All Tests**

> ✅ The NUnit Test Adapter is required in Visual Studio (via NuGet or Extensions).

## Related Repository

Source logic is stored in: [CSharp-Learning](https://github.com/dich3v/CSharp-Learning)

## Author

Radoslav Dichev - Practicing unit testing separately from implementation, as part of QA and automation learning.