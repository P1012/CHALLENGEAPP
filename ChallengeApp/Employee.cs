namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
            int valueInInt = (int)grade;
            float f = (float)valueInInt;
            if (grade >= 0 && grade >= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float ");
            }
        }
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                float result = (float)grade;
                this.grades.Add(result);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }
        public void AddGrade(long grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                float result = (float)grade;
                this.grades.Add(result);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }
        public void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                float result = (float)grade;
                this.grades.Add(result);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            return statistics;
        }
    }
}      


             
            
            
    
    



