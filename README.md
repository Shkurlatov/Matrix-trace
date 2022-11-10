# Matrix trace

The repository contains my work on self-completion of a study Task 
while taking specialized online courses for training C# developers.

An experienced Mentor checked the result and made his remarks on 
the quality of the work performed. The Task could not be completed 
until the Mentor decided that the result was up to industry standards.

The commit called “First implementation of the Task” is my original 
implementation, without any hints. All subsequent commits (if any) 
are the results of my attempts to solve Mentor's remarks and his 
suggestions for improvement the work.

According to the conditions of the school, the Mentor does not provide 
ways to solve shortcomings and sources of information. The search for 
the necessary educational information was carried out independently.
<br/><br/>

## Task Conditions

User inputs matrix dimensions into the program (columns and lines).
<br/><br/>
Program fill matrix with random numbers (from 0 till 100 included).
<br/><br/>
Program should find a matrix trace.

* _Matrix trace is the sum of all elements on the main diagonal._

* _Main diagonal of the square matrix is the diagonal which starts in the top left corner and finishes in the bottom right corner._

* _Main diagonal for a rectangle matrix is the line, which starts in the top left corner and moves right and down, till the border (bottom or right) of the matrix._

Program should print the filled matrix into the console. Main diagonal should be highlighted.
<br/><br/>
Print to the console elements from the matrix going like snail shells from border to center.
<br/>

__Examples:__
* _Input_ `"4"`
* _Input_ `"4"`
* _Output_<br/>
  <pre>
  <b>19</b>,  74,  40,  53
  23,  <b>93</b>,  14,  62
  86,  92,  <b>50</b>,  23
  43,  56,  85,  <b>87</b><br/> 
  249<br/>
  19, 74, 40, 53, 62, 23, 87, 85, 56, 43, 86, 23, 93, 14, 50, 92
  </pre>
<br/>

* _Input_ `"3"`
* _Input_ `"4"`
* _Output_<br/>
  <pre>
  <b>52</b>,  57,  61,  25
  73,  <b>11</b>,  16,  74
  95,  67,  <b>68</b>,  84<br/>
  131<br/>
  52, 57, 61, 25, 74, 84, 68, 67, 95, 73, 11, 16
  </pre>
<br/>

## Solution Structure

📁MatrixProject<br/>
 ┗ 📄Matrix.cs<br/>
📁Task2UnitTestProject<br/>
 ┗ 📄MatrixTests.cs<br/>
__📁TraceProject__<br/>
 ┣ 📄appsettings.json<br/>
 ┣ 📄Configuration.cs<br/>
 ┣ 📄ConsoleInterface.cs<br/>
 ┣ 📄Program.cs<br/>
 ┗ 📄Settings.cs
<br/><br/>

## Prerequisites

Microsoft Visual Studio 2019 or newer

* Workloads<br/>
    * ASP.NET and web development

- Individual components<br/>
    - .NET Core 3.1 Runtime (LTS) 
<br/><br/>

## Getting Started

Clone the remote repository on your local machine.<br/>
`$ git clone https://github.com/Shkurlatov/Matrix-trace.git`
<br/><br/>
Go to the project directory.<br/>
`$ cd Matrix-trace`
<br/><br/>
Open project solution in Microsoft Visual Studio.<br/>
`$ start Task2.sln`
<br/><br/>
Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> to run the application.
<br/><br/>
Use the application following directions in console window. 
<br/><br/>
Press <kbd>Ctrl</kbd>+<kbd>R</kbd>,<kbd>A</kbd> to run tests.
<br/><br/>

## Usage Example

<pre>
Enter number of rows
3
Enter number of columns
5

 <b>28</b>,  33,  54,  65,  51
 63,  <b>11</b>,  87,  29,  57
100,  98,  <b>93</b>,  20,  81

Matrix trace = 132

Matrix snake sequence is [ 28, 33, 54, 65, 51, 57, 81, 20, 93, 98, 100, 63, 11, 87, 29 ]

Press any key to close this window . . .
</pre>
