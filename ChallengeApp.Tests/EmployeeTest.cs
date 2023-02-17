namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void StatisticsTestMax()
        {
            // arrange 
            var employee = new Employee("Sydney", "Prescot");

            employee.AddGrade(5);
            employee.AddGrade(10);
            employee.AddGrade(-7);


            // act
            var Statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(10, Statistics.Max);


        }
        [Test]
        public void StatisticTestMin()
        {
            var employee = new Employee("Sydney", "Prescot");

            employee.AddGrade(8);
            employee.AddGrade(1);
            employee.AddGrade(-2);

            var Statistics = employee.GetStatistics();

            Assert.AreEqual(-2, Statistics.Min);
        }
        [Test]
        public void StatisticTestAverage()
        {
            var employee = new Employee("Sydney", "Prescot");

            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.AddGrade(9);

            var Statistics = employee.GetStatistics();

            Assert.AreEqual(5, Statistics.Average);

        }
    }

} 






