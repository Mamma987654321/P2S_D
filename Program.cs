using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Data
{
    internal class Program
    {
            private static void FileFun()

            {
                string path = @"C:\Users\ittam\OneDrive\Desktop\C#_Projects\Project2\StudentDetails";

                if (File.Exists(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string tillEnd = sr.ReadToEnd();
                        Console.WriteLine("File Exists, reading in:\n" + tillEnd);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("StudentData\nName\nRollnumber\nSubject");
                        Console.WriteLine("File doesnt exist.");
                    }
                }
            }
            private static void Main(string[] args)
            {
                FileFun();
            }
        }
    }


