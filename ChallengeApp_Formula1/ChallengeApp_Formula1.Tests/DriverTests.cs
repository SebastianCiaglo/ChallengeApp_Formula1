namespace ChallengeApp_Formula1.Tests
{
    public class Tests
    {
        [Test]
        public void WhenDriverRaces_ShouldReturnPointsSum()
        {
            //arrange

            var driver = new Driver("Sergio","Perez",22);

            driver.AddPoints(10);
            driver.AddPoints(18);
            driver.AddPenalty(10);
            driver.AddPenalty(-3);
            //act

            var result = driver.AllPoints;

            //assert

            Assert.AreEqual(25,result);

        }
    }
}