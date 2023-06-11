namespace ChallengeApp_Formula1
{
    public abstract class DriverBase : iEvaluation
    {
        public DriverBase(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public abstract event PointsAddedDelegate PointsAdded;

        public delegate void PointsAddedDelegate(object sender, EventArgs args);


        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract void AddPoints(float points);


        public abstract void AddPoints(string points);

        public abstract void AddPoints(long points);


        public abstract Statistics GetStatistic();
    }

}
