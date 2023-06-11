namespace ChallengeApp_Formula1
{
    public class DriverInMemory : DriverBase
    {
        public override event PointsAddedDelegate PointsAdded;

        private List<float> points = new List<float>();

        public DriverInMemory(string name, string surname) : base(name, surname)
        {

        }

        public override void AddPoints(float points)
        {


            if (points >= 0 && points <= 25)
            {
                this.points.Add(points);

                if(PointsAdded != null)
                {
                    PointsAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid number of points");
            }
        }

        public override void AddPoints(string points)
        {
            if (float.TryParse(points, out float value))
            {
                this.AddPoints(value);
            }
            else
            {
                throw new Exception("String is not float number");
            }
        }


        public override void AddPoints(long points)
        {
            float pointsAsFloat = (float)points;
            this.AddPoints(pointsAsFloat);
        }

        public override Statistics GetStatistic()
        {
            var statistics = new Statistics();

            foreach(var point in this.points)
            {
                statistics.AddPoints(point);
            }

            return statistics;
        }

    }
}
