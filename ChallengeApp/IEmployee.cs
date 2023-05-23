
namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        string Sex { get; }
        string Age { get; }
        void AddGrade(float grade);
        void AddGrade(int grade);
        void AddGrade(char grade);
        void AddGrad (string grade);
        void AddGrade(double grade);
        
        
        Statistics GetStatistics();
    }

}   














