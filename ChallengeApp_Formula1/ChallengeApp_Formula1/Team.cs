namespace ChallengeApp_Formula1
{
    public class Team : iEvaluation
    {
        private List<float> points = new List<float>();

        public Team(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public float AllPoints
        {
            get
            {
                return this.points.Sum();
            }
        }

        public void AddPoints(float points)
        {
            if (points >= 1 && points <= 5)
            {
                this.points.Add(points);
            }
            else
            {
                throw new Exception("invalid number of points");
            }
        }


        public void AddPoints(long points)
        {
            float pointsAsFloat = (float)points;
            this.AddPoints(pointsAsFloat);
        }

        public void AddPoints(string points)
        {

            switch (points)
            {

                case "1":
                    this.points.Add(1);
                    break;

                case "2":
                    this.points.Add(2);
                    break;

                case "2+":
                    this.points.Add(2.5f);
                    break;

                case "+2":
                    this.points.Add(2.5f);
                    break;

                case "3":
                    this.points.Add(3);
                    break;

                case "-4":
                    this.points.Add(3.75f);
                    break;

                case "4-":
                    this.points.Add(3.75f);
                    break;

                case "4":
                    this.points.Add(4);
                    break;

                case "5":
                    this.points.Add(5);
                    break;

                default:
                    throw new Exception("invalid nuber of points");
            }

        }






        public Statistics GetStatistic()
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
