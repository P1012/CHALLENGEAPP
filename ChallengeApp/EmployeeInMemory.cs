namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase, IEmployee
    {
        public EmployeeInMemory(string name, string surname, string sex,string age)
            : base(name, surname, sex, age ) 

        {
        }

        public override void AddGrade(float grade) 
        {
            Console.WriteLine("Grade Added");
        }
        

        public override void AddGrade(int grade)
        {
            Console.WriteLine("Grade Added");
        }

        public override void AddGrade(char grade)
        {
            Console.WriteLine("Grade Added");
        }

        public override void AddGrade(string grade)
        {
            Console.WriteLine("Grade Added");
        }
        public override void AddGrade(double grade)
        {
            Console.WriteLine("Grade Added"); 
        }
       
        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
