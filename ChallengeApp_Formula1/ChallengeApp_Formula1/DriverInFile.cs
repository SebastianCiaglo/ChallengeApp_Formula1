namespace ChallengeApp_Formula1
{
    public class DriverInFile : DriverBase
    {
        private const string fileName = "points.txt";

        public event PointsAddedDelegate PointsAdded;

        public DriverInFile(string name, string surname) : base(name, surname)
        {
        }

        public override float AllPoints => throw new NotImplementedException();

        public override void AddPoints(float points)
        {

            if (points >= 0 && points <= 25)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(points);
                }

                if (PointsAdded != null)
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
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(points);
                }
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

            int i = 0;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        
                        var point = float.Parse(line);

                        statistics.Max = Math.Max(statistics.Max, point);
                        statistics.Min = Math.Min(statistics.Min, point);
                        statistics.Average += point;

                        line = reader.ReadLine();
                        i++;
                    } 
                    
                }
            }

            statistics.Average = statistics.Average / i;

            return statistics;
        }
    }

}
