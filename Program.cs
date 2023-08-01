using System;
using System.IO;

public partial class Program
{ 

    public static void Main(string[] args)
    {
        try{
            string file = args[0];
            Console.WriteLine(MainChecker(file));
        }
        catch (IndexOutOfRangeException){
            Console.WriteLine(MainChecker("outOfBound"));
        }
        catch(FileNotFoundException){
            Console.WriteLine(MainChecker("FileNotFound"));
        }
    }

        static int MainChecker(string file){
            switch (file){
                case "outOfBound":
                    Console.WriteLine("Please provide a filename");
                    return 1;
                case "FileNotFound":
                    Console.WriteLine("Could not open file");
                    return 1;
                default:
                    CountLines(file);
                    return 0;
        }
        }

        static void CountLines(string file){
            string[] readLines = File.ReadAllLines(file);
            for(int i = 0; i < readLines.Length; i++){
                string stringWithoutSpaces = readLines[i].Replace(" ", "");
                if(stringWithoutSpaces.Length > 10){
                    Console.WriteLine("Line: "+ i + " is too long! It has: " + stringWithoutSpaces.Length + " characters");
                }
            }
        }
}