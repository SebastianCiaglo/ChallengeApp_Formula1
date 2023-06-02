using ChallengeApp_Formula1;
using System.Reflection.Metadata;

Driver driver1 = new Driver("Fernando", "Alonso",41);
Driver driver2 = new Driver("Max","Verstappen", 25);
Driver driver3 = new Driver("Robert","Kubica", 38);
Driver driver4 = new Driver("Lewis","Hamilton",38);

driver1.AddPoints(25);
driver1.AddPoints(18);
driver1.AddPoints(25);
driver1.AddPoints(15);

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

List<Driver> drivers = new List<Driver>()
{
    driver1, driver2, driver3, driver4  
};

int maxResult=-1;
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

