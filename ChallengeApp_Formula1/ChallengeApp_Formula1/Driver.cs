using System;

namespace ChallengeApp_Formula1
{
    public class Driver
    {
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

        public void AddPoints(float points)
        {


            if (points >= 0 && points <= 25)
            {
                this.points.Add(points);
            }
            else
            {
                Console.WriteLine("invalid number of points");
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
                Console.WriteLine("String is not float");
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

            return statistics;
        }


        public Statistics GetStatisticWithForEach()
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


        public Statistics GetStatisticWithFor()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;


            for(int i=0; i<this.points.Count;i++)
            //foreach (var point in this.points)
            {
                statistics.Max = Math.Max(statistics.Max, this.points[i]);
                statistics.Min = Math.Min(statistics.Min, this.points[i]);
                statistics.Average += this.points[i];
            }

            statistics.Average /= this.points.Count();

            return statistics;
        }

        public Statistics GetStatisticWithDoWhile()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            int index=0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.points[index]);
                statistics.Min = Math.Min(statistics.Min, this.points[index]);
                statistics.Average += this.points[index];
                index++;
            }
            while (index< this.points.Count());

            statistics.Average /= this.points.Count();

            return statistics;
        }


        public Statistics GetStatisticWithWhile()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            int index = 0;
            while (index < this.points.Count())
            {
                statistics.Max = Math.Max(statistics.Max, this.points[index]);
                statistics.Min = Math.Min(statistics.Min, this.points[index]);
                statistics.Average += this.points[index];
                index++;
            }
           

            statistics.Average /= this.points.Count();

            return statistics;
        }



    }
}
