namespace ChallengeApp_Formula1
{
    public class Statistics
    {
        public float Min { get; private set; }

        public float Max { get; private set; }

        public float Sum { get; private set; }

        public int Count { get; private set; }

        public float Average 
        { 
            get
            {
                return this.Sum/ this.Count;
            }
        }

        //public int ChampionshipPosition { get; set; }

        public char BestPosition 
        { 
            get
            {
                switch (this.Max)
                {
                    case var max when max > 19:

                        return '1';

                    case var max when max > 16:

                        return '2';

                    case var max when max > 13:

                        return '3';

                    case var max when max > 11:

                        return '4';

                    default:
                        return 'd';

                }
            }
        }

        public char WorstPosition { get; set; }

        public Statistics()
        {
            this.Count = 0;
            this.Sum= 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddPoints(float points)
        {
            this.Count++;
            this.Sum += points;
            this.Min = Math.Min(points, this.Min);
            this.Max = Math.Max(points, this.Max);

        }
    }
}
