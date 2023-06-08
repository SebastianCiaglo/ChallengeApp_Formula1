namespace ChallengeApp_Formula1.Tests
{
    public class TypeTests
    {
        [Test]
        public void ReferenceTypeTest()
        {
            //arrange

            var driver1 = GetDriver("Yuki", "Tsunoda");
            var driver2 = GetDriver("Yuki", "Tsunoda");

            //act


            //assert
            Assert.AreEqual(driver1.Name, driver2.Name);

        }

        public void ValueTypeTest()
        {
            //arrange

            var driver1paycheck = 10500.0;
            var driver1expenses = 2145.5;

            //act

            var result = driver1paycheck > driver1expenses;

            //assert
             Assert.AreEqual(true, result);

        }

        
        private Driver GetDriver(string name, string surname)
        {
            return new Driver(name, surname);
        }
        
    }
}
