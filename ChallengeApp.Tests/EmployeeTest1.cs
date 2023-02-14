namespace ChallengeApp.Tests
{
    public class Tests
    {
        private Employee employee;

        [Test]
        public void CheckSumAddScoreTest()
        {

            // arrange 
            var employee = new Employee("Popek", "Mikolajew", "40");

            employee.AddScore(5);
            employee.AddScore(10);
            employee.AddScore(-7);


            // act
            var Result = employee.Result;

            // assert
            Assert.AreEqual(8, Result);


        }
        [Test]
        public void CheckSumRemoveScoreTest2()
        {
            var employee2 = new Employee("Rychu", "Peja", "44");

            employee2.AddScore(8);
            employee2.AddScore(1);
            employee2.AddScore(-2);

            var result = employee2.Result;

            Assert.AreEqual(7, result);





        }
    }
}






