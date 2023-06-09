﻿using static ChallengeApp_Formula1.DriverBase;

namespace ChallengeApp_Formula1
{
    public interface iEvaluation
    {

        string Name { get; }


        void AddPoints(float points);

        void AddPoints(string points);

        void AddPoints(long points);

        event PointsAddedDelegate PointsAdded;

        Statistics GetStatistic();
    }

}
