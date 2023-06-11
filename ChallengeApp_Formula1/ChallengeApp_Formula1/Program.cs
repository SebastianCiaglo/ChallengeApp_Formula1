using ChallengeApp_Formula1;

//Driver driver1 = new Driver("Fernando", "Alonso",41);
//Driver driver2 = new Driver("Max","Verstappen", 25);
//Driver driver3 = new Driver("Robert","Kubica", 38);
//Driver driver4 = new Driver("Lewis","Hamilton",38);
/*
driver1.AddPoints("25");
driver1.AddPosition('d');
driver1.AddPoints("Adam");
driver1.AddPoints(-25);
driver1.AddPenalty(-3);
*/


Console.WriteLine("Welcome to the program to gather Formula 1 season progress");
Console.WriteLine("==========================================================");
Console.WriteLine();



var driverInMemory = new DriverInMemory("Fernando", "Alonso");

var driverInFile = new DriverInMemory("Fernando", "Alonso");

//driverInMemory.PointsAdded += DriverPointsAdded;
driverInFile.PointsAdded += DriverPointsAdded;

void DriverPointsAdded(object sender, EventArgs args)
{
    Console.WriteLine("Points added");
}

driverInFile.AddPoints("25");
driverInFile.AddPoints(18);
//driverInMemory.AddPoints(18);


/*

while (true)
{
    Console.WriteLine("Enter position of driver, to quit enter q");
    var input = Console.ReadLine();

    if(input == "q")
    {
        break;
    }

    
    try
    {
        driver.AddPoints(input);
        //driver.AddPosition(input[0]);
    }
    catch(Exception e) 
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }

    
}
*/

var statistics = driverInFile.GetStatistic();
//var statistics = driverInMemory.GetStatistic();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Best Position: {statistics.BestPosition}");

/*
driver2.AddPoints(15);
driver2.AddPoints(25);
driver2.AddPoints(18);
driver2.AddPoints(12);

driver3.AddPoints(18);
driver3.AddPoints(15);
driver3.AddPoints(12);
driver3.AddPoints(25);

driver4.AddPoints(12);
driver4.AddPoints(12);
driver4.AddPoints(15);
driver4.AddPoints(18);
*/

/*
var statistics = driver1.GetStatistic();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Best position: {statistics.BestPosition}");
Console.WriteLine($"Worst position: {statistics.WorstPosition}");

/*
List<Driver> drivers = new List<Driver>()
{
    driver1, driver2, driver3, driver4  
};

float maxResult=-1;
Driver driverWithMaxResult = null;


foreach (var driver in drivers)
{
    if(driver.AllPoints>maxResult)
    {
        driverWithMaxResult=driver;
        maxResult=driver.AllPoints;
    }
}

Console.WriteLine(driverWithMaxResult.Name +" "+ driverWithMaxResult.Surname +" lat " + driverWithMaxResult.Age +" zajal pierwsze miejsce z liczba punktow wynoszaca " + driverWithMaxResult.AllPoints);
*/
