using System;

string name = "Ewa";
bool isMale = true;
int age = 33;
string gender;

if (isMale==true)
{
    gender="mężczyzna";
}
else
{
    gender = "kobieta";
}

if(age<30 && isMale==false)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name=="Ewa" && age==33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (isMale == true && age <18)
{
    Console.WriteLine("Niepelnoletni "+gender);
}
else if (age < 30)
{
    Console.WriteLine(name + ", " + gender + " ponizej 30 lat");
}
else if (age > 30)
{
    Console.WriteLine(name + ", " + gender + " ponizej 30 lat");
}
