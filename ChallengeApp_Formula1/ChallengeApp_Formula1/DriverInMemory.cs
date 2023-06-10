namespace ChallengeApp_Formula1
{
    public class DriverInMemory : DriverBase
    {
        private List<float> points = new List<float>();

        public DriverInMemory(string name, string surname) : base(name, surname)
        {
        }

        public override float AllPoints
        {
            get
            {
                return this.points.Sum();
            }
        }

        public override void AddPoints(float points)
        {


            if (points >= 0 && points <= 25)
            {
                this.points.Add(points);
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

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var point in this.points)
            {
                statistics.Max = Math.Max(statistics.Max, point);
                statistics.Min = Math.Min(statistics.Min, point);
                statistics.Average += point;
            }

            statistics.Average /= this.points.Count();

            return statistics;
        }
    }
}
