namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetEmployeesNameSurnameAndAgeEqualOrNotEqual()
        {
            //Arrange 
            var employee1 = GetEmployee("Henio", "Kozka", "33");
            var employee2 = GetEmployee("Helcia", "Waza", "45");
            var employee3 = GetEmployee("Czesio", "Polmozg", "8");
            var employee4 = GetEmployee("Czesio", "Polmozg", "8");
            // Act


            // Assert

            Assert.AreNotEqual(employee1, employee2);
           
        }
        private Employee GetEmployee(string name, string surname, string age)
        {

            return new Employee(name, surname);

        }
        [Test]
        public void CompareNumbersEqualOrNotEqual()
        {
            int number1 = 6;
            int number2 = 10;
            int number3 = 9;
            int number4 = 9;


            Assert.AreNotEqual(number1, number2);
            Assert.AreEqual(number3, number4);

        }
        [Test]
        public void CompareVodkasVolumeEqualOrNotEqual()
        {
            float vodka1 = 1;
            float vodka2 = 2;
            double vodka3 = 3;
            double vodka4 = 3;

            Assert.AreNotEqual(vodka1, vodka2);
            Assert.AreEqual(vodka4, vodka3);
        }
    }
}


