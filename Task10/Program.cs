int ThirdDigit(int num)
{
    return (num / 10) % 10;
}

Console.Write("Enter three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Third digit is: ");
Console.WriteLine(ThirdDigit(num));