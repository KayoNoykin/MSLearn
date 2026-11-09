// Project 1

/* string? readResult;
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer between 5 and 10");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        validNumber = int.TryParse(readResult, out numericValue);
        if (validNumber == false)
        {
            Console.WriteLine("Not an integer, please try again");
            continue;
        }
        if (numericValue < 5 || numericValue > 10)
        {
            Console.WriteLine($"{numericValue} is not between 5 and 10, please try again");
            validNumber = false;
            continue;
        }
        if (numericValue >= 5 && numericValue <= 10)
        {
            validNumber = true;
        }
    }
} while (validNumber == false);

Console.WriteLine("Value accepted"); */

// Project 2

/* string? readResult;
bool validEntry = false;

Console.WriteLine("Please input your role");

do
{
    Console.WriteLine("Valid roles are:");
    Console.WriteLine("Administrator | Manager | User");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        string? formattedResult = readResult.Trim().ToLower();
        if (formattedResult != "administrator" && formattedResult != "manager" && formattedResult !=  "user")
        {
            Console.WriteLine($"The role name that you entered, \"{readResult.Trim()}\" is not valid. Plase try again.");
            validEntry = false;
            continue;
        }
        if (formattedResult == "administrator" || formattedResult == "manager" || formattedResult == "user")
        {
            validEntry = true;
            continue;
        }
    }
} while (validEntry == false);

if (readResult != null)
Console.WriteLine($"Your input value \"{readResult.Trim()}\" has been accepted."); */

// Project 3

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation;
string mySentence;

foreach (string s in myStrings)
{
    string myString = s;
    periodLocation = myString.IndexOf(".");
    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1).Trim();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}