namespace ChallengeApp
{
    public interface IEmployeeInMemory
    {
       
        void AddGrade(char grade);
        void AddGrade(double grade);
        void AddGrade(float grade);
        void AddGrade(int grade);
        void AddGrade(string grade);
        
        Statistics GetStatistics();
        
    }
}