namespace ChallengeApp_Formula1.Tests
{
    public class TeamTests
    {
        [Test]

        public void WhenStatisticsCalled_CorrectMaxReturned()
        {
            //arrange

            var team = new Team("Ferrari");

            team.AddPoints(1);
            team.AddPoints("2+");
            team.AddPoints(5);
            team.AddPoints("-4");
            //team.AddPoints("5+");
            //team.AddPoints(8);
            //act

            var statistics = team.GetStatistic();

            //assert

            Assert.AreEqual(1, statistics.Min);
        }
    }
}
