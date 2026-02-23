# Multiple Choice Exam Management System

## Description

This is a multiple-choice exam management system developed in C# that allows teachers to create questions and students to take exams. The system stores results and provides detailed statistical reports.

## Features

- **Question Registration**: Create questions with three answer options (A, B, C) and specify the correct answer.
- **Take Exams**: Students can take exams with 5 randomly selected questions from the question bank.
- **Grading System**: The system automatically calculates the final grade on a scale of 0 to 10.
- **Detailed Reports**:
  - View all completed exams
  - Filter results by student
  - Ranking of top students
  - Statistics per question (percentage of correct answers)

## Technologies Used

- **Language**: C# (.NET 9.0)
- **ORM Framework**: Entity Framework Core 9.0.4
- **Database**: SQLite 9.0.4
- **Application Type**: Console

## Prerequisites

- .NET SDK 9.0 or higher

## Installation and Execution

### 1. Clone or download the project

```bash
git clone <repository-url>
cd "Gestion Examenes Multiple Choice"
```

### 2. Restore dependencies

```bash
dotnet restore
```

### 3. Run the program

```bash
dotnet run
```

### 4. Build (optional)

```bash
dotnet build
```

## Program Usage

When running the program, a main menu will appear with the following options:

1. **Register question**: Add new questions to the question bank
2. **Take exam**: Allow a student to take an exam with 5 random questions
3. **View reports**: Access different types of reports and statistics
0. **Exit**: Close the program

### Usage Example

#### Register a Question
```
Statement: What is the capital of Argentina?
Answer A: Buenos Aires
Answer B: Córdoba
Answer C: Rosario
Correct answer (A/B/C): A
```

#### Take an Exam
- Enter the student's name
- Answer the 5 presented questions
- The system automatically calculates and displays the final grade

## Project Structure

- `Program.cs`: Main file with all application logic
- `tp4.csproj`: Project configuration file
- `examen.db`: SQLite database (created automatically on first run)

## Data Model

The system uses three main entities:

- **Pregunta (Question)**: Stores questions with their options and correct answer
- **ResultadoExamen (ExamResult)**: Saves the results of each completed exam
- **RespuestaExamen (ExamAnswer)**: Records each individual answer from an exam

## Author

Mazza Leon, Fabrizio Lautaro - 61848

## License

Academic project - Universidad Tecnológica Nacional (National Technological University)
