int ThirdDigit(int num)
{
    if (num < 100) return -1;
    
    while (num > 999) num = num / 10;
       
    return num % 10;
}

Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

int digit = ThirdDigit(num);

if (digit == -1) 
{
    Console.Write("There is no third digit in this number");
}
else
{
    Console.Write("Third digit is: ");
    Console.WriteLine(digit);
}