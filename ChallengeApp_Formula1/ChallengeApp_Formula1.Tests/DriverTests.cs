namespace ChallengeApp_Formula1.Tests
{
    public class DriverTests
    {
        [Test]
        public void WhenStatisticsCalled_CorrectMaxReturned()
        {
            //arrange

            var driver = new Driver("Sergio","Perez",22);

            driver.AddPoints(10f);
            driver.AddPoints(18f);
            driver.AddPoints(10f);
            driver.AddPenalty(-3f);
            //act

            var statistics = driver.GetStatisticWithFor();

            //assert

            Assert.AreEqual(18,statistics.Max);

        }

        [Test]
        public void WhenStatisticsCalled_CorrectMinReturned()
        {
            //arrange

            var driver = new Driver("Sergio", "Perez", 22);

            driver.AddPoints(10);
            driver.AddPoints(18);
            driver.AddPoints(10);
            driver.AddPenalty(-3);
            //act

            var statistics = driver.GetStatisticWithDoWhile();

            //assert

            Assert.AreEqual(7, statistics.Min);

        }

        [Test]
        public void WhenStatisticsCalled_CorrectAverageReturned()
        {
            //arrange

            var driver = new Driver("Sergio", "Perez", 22);

            driver.AddPoints(10);
            driver.AddPoints(18);
            driver.AddPoints(10);
            driver.AddPenalty(-3);
            //act

            var statistics = driver.GetStatisticWithWhile();

            //assert

            Assert.AreEqual(Math.Round(11.66), Math.Round(statistics.Average));

        }



    }
}