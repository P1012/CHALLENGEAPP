namespace ChallengeApp
{
    internal class Supervisor : IEmployee
    {
        public string Name => "Sydney";
        public string Surname => "Prescot";
        public string Sex => "Woman";
        public int Age => 33;

        public void AddGrade(double grade)
        {
            grade.CompareTo(grade);

        }
        public void AddGrade(char grade)
        {
            throw new Exception("Value not allowed for Supervisor");
        }

        public void AddGrade(float grade)
        {
            throw new Exception("Value not allowed for Supervisor");
        }

        public void AddGrade(int grade)
        {
            throw new Exception("Value not allowed for Supervisor");
        }
        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "-6" or "6-":
                    this.AddGrade(95);
                    break;
                case "+5" or "5+":
                    this.AddGrade(85);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "-5" or "5-":
                    this.AddGrade(75);
                    break;
                case "+4" or "4+":
                    this.AddGrade(65);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "-4" or "4-":
                    this.AddGrade(55);
                    break;
                case "+3" or "3+":
                    this.AddGrade(45);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "-3" or "3-":
                    this.AddGrade(35);
                    break;
                case "+2" or "2+":
                    this.AddGrade(25);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "+1" or "1+":
                    this.AddGrade(5);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                default:
                    throw new Exception("Invalid Grade Value");

            }
        }
        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}


    







    













