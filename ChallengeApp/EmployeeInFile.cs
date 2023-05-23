using System;
using System.Collections.Generic;
using System.IO;
namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname, string sex, string age)
            : base(name, surname, sex, age)
        {

        }

        private void WriteGradeToFile(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                WriteGradeToFile(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
            else if (grade.Length == 1)
            {
                AddGrade(Convert.ToChar(grade));
            }
            else
            {
                throw new Exception("Invalid Value");
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            AddGrade((float)grade);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    WriteGradeToFile(100);
                    break;
                case 'B':
                case 'b':
                    WriteGradeToFile(80);
                    break;
                case 'C':
                case 'c':
                    WriteGradeToFile(60);
                    break;
                case 'D':
                case 'd':
                    WriteGradeToFile(40);
                    break;
                case 'E':
                case 'e':
                    WriteGradeToFile(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (float.TryParse(line, out float grade))
                        {
                            grades.Add(grade);
                        }
                    }
                }
            }

            return grades;
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = ReadGradesFromFile();
            return CountStatistics(gradesFromFile);
        }

        private Statistics CountStatistics(List<float> gradesFromFile)
        {
            throw new NotImplementedException();
        }
    }
}

