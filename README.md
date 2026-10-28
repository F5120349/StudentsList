# 🎓 Students List

A C# console application developed as part of university lab work to practise **LINQ, collections, filtering, sorting, grouping and data aggregation**.

The application works with a collection of student records and uses LINQ queries to answer a range of questions about courses, marks, ages and enrolment years.

## 📌 Project Overview

This exercise focuses on using **LINQ in C#** to query and transform collections of objects.

The application demonstrates how to:

- 🔎 Filter students based on specific conditions
- ↕️ Sort results in ascending and descending order
- 📊 Group students by course or enrolment year
- 📈 Calculate averages and other aggregate values
- 🏆 Find the highest-performing students
- 🔢 Count students within groups
- 🔄 Transform objects into new data structures
- 📋 Display queried results in the console

## 🛠️ Technologies & Tools

- **C#**
- **.NET 10**
- **LINQ**
- **Generic Collections**
- **Console Application**

## 🧠 Key Concepts Demonstrated

This project provided practical experience with:

- `List<T>`
- LINQ `Where()`
- `OrderBy()`
- `OrderByDescending()`
- `GroupBy()`
- `Select()`
- `Take()`
- `Count()`
- `Average()`
- `Max()`
- `FirstOrDefault()`
- Anonymous types
- Object-oriented programming
- Classes and constructors
- Method creation
- Data transformation
- Conditional filtering

## 🔎 LINQ Queries

The application performs a number of different queries against the student collection.

### Computer Science Students

Filters students studying Computer Science and sorts them by mark in descending order.

```csharp
var CS_Students_Descending = students
    .Where(s => s.course == "Computer Science")
    .OrderByDescending(s => s.mark)
    .ToList();
```

### Students Enrolled After 2020

Filters students who enrolled after 2020 and orders them by enrolment year.

```csharp
var Students_After_2020 = students
    .Where(s => s.EnrolmentYear > 2020)
    .OrderBy(s => s.EnrolmentYear)
    .ToList();
```

### Average Mark by Course

Groups students by course and calculates the average mark for each course.

```csharp
var Average_Mark_Per_Course = students
    .GroupBy(s => s.course)
    .Select(g => new
    {
        Course = g.Key,
        AverageMark = g.Average(s => s.mark)
    });
```

### Youngest Student by Course

Groups students by course and identifies the youngest student in each group.

```csharp
var Youngest_Student_Per_Course = students
    .GroupBy(s => s.course)
    .Select(g => new
    {
        Course = g.Key,
        YoungestStudent = g.OrderBy(s => s.age).FirstOrDefault()
    });
```

### Top 3 Students

Sorts students by mark and selects the three highest results.

```csharp
var Top_3_Students = students
    .OrderByDescending(s => s.mark)
    .Take(3)
    .ToList();
```

### Aggregate Data

The application also calculates overall statistics including:

- Total number of students
- Average mark
- Highest mark

```csharp
var Aggregate_Data = students
    .GroupBy(_ => 1)
    .Select(g => new
    {
        TotalStudents = g.Count(),
        AverageMark = g.Average(s => s.mark),
        HighestMark = g.Max(s => s.mark)
    })
    .FirstOrDefault();
```

## 📊 Analysis Performed

The application answers several questions using LINQ:

| Analysis | LINQ Techniques |
| --- | --- |
| Computer Science students by mark | `Where()`, `OrderByDescending()` |
| Students enrolled after 2020 | `Where()`, `OrderBy()` |
| Average mark per course | `GroupBy()`, `Average()` |
| Youngest student per course | `GroupBy()`, `OrderBy()`, `FirstOrDefault()` |
| Number of students per enrolment year | `GroupBy()`, `Count()` |
| Students scoring 70–85 | `Where()`, `OrderBy()` |
| Students over 21 by mark | `Where()`, `OrderByDescending()` |
| Top 3 students | `OrderByDescending()`, `Take()` |
| Students above 80 | `Select()` |
| Overall statistics | `GroupBy()`, `Count()`, `Average()`, `Max()` |

## 🧱 Data Model

Students are represented using a `Student` class containing:

| Property | Description |
| --- | --- |
| `surname` | Student surname |
| `forename` | Student forename |
| `age` | Student age |
| `course` | Course the student is enrolled on |
| `mark` | Student mark |
| `EnrolmentYear` | Year the student enrolled |

The class also overrides `ToString()` to provide a readable representation of each student when displayed in the console.

## 📁 Project Structure

```text
StudentsList/
│
├── StudentsList/
│   ├── Program.cs
│   ├── Student.cs
│   └── StudentsList.csproj
│
├── StudentsList.slnx
├── .gitignore
└── .gitattributes
```

## 🚀 How to Run

### Prerequisites

You will need:

- [.NET 10 SDK](https://dotnet.microsoft.com/)
- Visual Studio, VS Code or another C# development environment

### Running the Application

1. Clone the repository.
2. Open the solution in your preferred C# development environment.
3. Restore the project:

```bash
dotnet restore
```

4. Build the application:

```bash
dotnet build
```

5. Run the application:

```bash
dotnet run
```

The application will execute the LINQ queries and display the results in the console.

## 🎯 Project Purpose

This university exercise was completed to develop practical experience using **LINQ and C# collections** to solve data-processing problems.

It demonstrates how collections of objects can be filtered, sorted, grouped, transformed and aggregated to produce useful information.

## 📚 Skills Practised

- C#
- LINQ
- Object-oriented programming
- Collections
- Data filtering
- Data sorting
- Data grouping
- Data aggregation
- Data transformation
- Algorithmic problem solving
