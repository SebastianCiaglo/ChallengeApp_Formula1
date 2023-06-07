using System;

namespace ChallengeApp_Formula1
{
    public class Driver
    {
        private readonly char sex = 'M';
        private const double nubmerPI = 3.14; 

        private List<float> points = new List<float>();

        public Driver(string name)
        {
            this.Name = name;
        }

        public Driver(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.sex = 'K';
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public float AllPoints
        {
            get
            {
                return this.points.Sum();
            }
        }
        

        public void AddPosition(char position)
        {
            switch(position)
            {
                case 'd':
                case 'D':
                    this.points.Add(0);
                    break;

                case '1':
                    this.points.Add(25);
                    break;

                case '2':
                    this.points.Add(18);
                    break;

                case '3':
                    this.points.Add(15);
                    break;

                case '4':
                    this.points.Add(12);
                    break;

                case 'f':
                case 'F':
                    AddFastLapPoint(1);
                    break;

                default:
                    throw new Exception("invalid position");                    

            }
        }


        public void AddPoints(float points)
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

        public void AddPoints(string points)
        {
            if(float.TryParse(points, out float value))
            {
                this.AddPoints(value);
            }
            else
            {
                throw new Exception("String is not float number");
            }
        }


        public void AddPoints(long points)
        {
            float pointsAsFloat = (float)points;
            this.AddPoints(pointsAsFloat);
        }



        public void AddPenalty(float points)
        {
            if(points < 0)
            {
                float temp = this.points[this.points.Count-1];
                this.points.RemoveAt(this.points.Count-1);
                this.points.Add(temp + points);
            }
        }

        public void AddFastLapPoint(float points)
        {
            if (points == 1)
            {
                float temp = this.points[this.points.Count - 1];
                this.points.RemoveAt(this.points.Count - 1);
                this.points.Add(temp + points);
            }
        }


        public Statistics GetStatistic()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;            

            foreach(var point in this.points) 
            {
                statistics.Max = Math.Max(statistics.Max, point);
                statistics.Min = Math.Min(statistics.Min, point);
                statistics.Average += point;
            }

            statistics.Average /= this.points.Count();

            switch(statistics.Max)
            {
                case var max when max > 19:

                    statistics.BestPosition = '1';
                    break;

                case var max when max > 16:

                    statistics.BestPosition = '2';
                    break;

                case var max when max > 13:

                    statistics.BestPosition = '3';
                    break;

                case var max when max > 11:

                    statistics.BestPosition = '4';
                    break;

                default:
                    statistics.BestPosition = 'd';
                    break;

            }


            switch (statistics.Min)
            {
                case var min when min > 19:

                    statistics.WorstPosition = '1';
                    break;

                case var min when min > 16:

                    statistics.WorstPosition = '2';
                    break;

                case var min when min > 13:

                    statistics.WorstPosition = '3';
                    break;

                case var min when min > 11:

                    statistics.WorstPosition = '4';
                    break;

                case var min when min <10:

                    statistics.WorstPosition = 'd';
                    break;

                default:
                    statistics.WorstPosition = 'd';
                    break;

            }



            return statistics;
        }


    }
}
