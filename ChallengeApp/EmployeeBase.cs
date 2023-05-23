namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        private static int average;

        public EmployeeBase(string name, string surname, string sex,string age)
        {
            Name = name;
            Surname = surname;
            Sex = sex;
            Age = age;
        }

       

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Sex { get; private set; }

        public string Age { get; private set; }

        public void AddGrad(string grade)
        {
            throw new NotImplementedException();
        }

        public abstract void AddGrade(float grade);
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(char grade);
        public abstract void AddGrade(string grade);

        public abstract void AddGrade(double grade);
        
        public abstract Statistics GetStatistics();
    }  
}
