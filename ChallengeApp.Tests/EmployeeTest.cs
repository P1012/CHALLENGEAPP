using NUnit.Framework;
namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]  
        public void GetStatisticsWithCharShouldReturnMaxScore()
        {
            // arrange 
            var employee = new Employee("Sydney", "Prescot");

            employee.AddGrade('a');
            employee.AddGrade('B');
            employee.AddGrade('d');


            // act
            var Statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(100, Statistics.Max);


        }
        [Test]
        public void GetStatisticTestWithStringsShouldReturnAverageScore()
        {
            var employee = new Employee("Sydney", "Prescot");

            employee.AddGrade("b");
            employee.AddGrade("C");
            employee.AddGrade("D");
            employee.AddGrade("15");
            employee.AddGrade("20");

            var result = employee.GetStatistics();

            var Statistics = employee.GetStatistics();

            Assert.AreEqual(17.5f, Statistics.Average);
        }
        [Test]
        public void GetStatisticTestAllTypesShouldReturnMinimumScore()
        {
            var employee = new Employee("Sydney", "Prescot");

            employee.AddGrade(1);
            employee.AddGrade("6");
            employee.AddGrade('A');
            employee.AddGrade('c');
            employee.AddGrade(18f);
            employee.AddGrade(-1);


            var Statistics = employee.GetStatistics();

            Assert.AreEqual(1, Statistics.Min);
        }
    }
}








