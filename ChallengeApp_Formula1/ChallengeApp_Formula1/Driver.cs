namespace ChallengeApp_Formula1
{
    public class Driver
    {
        private List<int> points = new List<int>();

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
        public int AllPoints
        {
            get
            {
                return this.points.Sum();
            }
        }

        public void AddPoints(int points)
        {
            this.points.Add(points);
        }

        public void AddPenalty(int points)
        {
            if(points < 0)
            {
                this.points.Add(points);
            }
        }

    }
}
