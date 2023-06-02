//Added comment to upload proper version of Homework day 5


int number = 4566;

string numberInString = number.ToString();

char[] letters = numberInString.ToArray();

int[] howMuch = new int[10];

foreach (char c in letters)
{


    for (int i = 0; i < 10; i++)
    {
        int toInt = c - '0';
        if(toInt==i)
        {
            howMuch[i] = howMuch[i]+1;
        }
    }

}

Console.WriteLine("Wyniki dla liczby: "+number);

for (int i=0; i<howMuch.Length; i++)
{
    Console.WriteLine(i + " => " + howMuch[i]);
}
