bool WeekendDay(int day)
{
    if (day >= 6) {return true;} else {return false;}    
}

Console.Write("Enter the number of the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

if (WeekendDay(num)) 
{
    Console.Write("It's a weekend");
}
else
{
    Console.Write("It's a working day");
}