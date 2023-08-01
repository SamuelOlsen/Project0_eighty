I made the following project as a summer excercise! 

Project 0: eighty
Summer of Programming 2021
Department of Computer Science
University of Copenhagen
July 10, 2021

1 Introduction
Welcome to DIKU Summer of Programming 2021! During this "course",
we will be providing you with some small programming exercises called
projects to keep your skills sharp over the summer. The primary programming language will be C#, although there are no hard restrictions on language. If you are feeling adventurous, you might even try to do these
projects in C, in order to prepare for the Computer Systems course.
For this first project, you will be writing a small program, eighty, which
reads through a given file and warns the user about lines exceeding 10
characters.

2 Setup (C#)
To setup the project, create a new directory eighty, enter it, and then write
$ dotnet new console
You can now write your code in the Program.cs file. To compile and run
the program, use
$ dotnet run
For this project, you will be providing the name of the file to be checked
from the command line. If, for example, you would like to check that
Program.cs has no lines exceeding 80 characters, you can write
$ dotnet run Program.cs

Summer of Programming 2021
Project 0: eighty
DIKU July 10, 2021
3 eighty specification
In the following specification, the return value refers to the return value of the
main function. By convention, 0 indicates success, and anything else indicates
failure.
For this project, create a program eighty with the following functionality:
3.1. If the program receives no argument, then it must print
Please provide a filename.
and return 1.
3.2. If the file provided could not be opened, it must print
Could not open file.
and return 1.
3.3. For each line in the file, if the line exceeds 10 characters, print
Line x is too long! (y characters)
where x is the line number and y is the line width.
3.4. After checking each line, the program must return 0.
