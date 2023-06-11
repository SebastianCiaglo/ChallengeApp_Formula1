namespace ChallengeApp_Formula1
{
    public class DriverInFile : DriverBase
    {
        private const string filename = "points.txt";

        public override event PointsAddedDelegate PointsAdded;

        public DriverInFile(string name, string surname) : base(name, surname)
        {
        }



        public override void AddPoints(float points)
        {

            if (points >= 0 && points <= 25)
            {
                using (var writer = File.AppendText(filename))
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
                using (var writer = File.AppendText(filename))
                {
                    writer.WriteLine(points);
                }
            }
            else
            {
                throw new Exception("string is not float number");
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

            int i = 0;

            if (File.Exists(filename))
            {
                using (var reader = File.OpenText(filename))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                    
                        var point = float.Parse(line);

                        line = reader.ReadLine();
                        i++;
                    } 
                
                }
            }

            return statistics;
        }
    }

}
